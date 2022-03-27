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
    public partial class TimeSpanSelectForm : Form
    {
        public delegate void GenerateReport(DateTime firstDateTime, DateTime secondDateTime);

        private readonly GenerateReport _generateReport;
        public TimeSpanSelectForm(GenerateReport generateReport)
        {
            InitializeComponent();
            _generateReport = generateReport;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _generateReport(dateTimePicker1.Value, dateTimePicker2.Value);
            Close();
        }
    }
}
