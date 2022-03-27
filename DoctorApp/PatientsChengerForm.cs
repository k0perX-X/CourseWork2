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
    public partial class PatientsChengerForm : Form
    {
        public PatientsChengerForm()
        {
            InitializeComponent();
        }

        private void patientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);

        }

        private void PatientsChengerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.course_backupDataSet.Patients);
        }

        private void toolStripLabelGenerateMD5_Click(object sender, EventArgs e)
        {
            var f = new GenerateMD5Form();
            //f.MdiParent = MdiParent;
            f.ShowDialog();
        }
    }
}
