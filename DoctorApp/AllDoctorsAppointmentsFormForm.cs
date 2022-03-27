using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorApp
{
    public partial class AllDoctorsAppointmentsForm : Form
    {
        public AllDoctorsAppointmentsForm()
        {
            InitializeComponent();
        }

        private void doctor_s_appointmentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctor_s_appointmentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);

        }

        private void AllDoctorsAppointmentsFormForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Prescribed_medications' table. You can move, or remove it, as needed.
            this.prescribed_medicationsTableAdapter.Fill(this.course_backupDataSet.Prescribed_medications);
            // TODO: This line of code loads data into the 'course_backupDataSet._Doctor_s_appointments' table. You can move, or remove it, as needed.
            this.doctor_s_appointmentsTableAdapter.Fill(this.course_backupDataSet._Doctor_s_appointments);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctor_s_appointmentsTableAdapter.FillBy(this.course_backupDataSet._Doctor_s_appointments, ((int)(System.Convert.ChangeType(selectedDoctorToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void returnToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctor_s_appointmentsTableAdapter.Return(this.course_backupDataSet._Doctor_s_appointments);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
