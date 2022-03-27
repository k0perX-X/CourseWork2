using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApp
{
    public partial class AddPrescribedMedicationsForm : Form
    {
        private int _iD_Doctor_s_appointments;
        public AddPrescribedMedicationsForm(int iD_Doctor_s_appointments)
        {
            InitializeComponent();
            _iD_Doctor_s_appointments = iD_Doctor_s_appointments;
        }

        private void Save()
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    take_after_mealsCheckBox.Checked = true;
                    take_before_mealsCheckBox.Checked = false;
                    take_with_mealsCheckBox.Checked = false;
                    break;
                case 1:
                    take_after_mealsCheckBox.Checked = false;
                    take_before_mealsCheckBox.Checked = true;
                    take_with_mealsCheckBox.Checked = false;
                    break;
                case 2:
                    take_after_mealsCheckBox.Checked = false;
                    take_before_mealsCheckBox.Checked = false;
                    take_with_mealsCheckBox.Checked = true;
                    break;
            }
            this.Validate();
            this.prescribed_medicationsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);
        }

        private void AddPrescribedMedicationsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Drug_directory' table. You can move, or remove it, as needed.
            this.drug_directoryTableAdapter.Fill(this.course_backupDataSet.Drug_directory);
            // TODO: This line of code loads data into the 'course_backupDataSet.Prescribed_medications' table. You can move, or remove it, as needed.
            this.prescribed_medicationsTableAdapter.Fill(this.course_backupDataSet.Prescribed_medications);
            prescribed_medicationsBindingSource.AddNew();
            take_medicine_before_the_dateDateTimePicker.Value = DateTime.Now;
            drug_IDComboBox.SelectedItem = drug_IDComboBox.Items[0];
            reception_time_during_the_dayCheckBox.Checked = false;
            reception_time_in_the_eveningCheckBox.Checked = false;
            reception_time_in_the_morningCheckBox.Checked = false;
            take_after_mealsCheckBox.Checked = false;
            take_before_mealsCheckBox.Checked = false;
            take_with_mealsCheckBox.Checked = false;
            iD_Doctor_s_appointmentsLabel1.Text = _iD_Doctor_s_appointments.ToString();
            comboBox1.SelectedItem = comboBox1.Items[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show("Сохранить?", "Сохранить?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    button1_Click(sender, e);
                    break;
                case DialogResult.No:
                    Close();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void drug_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            drug_IDComboBox_Leave(sender, e);
        }

        private void drug_IDComboBox_Leave(object sender, EventArgs e)
        {
            Debug.Print("patient_IDComboBox_SelectedIndexChanged");
            var drugs = DoctorMainForm.Drugs;
            if (drug_IDComboBox.SelectedItem != null)
                try
                {
                    label2.Text = drugs.Single(b =>
                            b.ID == ((dynamic)((DataRowView)drug_IDComboBox
                                .SelectedItem).Row).ID)
                        .ToString();
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.StackTrace);
                }
        }
    }
}
