/*Online Course Management
● Design a Course class with:
o Instance Variables: courseName, duration, fee.
o Class Variable: instituteName (common for all courses).
● Implement the following methods:
o An instance method DisplayCourseDetails() to display course details.
o A class method UpdateInstituteName() to modify the institute name for all
courses.*/


using System;

class Course
{
    // Instance Variables
    string courseName;
    int duration;     // in months
    double fee;

    // Class Variable (shared by all courses)
    static string instituteName = "ABC Institute";

    // Parameterized Constructor
    public Course(string courseName, int duration, double fee)
    {
        this.courseName = courseName;
        this.duration = duration;
        this.fee = fee;
    }

    // Instance Method
    public void DisplayCourseDetails()
    {
        Console.WriteLine("Institute Name : " + instituteName);
        Console.WriteLine("Course Name    : " + courseName);
        Console.WriteLine("Duration       : " + duration + " months");
        Console.WriteLine("Fee            : " + fee);
        Console.WriteLine();
    }

    // Class Method (Static Method)
    public static void UpdateInstituteName(string newInstituteName)
    {
        instituteName = newInstituteName;
    }
}

