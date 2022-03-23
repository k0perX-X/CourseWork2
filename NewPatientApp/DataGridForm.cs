using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewPatientApp
{
    public partial class DataGridForm : Form
    {
        public DataGridView DataGridView
        {
            get { return dataGridView; }
        }
        public DataGridForm(string FormName, bool readOnly = true)
        {
            InitializeComponent();
            Name = FormName;
            dataGridView.ReadOnly = readOnly;
        }
    }
}
