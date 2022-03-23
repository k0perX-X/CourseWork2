using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NewPatientApp
{
    public partial class MainForm : Form
    {
        public Patient SelectedPatient;
        public List<Procedures> ProceduresList = new List<Procedures>();
        public List<DoctorAppointment> DoctorAppointmentsList = new List<DoctorAppointment>();

        public void LoadProcedures()
        {
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select ID, DateTime, ProcedureID, ProcedureName, ProcedureNote, Note, Visited
                            from (
		                            (Select ID as ProcedureID, Name as ProcedureName, Note as ProcedureNote 
		                            from [Procedures directory]) as prod 
	                            join 
		                            (Select * from Procedures
		                            where [Patient ID] = @SelectedPatient) as pro 
	                            on pro.[Procedure ID] = prod.ProcedureID)", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", (int)SelectedPatient);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ProceduresList.Add(new Procedures
                    {
                        ID = (int)dr["ID"],
                        DateTime = (DateTime)dr["DateTime"],
                        ProcedureID = (int)dr["ProcedureID"],
                        ProcedureName = (string)dr["ProcedureName"],
                        ProcedureNote = (string)dr["ProcedureNote"],
                        Note = (string)dr["Note"],
                        Visited = (bool)dr["Visited"]
                    });
                }
                DateTime[] dateTimes = new DateTime[ProceduresList.Count];
                for (int i = 0; i < dateTimes.Length; i++)
                    dateTimes[i] = ProceduresList[i].DateTime;
                monthCalendarProcedure.BoldedDates = dateTimes;
            }
        }
        public void LoadDoctorAppointments()
        {
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select 
	                            ID as DoctorAppointmentID, [Patient temperature] as PatientTemperature, 
	                            DateTime, [Word file] as WordFile, Note, Visited, DoctorID, DoctorName, 
	                            DoctorSurname, DoctorMiddleName, DoctorNote, DoctorBirthdate, 
	                            DoctorEMail, DoctorOtherInformation
                            from (
		                            (Select ID as DoctorID, Name as DoctorName, Surname as DoctorSurname, 
		                            [Middle name] as DoctorMiddleName, Note as DoctorNote, 
		                            Birthdate as DoctorBirthdate, [e-mail] as DoctorEMail,
		                            [Other information] as DoctorOtherInformation
		                            from Doctors) as doc 
	                            join 
		                            (Select * from [Doctor's appointments]
		                            where [Patient ID] = @SelectedPatient) as app 
	                            on app.[Doctor ID] = doc.DoctorID)", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", (int)SelectedPatient);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DoctorAppointmentsList.Add(new DoctorAppointment()
                    {
                        ID = (int)dr["DoctorAppointmentID"],
                        DateTime = (DateTime)dr["DateTime"],
                        PatientTemperature = (double) dr["PatientTemperature"],
                        WordFile = (string) dr["WordFile"],
                        Note = (string)dr["Note"],
                        Visited = (bool)dr["Visited"],
                        DoctorID = (int) dr["DoctorID"],
                        DoctorName = (string) dr["DoctorName"],
                        DoctorSurname = (string)dr["DoctorSurname"],
                        DoctorMiddleName = (string)dr["DoctorMiddleName"],
                        DoctorNote = (string)dr["DoctorNote"],
                        DoctorBirthdate = (DateTime) dr["DoctorBirthdate"],
                        DoctorEMail = (string)dr["DoctorEMail"],
                        DoctorOtherInformation = (string)dr["DoctorOtherInformation"]
                    });
                }
                DateTime[] dateTimes = new DateTime[DoctorAppointmentsList.Count];
                for (int i = 0; i < dateTimes.Length; i++)
                    dateTimes[i] = DoctorAppointmentsList[i].DateTime;
                monthCalendarDoctor.BoldedDates = dateTimes;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Show();
            SelectedPatient = (new LoginForm()).Login();
            if ((int)SelectedPatient == 0)
            {
                Close();
            }
            LoadProcedures();
            LoadDoctorAppointments();
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox1()).ShowDialog();
        }

        private void выбратьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void отчетыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void переченьПроцедурToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void переченьЛекарсовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void переченьДокторовToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddDoctorAppointments_Click(object sender, EventArgs e)
        {

        }

        private void buttonMarkDoctorVisit_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoctorAppointmentsList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddProcedure_Click(object sender, EventArgs e)
        {

        }

        private void buttonMarkVisitProcedure_Click(object sender, EventArgs e)
        {

        }

        private void buttonProcedureList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddPatientDrag_Click(object sender, EventArgs e)
        {

        }

        private void buttonPatientDragList_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddWellBeing_Click(object sender, EventArgs e)
        {

        }

        private void buttonMarkMedicineTaken_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
