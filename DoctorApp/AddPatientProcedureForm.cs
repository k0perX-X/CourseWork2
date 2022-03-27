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
    public partial class AddPatientProcedureForm : Form
    {
        public AddPatientProcedureForm()
        {
            InitializeComponent();
            DoctorMainForm.LoadData();
        }

        private void proceduresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proceduresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);
            //AddPatientProcedureForm_Load(sender, e);
        }

        private void AddPatientProcedureForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.course_backupDataSet.Patients);
            // TODO: This line of code loads data into the 'course_backupDataSet.Procedures_directory' table. You can move, or remove it, as needed.
            this.procedures_directoryTableAdapter.Fill(this.course_backupDataSet.Procedures_directory);
            // TODO: This line of code loads data into the 'course_backupDataSet.Procedures' table. You can move, or remove it, as needed.
            this.proceduresTableAdapter.Fill(this.course_backupDataSet.Procedures);
            proceduresBindingSource.AddNew();
            dateTimeDateTimePicker.Value = DateTime.Now;
            visitedCheckBox.Checked = false;
            patient_IDComboBox.SelectedItem = patient_IDComboBox.Items[0];
            procedure_IDComboBox.SelectedItem = procedure_IDComboBox.Items[0];
        }

        private void procedure_IDComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Debug.Print("procedure_IDComboBox_SelectedIndexChanged");
            var Procedures = DoctorMainForm.Procedures;
            if (procedure_IDComboBox.SelectedItem != null)
                try
                {
                    label1.Text = Procedures.Single(b =>
                            b.ID == ((Course_backupDataSet.Procedures_directoryRow)((DataRowView)procedure_IDComboBox
                                .SelectedItem).Row).ID)
                        .ToString();
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.StackTrace);
                }

        }

        private void patient_IDComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Debug.Print("patient_IDComboBox_SelectedIndexChanged");
            var Patients = DoctorMainForm.Patients;
            if (patient_IDComboBox.SelectedItem != null)
                try
                {
                    label2.Text = Patients.Single(b =>
                            b.ID == ((dynamic)((DataRowView)patient_IDComboBox
                                .SelectedItem).Row).ID)
                        .ToString();
                }
                catch (Exception ex)
                {
                    Debug.Print(ex.StackTrace);
                }
        }

        private void procedure_IDComboBox_Leave_1(object sender, EventArgs e)
        {
            procedure_IDComboBox_SelectedIndexChanged_1(sender, e);
        }

        private void patient_IDComboBox_Leave_1(object sender, EventArgs e)
        {
            patient_IDComboBox_SelectedIndexChanged_1(sender, e);
        }
    }
}
