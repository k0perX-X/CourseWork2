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
    public partial class AllPatientProcedureForm : Form
    {
        public AllPatientProcedureForm()
        {
            InitializeComponent();
        }

        private void proceduresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proceduresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);

        }

        private void AllPatientProcedureForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Procedures' table. You can move, or remove it, as needed.
            this.proceduresTableAdapter.Fill(this.course_backupDataSet.Procedures);

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proceduresTableAdapter.FillBy1(this.course_backupDataSet.Procedures, ((int)(System.Convert.ChangeType(patientIDToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
