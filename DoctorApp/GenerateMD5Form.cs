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
    public partial class GenerateMD5Form : Form
    {
        public GenerateMD5Form()
        {
            InitializeComponent();
        }

        private void GenerateMD5Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = LoginForm.CreateMD5(textBox1.Text);
        }
    }
}
