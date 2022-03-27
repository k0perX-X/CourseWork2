using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DoctorApp
{
    public partial class LoginForm : Form
    {
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                //return Convert.ToHexString(hashBytes); // .NET 5 +

                // Convert the byte array to hexadecimal string prior to .NET 5
                StringBuilder sb = new System.Text.StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
        private class comboBoxItem
        {
            public string Text { set; get; }
            public int Tag { set; get; }
            public override string ToString()
            {
                return Text;
            }
        }
        private Doctor _selectedDoctor;
        public LoginForm()
        {
            InitializeComponent();
            try
            {
                using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(
                        @"Select p.Name, p.Surname, p.[Middle name], p.ID from Doctors as p", connection);
                    var dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        string s = ((int) dr["ID"]).ToString() + ", " + dr["Surname"].ToString() + "  " +
                                   dr["Name"].ToString();
                        if (dr["Middle name"] != null)
                            s += " " + dr["Middle name"];
                        comboBox1.Items.Add(new comboBoxItem {Tag = (int) dr["ID"], Text = s});
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Ошибка подключения к серверу, проверьте подключение к интеренету\n\n{ex.Message}", "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                Application.Exit();
            }
        }

        public Doctor Login()
        {
            ShowDialog();
            return _selectedDoctor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select * from Doctors as p where p.ID = @SelectedDoctor", connection);
                cmd.Parameters.AddWithValue("@SelectedDoctor", ((comboBoxItem) comboBox1.SelectedItem).Tag);
                var dr = cmd.ExecuteReader();
                dr.Read();
                password = (string) dr["Password"];

                Debug.Print($"{maskedTextBox1.Text} {CreateMD5(maskedTextBox1.Text)} {password}");
                if (password.ToLower() == CreateMD5(maskedTextBox1.Text).ToLower())
                {
                    _selectedDoctor = new Doctor()
                    {
                        ID = (int) dr["ID"],
                        Name = (string) dr["Name"],
                        Surname = (string) dr["Surname"],
                        MiddleName = dr["Middle name"]is DBNull ? null : (string)dr["Middle name"],
                        Birthdate = (DateTime) dr["Birthdate"],
                        EMail = (string) dr["e-mail"],
                        Note = dr["Note"] is DBNull ? null : (string)dr["Note"],
                        OtherInformation = dr["Other information"] is DBNull ? null : (string)dr["Other information"] 
                    };
                    Close();
                }
                else
                {
                    connection.Close();
                    maskedTextBox1.Text = "";
                    MessageBox.Show("Введенный пароль не верен", "Ошибка аутентификации", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
