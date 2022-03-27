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
    public partial class ProceduresChengerForm : Form
    {
        public ProceduresChengerForm()
        {
            InitializeComponent();
        }

        private void procedures_directoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.procedures_directoryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);

        }

        private void ProceduresChengerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'course_backupDataSet.Procedures_directory' table. You can move, or remove it, as needed.
            this.procedures_directoryTableAdapter.Fill(this.course_backupDataSet.Procedures_directory);

        }
    }
}
