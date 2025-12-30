
/*Create a Patient class with the following features:
● static:
o A static variable HospitalName shared among all patients.
o A static method GetTotalPatients() to count the total patients admitted.
● this:
o Use this to initialize Name, Age, and Ailment in the constructor.
● readonly:
o Use a readonly variable PatientID to uniquely identify each patient.
● is operator:
o Check if an object is an instance of the Patient class before displaying its
details.*/

using System;

public class Patient
{
    
    public static string HospitalName = "City Care Hospital";
    private static int totalPatients = 0;

    public static void GetTotalPatients()
    {
        Console.WriteLine("Total Patients Admitted: " + totalPatients);
    }

    public string Name;
    public int Age;
    public string Ailment;

 
    public readonly int PatientID;

  
    public Patient(string name, int age, string ailment, int patientId)
    {
        this.Name = name;
        this.Age = age;
        this.Ailment = ailment;
        this.PatientID = patientId;

        totalPatients++;
    }

 
    public void DisplayDetails()
    {
        Console.WriteLine(
            "Hospital Name : " + HospitalName +
            "\nPatient ID : " + PatientID +
            "\nName : " + Name +
            "\nAge : " + Age +
            "\nAilment : " + Ailment
        );
    }
}


