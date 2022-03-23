namespace NewPatientApp;

public class DataBaseConnection
{
    public static string ConnectionString = @"Data Source=localhost,1433; Initial Catalog=Course_backup; User ID=SA; Password=Asdfghj1;TrustServerCertificate=true";
}
public class PatientProcedure
{
    public int ID;
    public Patient Patient;
    public int PatientID;
    public DateTime DateTime;
    public int ProcedureID;
    public string ProcedureName;
    public string? ProcedureNote;
    public string? Note;
    public bool Visited;
}

public class DoctorAppointment
{
    public int ID;
    public double? PatientTemperature;
    public DateTime DateTime;
    public string? WordFile;
    public string? Note;
    public bool Visited;
    public Patient Patient;
    public int PatientID;
    public int DoctorID;
    public string DoctorName;
    public string DoctorSurname;
    public string? DoctorMiddleName;
    public string? DoctorNote;
    public DateTime DoctorBirthdate;
    public string DoctorEMail;
    public string? DoctorOtherInformation;
}

public class Patient
{
    public int ID;
    public string Name;
    public string Surname;
    public string? MiddleName;
    public string? Note;
    public DateTime Birthdate;
    public string EMail;
    public string? OtherInformation;
    public static explicit operator int (Patient p)
    {
        return p.ID;
    }

    public override string ToString()
    {
        string s = ID.ToString() + ", " + Surname.ToString() + "  " + Name.ToString();
        if (MiddleName != null)
            s += " " + MiddleName;
        return s;
    }
}
public class Doctor
{
    public int ID;
    public string Name;
    public string Surname;
    public string? MiddleName;
    public string? Note;
    public DateTime Birthdate;
    public string EMail;
    public string? OtherInformation;
    public static explicit operator int (Doctor p)
    {
        return p.ID;
    }

    public override string ToString()
    {
        string s = ID.ToString() + ", " + Surname + "  " + Name;
        if (MiddleName != null)
            s += " " + MiddleName;
        return s;
    }
}

public class PatientDrug
{
    public int ID;
    public DateTime DateOfManufacture;
    public int Remaining;
    public string Name;
}

public class PrescribedMedication
{
    public enum Meals
    {
        TakeBeforeMeals,
        TakeAfterMeals,
        TakeWithMeals
    }
    public int DoctorAppointmentID;
    public DoctorAppointment DoctorAppointment;
    public int ID;
    public bool ReceptionTimeDuringTheDay;
    public bool ReceptionTimeInTheEvening;
    public bool ReceptionTimeInTheMorning;
    public string? Note;
    public string DrugName;
    public string? DrugNote;
    public int DrugID;
    public Meals TakeMeals;
}

