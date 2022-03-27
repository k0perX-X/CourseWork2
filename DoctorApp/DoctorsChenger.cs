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
    public partial class DoctorsChenger : Form
    {
        public DoctorsChenger()
        {
            InitializeComponent();
        }

        private void doctorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.course_backupDataSet);
        }

        private void DoctorsChenger_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'course_backupDataSet.Doctors' table. You can move, or remove it, as needed.
                this.doctorsTableAdapter.Fill(this.course_backupDataSet.Doctors);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolStripLabelGenerateMD5_Click(object sender, EventArgs e)
        {
            var f = new GenerateMD5Form();
            //f.MdiParent = MdiParent;
            f.ShowDialog();
        }
    }
}
