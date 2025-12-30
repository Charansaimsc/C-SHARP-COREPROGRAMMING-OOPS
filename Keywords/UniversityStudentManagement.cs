using System;

public class Student
{
	public static string UniversityName = "GLA UNIV";
	public string StudentName { get; set; }
	public  static int totalStudents = 0;
	public static void DisplayTotalStudents()
	{
		Console.WriteLine("Total Students: " + totalStudents);
	}


    //public string Name;
    public readonly int roll;
	public char Grade;
	public Student(string Name, int roll, char Grade)
	{
		this.StudentName = Name;
		this.roll = roll;
		this.Grade = Grade;
		totalStudents++;
	}
	public void Display() {
		Console.WriteLine("StudentName : " + StudentName + "\nUniversityName : " + UniversityName + "\nroll : " + roll + "\nGrade ; " + Grade + "        \n" + totalStudents);
	}
}