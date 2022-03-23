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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace NewPatientApp
{
    public partial class LoginForm : Form
    {
        private static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                return Convert.ToHexString(hashBytes); // .NET 5 +

                // Convert the byte array to hexadecimal string prior to .NET 5
                // StringBuilder sb = new System.Text.StringBuilder();
                // for (int i = 0; i < hashBytes.Length; i++)
                // {
                //     sb.Append(hashBytes[i].ToString("X2"));
                // }
                // return sb.ToString();
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
        private Patient _selectedPatient;
        public LoginForm()
        {
            InitializeComponent();
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select p.Name, p.Surname, p.[Middle name], p.ID from Patients as p", connection);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string s = ((int)dr["ID"]).ToString() + ", " +  dr["Surname"].ToString() + "  " + dr["Name"].ToString();
                    if (dr["Middle name"] != null)
                        s += " " + dr["Middle name"];
                    comboBox1.Items.Add(new comboBoxItem { Tag=(int)dr["ID"], Text = s});
                }
            }
        }

        public Patient Login()
        {
            ShowDialog();
            return _selectedPatient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select * from Patients as p where p.ID = @SelectedPatient", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", ((comboBoxItem) comboBox1.SelectedItem).Tag);
                var dr = cmd.ExecuteReader();
                dr.Read();
                password = (string) dr["Password"];

                Debug.Print($"{maskedTextBox1.Text} {CreateMD5(maskedTextBox1.Text)} {password}");
                if (password == CreateMD5(maskedTextBox1.Text))
                {
                    _selectedPatient = new Patient()
                    {
                        ID = (int) dr["ID"],
                        Name = (string) dr["Name"],
                        Surname = (string) dr["Surname"],
                        MiddleName = dr["Middle name"].GetType() is DBNull ? (string?)dr["Middle name"] : null,
                        Birthdate = (DateTime) dr["Birthdate"],
                        EMail = (string) dr["e-mail"],
                        Note = dr["Note"].GetType() is DBNull ? (string?)dr["Note"] : null,
                        OtherInformation = dr["Other information"].GetType() is DBNull ? (string?)dr["Other information"] : null
                    };
                    Close();
                }
                else
                {
                    connection.Close();
                    MessageBox.Show("Введенный пароль не верен", "Ошибка аутентификации", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
