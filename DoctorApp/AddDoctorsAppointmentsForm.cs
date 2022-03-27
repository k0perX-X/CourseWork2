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

namespace DoctorApp
{
    public partial class AddDoctorsAppointmentsForm : Form
    {
        public AddDoctorsAppointmentsForm()
        {
            InitializeComponent();
            DoctorMainForm.LoadData();
        }

        private void doctor_s_appointmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctor_s_appointmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);
        }

        private void AddDoctorsAppointmentsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.course_backupDataSet.Doctors);
            // TODO: This line of code loads data into the 'course_backupDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.course_backupDataSet.Patients);
            // TODO: This line of code loads data into the 'course_backupDataSet.Prescribed_medications' table. You can move, or remove it, as needed.
            this.prescribed_medicationsTableAdapter.Fill(this.course_backupDataSet.Prescribed_medications);
            // TODO: This line of code loads data into the 'course_backupDataSet._Doctor_s_appointments' table. You can move, or remove it, as needed.
            this.doctor_s_appointmentsTableAdapter.Fill(this.course_backupDataSet._Doctor_s_appointments);
            doctor_s_appointmentsBindingSource.AddNew();
            dateTimeDateTimePicker.Value = DateTime.Now;
            visitedCheckBox.Checked = false;
            patient_IDComboBox.SelectedItem = patient_IDComboBox.Items[0];
            patient_IDComboBox.Text = ((DataRowView) patient_IDComboBox.Items[0]).Row.ItemArray[0].ToString();
            int i;
            for (i = 0; i < doctor_IDComboBox.Items.Count; i++)
            {
                if ((int)((DataRowView)doctor_IDComboBox.Items[i]).Row.ItemArray[0] == DoctorMainForm.SelectedDoctor.ID)
                    break;
            }
            doctor_IDComboBox.SelectedItem = doctor_IDComboBox.Items[i];
            doctor_IDComboBox.Text = ((DataRowView)doctor_IDComboBox.SelectedItem).Row.ItemArray[0].ToString();
        }

        private void buttonAddDrug_Click(object sender, EventArgs e)
        {
            doctor_s_appointmentsBindingNavigatorSaveItem_Click(sender, e);
            new AddPrescribedMedicationsForm(int.Parse(iDLabel1.Text)).ShowDialog();
            // TODO: This line of code loads data into the 'course_backupDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.course_backupDataSet.Doctors);
            // TODO: This line of code loads data into the 'course_backupDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.course_backupDataSet.Patients);
            // TODO: This line of code loads data into the 'course_backupDataSet.Prescribed_medications' table. You can move, or remove it, as needed.
            this.prescribed_medicationsTableAdapter.Fill(this.course_backupDataSet.Prescribed_medications);
            // TODO: This line of code loads data into the 'course_backupDataSet._Doctor_s_appointments' table. You can move, or remove it, as needed.
            this.doctor_s_appointmentsTableAdapter.Fill(this.course_backupDataSet._Doctor_s_appointments);
            doctor_s_appointmentsBindingNavigatorSaveItem_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dataGridViewRow in prescribed_medicationsDataGridView.SelectedRows)
            {
                prescribed_medicationsDataGridView.Rows.Remove(dataGridViewRow);
            }
            doctor_s_appointmentsBindingNavigatorSaveItem_Click(sender, e);
            // TODO: This line of code loads data into the 'course_backupDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.course_backupDataSet.Doctors);
            // TODO: This line of code loads data into the 'course_backupDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.course_backupDataSet.Patients);
            // TODO: This line of code loads data into the 'course_backupDataSet.Prescribed_medications' table. You can move, or remove it, as needed.
            this.prescribed_medicationsTableAdapter.Fill(this.course_backupDataSet.Prescribed_medications);
            // TODO: This line of code loads data into the 'course_backupDataSet._Doctor_s_appointments' table. You can move, or remove it, as needed.
            this.doctor_s_appointmentsTableAdapter.Fill(this.course_backupDataSet._Doctor_s_appointments);
            doctor_s_appointmentsBindingNavigatorSaveItem_Click(sender, e);
        }

        private void patient_IDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            patient_IDComboBox_Leave(sender, e);
        }

        private void patient_IDComboBox_Leave(object sender, EventArgs e)
        {
            Debug.Print("patient_IDComboBox_Leave");
            var Patients = DoctorMainForm.Patients;
            if (patient_IDComboBox.SelectedItem != null)
                try
                {
                    label1.Text = Patients.Single(b =>
                            b.ID == ((dynamic)((DataRowView)patient_IDComboBox
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
