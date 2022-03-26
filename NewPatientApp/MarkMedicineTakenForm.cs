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
    public partial class MarkMedicineTakenForm : Form
    {
        private bool _buttonClose = false;
        public MarkMedicineTakenForm()
        {
            InitializeComponent();
            foreach (var prescribedMedication in MainForm.PrescribedMedications)
            {
                comboBox1.Items.Add(prescribedMedication);
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
                           @"INSERT INTO [Medications taken] 
	                                    ([Patient ID], [Drug ID], DateTime, [Reception time in the morning], [Reception time during the day], 
	                                    [Reception time in the evening])
                                    VALUES (@PatientID, @DrugID, @DateTime, @ReceptionTimeInTheMorning, 
                                        @ReceptionTimeDuringTheDay, @ReceptionTimeInTheEvening)", con))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PatientID", MainForm.SelectedPatient.ID);
                        command.Parameters.AddWithValue("@DrugID", ((PrescribedMedication)comboBox1.SelectedItem).DrugID);
                        command.Parameters.AddWithValue("@DateTime", DateTime.Now);
                        command.Parameters.AddWithValue("@ReceptionTimeInTheMorning", checkBoxReceptionTimeInTheMorning.Checked);
                        command.Parameters.AddWithValue("@ReceptionTimeDuringTheDay", checkBoxReceptionTimeDuringTheDay.Checked);
                        command.Parameters.AddWithValue("@ReceptionTimeInTheEvening", checkBoxReceptionTimeInTheEvening.Checked);
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
                if (checkBoxReceptionTimeInTheMorning.Checked)
                    using (var command = new SqlCommand(
                               @"UPDATE [Patient's drugs]
                                        SET Remaining = Remaining - 1
                                        where [Patient ID] = @PatientID and [Drug ID] = @DrugID and Remaining > 0 and [Date of manufacture] = 
	                                        (Select top(1) t.[Date of manufacture] from 
		                                        (Select [Date of manufacture] from [Patient's drugs] 
		                                        where [Patient ID] = @PatientID and [Drug ID] = @DrugID and Remaining > 0) as t
	                                        Order by t.[Date of manufacture])", con))
                        try
                        {
                            command.Parameters.AddWithValue("@PatientID", MainForm.SelectedPatient.ID);
                            command.Parameters.AddWithValue("@DrugID",
                                ((PrescribedMedication)comboBox1.SelectedItem).DrugID);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }
                if (checkBoxReceptionTimeDuringTheDay.Checked)
                    using (var command = new SqlCommand(
                               @"UPDATE [Patient's drugs]
                                        SET Remaining = Remaining - 1
                                        where [Patient ID] = @PatientID and [Drug ID] = @DrugID and Remaining > 0 and [Date of manufacture] = 
	                                        (Select top(1) t.[Date of manufacture] from 
		                                        (Select [Date of manufacture] from [Patient's drugs] 
		                                        where [Patient ID] = @PatientID and [Drug ID] = @DrugID and Remaining > 0) as t
	                                        Order by t.[Date of manufacture])", con))
                        try
                        {
                            command.Parameters.AddWithValue("@PatientID", MainForm.SelectedPatient.ID);
                            command.Parameters.AddWithValue("@DrugID",
                                ((PrescribedMedication)comboBox1.SelectedItem).DrugID);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
                        }
                if (checkBoxReceptionTimeInTheEvening.Checked)
                    using (var command = new SqlCommand(
                               @"UPDATE [Patient's drugs]
                                        SET Remaining = Remaining - 1
                                        where [Patient ID] = @PatientID and [Drug ID] = @DrugID and Remaining > 0 and [Date of manufacture] = 
	                                        (Select top(1) t.[Date of manufacture] from 
		                                        (Select [Date of manufacture] from [Patient's drugs] 
		                                        where [Patient ID] = @PatientID and [Drug ID] = @DrugID and Remaining > 0) as t
	                                        Order by t.[Date of manufacture])", con))
                        try
                        {
                            command.Parameters.AddWithValue("@PatientID", MainForm.SelectedPatient.ID);
                            command.Parameters.AddWithValue("@DrugID",
                                ((PrescribedMedication) comboBox1.SelectedItem).DrugID);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine(exception);
                            throw;
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

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            var o = (PrescribedMedication) comboBox1.SelectedItem;
            checkBoxReceptionTimeInTheMorning.Enabled = o.ReceptionTimeInTheMorning;
            checkBoxReceptionTimeInTheMorning.Checked = !o.ReceptionTimeInTheMorning;
            checkBoxReceptionTimeDuringTheDay.Enabled = o.ReceptionTimeDuringTheDay;
            checkBoxReceptionTimeInTheMorning.Checked = !o.ReceptionTimeDuringTheDay;
            checkBoxReceptionTimeInTheEvening.Enabled = o.ReceptionTimeInTheEvening;
            checkBoxReceptionTimeInTheMorning.Checked = !o.ReceptionTimeInTheEvening;
        }
    }
}
