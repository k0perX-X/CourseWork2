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
    public partial class DoctorMainForm : Form
    {
        public static Doctor SelectedDoctor;
        public DoctorMainForm()
        {
            InitializeComponent();
            Show();
            SelectedDoctor = (new LoginForm()).Login();
            if (SelectedDoctor == null)
            {
                Close();
            }
            else
            {
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
