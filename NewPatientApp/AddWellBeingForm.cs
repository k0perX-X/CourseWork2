using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NewPatientApp
{
    public partial class AddWellBeingForm : Form
    {
        private bool _buttonClose = false;

        public AddWellBeingForm()
        {
            InitializeComponent();
        }

        private void AddWellBeingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_buttonClose)
                switch (MessageBox.Show("Сохранить изменения?", "Выход из меню", MessageBoxButtons.YesNoCancel,
                            MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        save();
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        e.Cancel = true;
                        break;
                }
        }

        private bool save(FormClosingEventArgs? e = null)
        {
            using (var con = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                con.Open();
                using (var command = new SqlCommand(
                           @"INSERT INTO [Well-being records] ([Patient ID], DataTime, Temperature, Note)
                                    VALUES (@PatientID, @DateTime, @Temperature, @Note)", con))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", MainForm.SelectedPatient.ID);
                        command.Parameters.AddWithValue("@DateTime", DateTime.Now);
                        command.Parameters.AddWithValue("@Temperature", numericUpDown.Value);
                        command.Parameters.AddWithValue("@Note",
                            richTextBox1.Text == "" ? DBNull.Value : richTextBox1.Text);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Debug.Print("DB insert error: " + ex.Message);
                        MessageBox.Show("Введенные данные некоректны", "Ошибка данных", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        if (e != null)
                            e.Cancel = true;
                        return false;
                    }
                }
            }

            return true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (save())
            {
                _buttonClose = true;
                Close();
            }
        }
    }
}
