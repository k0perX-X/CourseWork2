using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NewPatientApp
{
    public partial class MainForm : Form
    {
        public Patient? SelectedPatient;
        public List<PatientProcedure> PatientProceduresList = new List<PatientProcedure>();
        public List<DoctorAppointment> DoctorAppointmentsList = new List<DoctorAppointment>();
        public List<PatientDrug> DrugRunningOut = new List<PatientDrug>();
        public List<PrescribedMedication> PrescribedMedications = new();

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
                    PatientProceduresList.Add(new PatientProcedure
                    {
                        ID = (int)dr["ID"],
                        DateTime = (DateTime)dr["DateTime"],
                        ProcedureID = (int)dr["ProcedureID"],
                        ProcedureName = (string)dr["ProcedureName"],
                        ProcedureNote = dr["ProcedureNote"].GetType() is DBNull ? (string?)dr["ProcedureNote"] : null,
                        Note = dr["Note"].GetType() is DBNull ? (string?)dr["Note"] : null,
                        Visited = (bool)dr["Visited"],
                        Patient = SelectedPatient,
                        PatientID = SelectedPatient.ID
                    });
                }
            }
            DateTime[] dateTimes = new DateTime[PatientProceduresList.Count];
            for (int i = 0; i < dateTimes.Length; i++)
                dateTimes[i] = PatientProceduresList[i].DateTime;
            monthCalendarProcedure.BoldedDates = dateTimes;
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
	                            right join 
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
                        PatientTemperature = dr["PatientTemperature"].GetType() is DBNull ? (double?) dr["PatientTemperature"] : null,
                        WordFile = dr["WordFile"].GetType() is DBNull ? (string?)dr["WordFile"] : null,
                        Note = dr["Note"].GetType() is DBNull ? (string?)dr["Note"] : null,
                        Visited = (bool)dr["Visited"],
                        DoctorID = (int) dr["DoctorID"],
                        DoctorName = (string) dr["DoctorName"],
                        DoctorSurname = (string)dr["DoctorSurname"],
                        DoctorMiddleName = dr["DoctorMiddleName"].GetType() is DBNull ? (string?)dr["DoctorMiddleName"] : null,
                        DoctorNote = dr["DoctorNote"].GetType() is DBNull ? (string?)dr["DoctorNote"] : null,
                        DoctorBirthdate = (DateTime) dr["DoctorBirthdate"],
                        DoctorEMail = (string)dr["DoctorEMail"],
                        DoctorOtherInformation = dr["DoctorOtherInformation"].GetType() is DBNull ? (string?)dr["DoctorOtherInformation"] : null,
                        Patient = SelectedPatient,
                        PatientID = SelectedPatient.ID
                    });
                }
            }
            DateTime[] dateTimes = new DateTime[DoctorAppointmentsList.Count];
            for (int i = 0; i < dateTimes.Length; i++)
                dateTimes[i] = DoctorAppointmentsList[i].DateTime;
            monthCalendarDoctor.BoldedDates = dateTimes;
        }

        public void LoadDrugRunningOut()
        {
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select 
	                            pd.ID as pdID, pd.[Date of manufacture] as DateOfManufacture, 
	                            pd.Remaining as Remaining, dd.[Drug Name] as Name
                            from 
	                            (Select * from [Patient's drugs]
	                            where Remaining < 10 and [Patient ID] = @SelectedPatient) as pd
                            left join 
	                            [Drug directory] as dd
                            on pd.[Drug ID] = dd.ID; ", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", (int)SelectedPatient);
                Dictionary<int, (PatientDrug p, bool r, bool d)> dic = new();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var o = new PatientDrug()
                    {
                        ID = (int) dr["pdID"],
                        DateOfManufacture = (DateTime) dr["DateOfManufacture"],
                        Name = (string) dr["Name"],
                        Remaining = (int) dr["Remaining"]
                    };
                    DrugRunningOut.Add(o);
                    dic.Add(o.ID, (o, true, false));
                }
                dr.Close();
                cmd = new SqlCommand(
                    @"Select 
	                            pd.ID as pdID, pd.[Date of manufacture] as DateOfManufacture, 
	                            pd.Remaining as Remaining, dd.[Drug Name] as Name
                            from 
	                            (Select * from [Patient's drugs]
	                            where [Patient ID] = @SelectedPatient and Remaining > 0) as pd
                            left join 
	                            [Drug directory] as dd
                            on pd.[Drug ID] = dd.ID
                            where DATEDIFF(MM, 
	                            DATEADD(dd, dd.[Expiration date], pd.[Date of manufacture]), 
	                            GETDATE()) > -30
                            and DATEDIFF(MM, 
	                            DATEADD(dd, dd.[Expiration date], pd.[Date of manufacture]), 
	                            GETDATE()) <= 0;", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", (int)SelectedPatient);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var o = new PatientDrug()
                    {
                        ID = (int)dr["pdID"],
                        DateOfManufacture = (DateTime)dr["DateOfManufacture"],
                        Name = (string)dr["Name"],
                        Remaining = (int)dr["Remaining"]
                    };
                    if (dic.ContainsKey(o.ID))
                        dic[o.ID] = (o, true, true);
                    else
                    {
                        DrugRunningOut.Add(o);
                        dic.Add(o.ID, (o, false, true));
                    }
                }

                foreach (KeyValuePair<int, (PatientDrug p, bool r, bool d)> keyValuePair in dic)
                {
                    if (keyValuePair.Value.r & keyValuePair.Value.d)
                    {
                        var row = new DataGridViewRow();
                        row.Cells[0].Value = keyValuePair.Value.p.Name;
                        row.Cells[1].Value = "Осталось " + keyValuePair.Value.p.Remaining + " доз и истекает срок годности";
                        dataGridViewDrugRunningOut.Rows.Add(row);
                    }
                    else if (keyValuePair.Value.r)
                    {
                        var row = new DataGridViewRow();
                        row.Cells[0].Value = keyValuePair.Value.p.Name;
                        row.Cells[1].Value = "Осталось " + keyValuePair.Value.p.Remaining + " доз";
                        dataGridViewDrugRunningOut.Rows.Add(row);
                    }
                    else
                    {
                        var row = new DataGridViewRow();
                        row.Cells[0].Value = keyValuePair.Value.p.Name;
                        row.Cells[1].Value = "Истекает срок годности";
                        dataGridViewDrugRunningOut.Rows.Add(row);
                    }
                }
            }
        }

        public void LoadPrescribedMedications()
        {
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(
                    @"Select 
	                            [ID Doctor's appointments], PrescribedMedicationsID,
	                            [Reception time during the day], [Reception time in the evening],
	                            [Reception time in the morning], [Take before meals], [Take after meals],
	                            [Take with meals], PrescribedMedicationsNote, DrugName, DrugNote, DrugID
                            from 
	                            (Select * from [Doctor's appointments]
	                            where [Patient ID] = 1) as da
                            left join 
	                            (Select 
		                            [ID Doctor's appointments], PrescribedMedicationsID,
		                            [Reception time during the day], [Reception time in the evening],
		                            [Reception time in the morning], [Take before meals], [Take after meals],
		                            [Take with meals], PrescribedMedicationsNote, [Drug Name] as DrugName, 
		                            Note as DrugNote, ID as DrugID
	                            from 
		                            (Select 
			                            [Drug ID], [ID Doctor's appointments], ID as PrescribedMedicationsID,
			                            [Reception time during the day], [Reception time in the evening],
			                            [Reception time in the morning], [Take before meals], [Take after meals],
			                            [Take with meals], Note as PrescribedMedicationsNote
		                            from [Prescribed medications]
		                            where DATEDIFF(DD, 
			                            [Take medicine before the date], 
			                            GETDATE()) <= 0) as pm
	                            left join 
		                            [Drug directory] as dd
	                            on pm.[Drug ID] = dd.ID) as newpm
                            on da.ID = newpm.[ID Doctor's appointments]", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", (int) SelectedPatient);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PrescribedMedication.Meals m;
                    if ((bool) dr["Take after meals"])
                        m = PrescribedMedication.Meals.TakeAfterMeals;
                    else if ((bool) dr["Take before meals"])
                        m = PrescribedMedication.Meals.TakeBeforeMeals;
                    else
                        m = PrescribedMedication.Meals.TakeWithMeals;
                    PrescribedMedications.Add(new PrescribedMedication()
                    {
                        DoctorAppointment = DoctorAppointmentsList.Single(b => b.ID == (int) dr["ID Doctor's appointments"]),
                        DoctorAppointmentID = (int)dr["ID Doctor's appointments"],
                        DrugID = (int) dr["DrugID"],
                        DrugName = (string) dr["DrugName"],
                        DrugNote = dr["DrugNote"].GetType() is DBNull ? (string?)dr["DrugNote"] : null,
                        ID = (int) dr["PrescribedMedicationsID"],
                        Note = dr["Note"].GetType() is DBNull ? (string?)dr["Note"] : null,
                        ReceptionTimeDuringTheDay = (bool)dr["Reception time during the day"],
                        ReceptionTimeInTheEvening = (bool)dr["Reception time in the evening"],
                        ReceptionTimeInTheMorning = (bool)dr["Reception time in the morning"],
                        TakeMeals = m
                    });
                }
            }

            foreach (PrescribedMedication prescribedMedication in PrescribedMedications)
            {
                var row = new DataGridViewRow();
                row.Cells[0].Value = prescribedMedication.DrugName;
                row.Cells[1].Value = "Принимать";
                bool changed = false;
                if (prescribedMedication.ReceptionTimeInTheMorning)
                {
                    row.Cells[1].Value += " утром";
                    changed = true;
                }

                if (prescribedMedication.ReceptionTimeDuringTheDay)
                {
                    row.Cells[1].Value += changed ? ", днем" : " днем";
                    changed = true;
                }
                if (prescribedMedication.ReceptionTimeInTheEvening)
                    row.Cells[1].Value += changed ? ", вечером" : " вечером";
                switch (prescribedMedication.TakeMeals)
                {
                    case PrescribedMedication.Meals.TakeAfterMeals:
                        row.Cells[1].Value += " после еды";
                        break;
                    case PrescribedMedication.Meals.TakeBeforeMeals:
                        row.Cells[1].Value += " до еды";
                        break;
                    case PrescribedMedication.Meals.TakeWithMeals:
                        row.Cells[1].Value += " во время еды";
                        break;
                }
                dataGridViewDrugRunningOut.Rows.Add(row);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            Show();
            SelectedPatient = (new LoginForm()).Login();
            if (SelectedPatient == null)
            {
                Close();
            }
            else
            {
                LoadProcedures();
                LoadDoctorAppointments();
                LoadDrugRunningOut();
            }
        }

        private void оПриложенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new AboutBox1()).ShowDialog();
        }

        private void выбратьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void переченьПроцедурToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgf = new DataGridForm("Все процедуры поликлиники");
            dgf.DataGridView.ColumnCount = 2;
            dgf.DataGridView.Columns[0].Name = "Название процедуры";
            dgf.DataGridView.Columns[1].Name = "Описание процедуры";

            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from [Procedures directory]", connection);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dgf.DataGridView.Rows.Add(new object[]
                        {(string) dr["Name"], dr["Note"].GetType() is DBNull ? (string?) dr["Note"] : null});
                }
            }

            dgf.ShowDialog();
        }

        private void переченьЛекарсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgf = new DataGridForm("Все лекарства выписываемые поликлиникой");
            dgf.DataGridView.ColumnCount = 3;
            dgf.DataGridView.Columns[0].Name = "Название лекарства";
            dgf.DataGridView.Columns[1].Name = "Описание";
            dgf.DataGridView.Columns[2].Name = "Срок годности";

            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from [Drug directory]", connection);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int month = (int)dr["Expiration date"];
                    int year = month / 12; 
                    month %= 12;
                    string s = "";
                    if (year != 0)
                        if (year <= 20)
                            if (year == 1)
                                s += year.ToString() + " год ";
                            else if (year >= 2 & year < 5)
                                s += year.ToString() + " года ";
                            else
                                s += year.ToString() + " лет ";
                        else
                            if (year % 10 == 1)
                                s += year.ToString() + " год ";
                            else if (year % 10 >= 2 && year % 10 < 5)
                                s += year.ToString() + " года ";
                            else
                                s += year.ToString() + " лет ";
                    if (month != 0)
                        if (month == 1)
                            s += month.ToString() + " месяц";
                        else if (month >= 2 & month < 5)
                            s += month.ToString() + " месяца";
                        else
                            s += month.ToString() + " месяцев";
                    dgf.DataGridView.Rows.Add(new object[]
                        {(string) dr["Name"], dr["Note"].GetType() is DBNull ? (string?) dr["Note"] : null, s});
                }
            }
            dgf.ShowDialog();
        }

        private void переченьДокторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgf = new DataGridForm("Все доктора поликлиники");
            dgf.DataGridView.ColumnCount = 3;
            dgf.DataGridView.Columns[0].Name = "ФИО";
            dgf.DataGridView.Columns[1].Name = "e-mail";
            dgf.DataGridView.Columns[2].Name = "Дополнительная информация";

            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from Doctors", connection);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string Surname = (string) dr["Surname"];
                    string Name = (string) dr["Name"];
                    string? MiddleName = dr["Middle name"].GetType() is DBNull ? (string?)dr["Middle name"] : null;
                    string s = Surname + "  " + Name;
                    if (MiddleName != null)
                        s += " " + MiddleName;
                    dgf.DataGridView.Rows.Add(new object[]
                        {s, (string) dr["e-mail"], dr["Note"].GetType() is DBNull ? (string?) dr["Note"] : ""});
                }
            }
            dgf.ShowDialog();
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
