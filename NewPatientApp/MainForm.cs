using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace NewPatientApp
{
    public partial class MainForm : Form
    {
        public static Patient? SelectedPatient;
        public static List<PatientProcedure> PatientProceduresList = new List<PatientProcedure>();
        public static List<DoctorAppointment> DoctorAppointmentsList = new List<DoctorAppointment>();
        public static List<PatientDrug> DrugRunningOut = new List<PatientDrug>();
        public static List<PatientDrug> PatientDrugs = new List<PatientDrug>();
        public static List<PrescribedMedication> PrescribedMedications = new();
        public static List<Drug> Drugs = new List<Drug>();

        public void LoadDrugs()
        {
            using (var connection = new SqlConnection(DataBaseConnection.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(@"Select * from [Drug directory]", connection);
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var o = new Drug()
                    {
                        ID = (int) dr["ID"],
                        Name = (string) dr["Name"],
                        Note = (string) dr["Note"] is DBNull ? null : (string?) dr["Note"],
                        ExpirationDate = (int) dr["Expiration date"]
                    };
                    Drugs.Add(o);
                }
            }
        }

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
                        ProcedureNote = dr["ProcedureNote"] is DBNull? null : (string?)dr["ProcedureNote"] ,
                        Note = dr["Note"] is DBNull ? null : (string?)dr["Note"],
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
                        PatientTemperature = dr["PatientTemperature"] is DBNull? null : (double?) dr["PatientTemperature"] ,
                        WordFile = dr["WordFile"] is DBNull ? null : (string?)dr["WordFile"],
                        Note = dr["Note"] is DBNull ? null : (string?)dr["Note"] ,
                        Visited = (bool)dr["Visited"],
                        DoctorID = (int) dr["DoctorID"],
                        DoctorName = (string) dr["DoctorName"],
                        DoctorSurname = (string)dr["DoctorSurname"],
                        DoctorMiddleName = dr["DoctorMiddleName"] is DBNull ? null : (string?)dr["DoctorMiddleName"],
                        DoctorNote = dr["DoctorNote"] is DBNull ? null : (string?)dr["DoctorNote"],
                        DoctorBirthdate = (DateTime) dr["DoctorBirthdate"],
                        DoctorEMail = (string)dr["DoctorEMail"],
                        DoctorOtherInformation = dr["DoctorOtherInformation"] is DBNull ? null : (string?)dr["DoctorOtherInformation"],
                        Patient = SelectedPatient,
                        PatientID = SelectedPatient.ID
                    });
                }
            }
            DoctorAppointmentsList.Sort((a, b) => 
                (a.DateTime.Ticks - b.DateTime.Ticks) < 0 ? -1 : (a.DateTime.Ticks - b.DateTime.Ticks) > 0 ? 1 : 0);
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
	                            pd.Remaining as Remaining
                            from 
	                            (Select * from [Patient's drugs]
	                            where [Patient ID] = @SelectedPatient) as pd", connection);
                cmd.Parameters.AddWithValue("@SelectedPatient", (int)SelectedPatient);
                Dictionary<int, (PatientDrug p, bool r, bool d)> dic = new();
                var dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    var o = new PatientDrug()
                    {
                        ID = (int) dr["pdID"],
                        Drug = Drugs.Single(b => b.ID == (int)dr["DrugID"]),
                        DateOfManufacture = (DateTime) dr["DateOfManufacture"],
                        Remaining = (int) dr["Remaining"]
                    };
                    PatientDrugs.Add(o);
                }
                dr.Close();

                foreach (PatientDrug patientDrug in PatientDrugs)
                {
                    var prescribedMedications = PrescribedMedications.Where(b => b.DrugID == patientDrug.Drug.ID);
                    if (prescribedMedications.Count() != 0)
                        foreach (var prescribedMedication in prescribedMedications)
                            if (prescribedMedication.LeftTakeMedicine > patientDrug.Remaining)
                                dic.Add(patientDrug.Drug.ID, (patientDrug, true, false));
                }
                cmd = new SqlCommand(
                    @"Select 
	                            pd.ID as pdID, pd.[Date of manufacture] as DateOfManufacture, 
	                            pd.Remaining as Remaining, dd.[Drug Name] as Name, dd.ID as DrugID
                            from 
	                            (Select * from [Patient's drugs]
	                            where [Patient ID] = @SelectedPatient and Remaining > 0) as pd
                            left join 
	                            [Drug directory] as dd
                            on pd.[Drug ID] = dd.ID
                            where DATEDIFF(MM, 
	                            DATEADD(dd, dd.[Expiration date], pd.[Date of manufacture]), 
	                            GETDATE()) > -1
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
                        Drug = Drugs.Single(b => b.ID == (int)dr["DrugID"]),
                        DateOfManufacture = (DateTime)dr["DateOfManufacture"],
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
                        row.Cells[0].Value = keyValuePair.Value.p.Drug.Name;
                        row.Cells[1].Value = "Осталось " + keyValuePair.Value.p.Remaining + " доз и истекает срок годности";
                        dataGridViewDrugRunningOut.Rows.Add(row);
                    }
                    else if (keyValuePair.Value.r)
                    {
                        var row = new DataGridViewRow();
                        row.Cells[0].Value = keyValuePair.Value.p.Drug.Name;
                        row.Cells[1].Value = "Осталось " + keyValuePair.Value.p.Remaining + " доз";
                        dataGridViewDrugRunningOut.Rows.Add(row);
                    }
                    else
                    {
                        var row = new DataGridViewRow();
                        row.Cells[0].Value = keyValuePair.Value.p.Drug.Name;
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
                                TakeMedicineBeforeDate
                            from 
	                            (Select * from [Doctor's appointments]
	                            where [Patient ID] = @SelectedPatient) as da
                            left join 
	                            (Select 
		                            [ID Doctor's appointments], PrescribedMedicationsID,
		                            [Reception time during the day], [Reception time in the evening],
		                            [Reception time in the morning], [Take before meals], [Take after meals],
		                            [Take with meals], PrescribedMedicationsNote, [Drug Name] as DrugName, 
		                            TakeMedicineBeforeDate, Note as DrugNote, ID as DrugID
	                            from 
		                            (Select 
			                            [Drug ID], [ID Doctor's appointments], ID as PrescribedMedicationsID,
			                            [Reception time during the day], [Reception time in the evening],
			                            [Reception time in the morning], [Take before meals], [Take after meals],
			                            [Take with meals], [Take medicine before the date] as TakeMedicineBeforeDate, 
                                        Note as PrescribedMedicationsNote
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
                    var o = new PrescribedMedication()
                    {
                        DoctorAppointment = DoctorAppointmentsList.Single(b => b.ID == (int)dr["ID Doctor's appointments"]),
                        DoctorAppointmentID = (int)dr["ID Doctor's appointments"],
                        DrugID = (int)dr["DrugID"],
                        DrugName = (string)dr["DrugName"],
                        DrugNote = dr["DrugNote"] is DBNull ? null : (string?)dr["DrugNote"],
                        ID = (int)dr["PrescribedMedicationsID"],
                        Note = dr["Note"] is DBNull ? null : (string?)dr["Note"] ,
                        ReceptionTimeDuringTheDay = (bool)dr["Reception time during the day"],
                        ReceptionTimeInTheEvening = (bool)dr["Reception time in the evening"],
                        ReceptionTimeInTheMorning = (bool)dr["Reception time in the morning"],
                        TakeMeals = m,
                        TakeMedicineBeforeDate = (DateTime)dr["TakeMedicineBeforeDate"],
                        LeftTakeMedicine = 0
                    };
                    int x = o.ReceptionTimeDuringTheDay ? 1 : 0;
                    x += o.ReceptionTimeInTheEvening ? 1 : 0;
                    x += o.ReceptionTimeInTheMorning ? 1 : 0;
                    o.LeftTakeMedicine = -DateTime.Now.Subtract(o.TakeMedicineBeforeDate).Days * x;
                    PrescribedMedications.Add(o);
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
                LoadDrugs();
                LoadProcedures();
                LoadDoctorAppointments(); 
                LoadPrescribedMedications();
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
                        {(string) dr["Name"], dr["Note"] is DBNull ? "" : (string) dr["Note"]});
                }
            }
            dgf.ShowDialog();
        }

        private void переченьЛекарсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgf = new DataGridForm("Лекарства в наличии");
            dgf.DataGridView.ColumnCount = 3;
            dgf.DataGridView.Columns[0].Name = "Название лекарства";
            dgf.DataGridView.Columns[1].Name = "Описание";
            dgf.DataGridView.Columns[2].Name = "Срок годности";

            foreach (var o in Drugs)
            {
                dgf.DataGridView.Rows.Add(new object[]
                    {o.Name, o.Note ?? "", o.ExpirationDateToString()});
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
                    string? MiddleName = dr["Middle name"]is DBNull ? null : (string?)dr["Middle name"];
                    string s = Surname + "  " + Name;
                    if (MiddleName != null)
                        s += " " + MiddleName;
                    dgf.DataGridView.Rows.Add(new object[]
                        {s, (string) dr["e-mail"], dr["Note"] is DBNull ? "" : (string) dr["Note"]});
                }
            }
            dgf.ShowDialog();
        }

        private void buttonAddPatientDrag_Click(object sender, EventArgs e)
        {
            new AddPatientDragForm().ShowDialog();
        }

        private void buttonPatientDragList_Click(object sender, EventArgs e)
        {
            var dgf = new DataGridForm("Все лекарства выписываемые поликлиникой");
            dgf.DataGridView.ColumnCount = 4;
            dgf.DataGridView.Columns[0].Name = "Название лекарства";
            dgf.DataGridView.Columns[1].Name = "Описание";
            dgf.DataGridView.Columns[2].Name = "Осталось доз";
            dgf.DataGridView.Columns[3].Name = "Дата производства лекарства";

            foreach (var patientDrug in PatientDrugs)
            {
                dgf.DataGridView.Rows.Add(new object[]
                {
                    patientDrug.Drug.Name,
                    patientDrug.Drug.Name ?? "",
                    patientDrug.Remaining,
                    patientDrug.DateOfManufacture.ToString("d MMM yyyy")
                });
            }
            dgf.ShowDialog();
        }

        private void buttonAddWellBeing_Click(object sender, EventArgs e)
        {
            new AddWellBeingForm().ShowDialog();
        }

        private void buttonMarkMedicineTaken_Click(object sender, EventArgs e)
        {
            new MarkMedicineTakenForm().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void полныйСписокПроцедурПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dgf = new DataGridForm("Все записи процедур");
            dgf.DataGridView.ColumnCount = 5;
            dgf.DataGridView.Columns[0].Name = "Посещено";
            dgf.DataGridView.Columns[1].Name = "Название процедуры";
            dgf.DataGridView.Columns[2].Name = "Дата и время записи";
            dgf.DataGridView.Columns[3].Name = "Заметка";
            foreach (PatientProcedure patientProcedure in PatientProceduresList)
            {
                dgf.DataGridView.Rows.Add(new object[]
                {
                    patientProcedure.Visited ? "✔" : "",
                    patientProcedure.ProcedureName,
                    patientProcedure.DateTime.ToString("d MMM yyyy HH:mm"),
                    patientProcedure.Note ?? "",
                });
            }

            dgf.ShowDialog();

        }

        private void полныйСписокЗаписейКоВрачуПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                // TODO
            }
            var dgf = new DataGridForm("Записи ко врачу");
            dgf.DataGridView.ColumnCount = 5;
            dgf.DataGridView.Columns[0].Name = "Посещено";
            dgf.DataGridView.Columns[1].Name = "ФИО доктора";
            dgf.DataGridView.Columns[2].Name = "Дата и время записи";
            dgf.DataGridView.Columns[3].Name = "Заметка";
            dgf.DataGridView.Columns[4].Name = "Температура пациента";
            dgf.DataGridView.Columns.Add(new DataGridViewButtonColumn());
            dgf.DataGridView.Columns[5].Name = "Cкачать Word файл";
            dgf.DataGridView.CellClick +=
                new DataGridViewCellEventHandler(dataGridView_CellClick);
            foreach (DoctorAppointment doctorAppointment in DoctorAppointmentsList)
            {
                dgf.DataGridView.Rows.Add(new object[]
                {
                    doctorAppointment.Visited ? "✔" : "", 
                    doctorAppointment.DoctorMiddleName == null ?
                        doctorAppointment.DoctorSurname + " " + doctorAppointment.DoctorName :
                        doctorAppointment.DoctorSurname + " " + doctorAppointment.DoctorName + doctorAppointment.DoctorMiddleName,
                    doctorAppointment.DateTime.ToString("d MMM yyyy HH:mm"),
                    doctorAppointment.Note ?? "",
                    doctorAppointment.PatientTemperature.ToString() ?? "",
                    "Cкачать Word файл"
                });
            }

            dgf.ShowDialog();

        }
    }
}
