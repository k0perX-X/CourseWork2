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
    public partial class AddPatientDragForm : Form
    {
        private bool _buttonClose = false;
        public AddPatientDragForm()
        {
            InitializeComponent();
            foreach (var drug in MainForm.Drugs)
            {
                comboBox1.Items.Add(drug);
            }
        }

        private void AddPatientDrag_FormClosing(object sender, FormClosingEventArgs e)
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
                           @"INSERT INTO [Patient's drugs] ([Patient ID], [Drug ID], Remaining, [Date of manufacture])
                                    VALUES (@PatientID, @DrugID, @Remaining, @DateOfManufacture)", con))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", MainForm.SelectedPatient.ID);
                        command.Parameters.AddWithValue("@DrugID", ((Drug)comboBox1.SelectedItem).ID);
                        command.Parameters.AddWithValue("@Remaining", numericUpDown1.Value);
                        command.Parameters.AddWithValue("@DateOfManufacture", dateTimePicker1.Value);
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
