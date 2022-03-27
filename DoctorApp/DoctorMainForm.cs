using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DoctorApp
{
    public partial class DoctorMainForm : Form
    {
        public static Doctor SelectedDoctor;

        public static List<Patient> Patients;

        public static List<Procedure> Procedures;

        public static List<Drug> Drugs;

        public static void LoadData()
        {
            Patients = new List<Patient>();
            Procedures = new List<Procedure>();
            Drugs = new List<Drug>();
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from Patients", connection);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Patients.Add(new Patient()
                    {
                        ID = (int)dr["ID"],
                        Surname = (string)dr["Surname"],
                        Name = (string)dr["Name"],
                        MiddleName = dr["Middle name"] is DBNull ? null : (string)dr["Middle name"],
                        Birthdate = (DateTime)dr["Birthdate"],
                        EMail = (string)dr["e-mail"],
                        OtherInformation = dr["Other information"] is DBNull ? null : (string)dr["Other information"],
                        Note = dr["Note"] is DBNull ? null : (string)dr["Note"],
                    });
                }
                dr.Close();
                cmd = new SqlCommand(@"Select * from [Procedures directory]", connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Procedures.Add(new Procedure()
                    {
                        ID = (int)dr["ID"],
                        Name = (string)dr["Name"],
                        Note = dr["Note"] is DBNull ? null : (string)dr["Note"]
                    });
                }
                dr.Close();
                cmd = new SqlCommand(@"Select * from [Drug directory]", connection);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Drugs.Add(new Drug()
                    {
                        ID = (int)dr["ID"],
                        Name = (string)dr["Drug Name"],
                        Note = dr["Note"] is DBNull ? null : (string)dr["Note"],
                        ExpirationDate = (int) dr["Expiration date"]
                    });
                }
            }
        }

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
                LoadData();
                if (SelectedDoctor.ID == 2)
                {
                    менюСуперПользователяToolStripMenuItem.Visible = true;
                    менюСуперПользователяToolStripMenuItem.DropDownItems.Add("Изменить список докторов");
                    менюСуперПользователяToolStripMenuItem.DropDownItems[менюСуперПользователяToolStripMenuItem.DropDownItems.Count - 1].Click += 
                        добавитьДоктораToolStripMenuItem_Click;
                    менюСуперПользователяToolStripMenuItem.DropDownItems.Add("Изменить список пациентов");
                    менюСуперПользователяToolStripMenuItem.DropDownItems[менюСуперПользователяToolStripMenuItem.DropDownItems.Count - 1].Click += 
                        добавитьПациентаToolStripMenuItem_Click;
                    менюСуперПользователяToolStripMenuItem.DropDownItems.Add("Изменить список лекарств");
                    менюСуперПользователяToolStripMenuItem.DropDownItems[менюСуперПользователяToolStripMenuItem.DropDownItems.Count - 1].Click += 
                        добавитьЛекарствоToolStripMenuItem_Click;
                    менюСуперПользователяToolStripMenuItem.DropDownItems.Add("Изменить список процедур");
                    менюСуперПользователяToolStripMenuItem.DropDownItems[менюСуперПользователяToolStripMenuItem.DropDownItems.Count - 1].Click += 
                        добавитьПроцедуруToolStripMenuItem_Click;
                }
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void добавитьДоктораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new DoctorsChenger();
            o.MdiParent = this;
            o.Show();
        }

        private void добавитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new PatientsChengerForm();
            o.MdiParent = this;
            o.Show();
        }
        private void добавитьЛекарствоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new DrugsChangerForm();
            o.MdiParent = this;
            o.Show();
        }
        private void добавитьПроцедуруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new ProceduresChengerForm();
            o.MdiParent = this;
            o.Show();
        }

        private void добавитьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new AddPatientProcedureForm();
            o.MdiParent = this;
            o.Show();
        }

        private void всеЗаписиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new AllPatientProcedureForm();
            o.MdiParent = this;
            o.Show();
        }

        private void добавитьПосещениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new AddDoctorsAppointmentsForm();
            o.MdiParent = this;
            o.Show();
        }

        private void списокВсехПосещенийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var o = new AllDoctorsAppointmentsForm();
            o.MdiParent = this;
            o.Show();
        }
    }
}
