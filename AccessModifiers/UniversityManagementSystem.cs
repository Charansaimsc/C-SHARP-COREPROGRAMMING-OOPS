/*Create a Student class with:
o rollNumber (public)
o name (protected)
o CGPA (private)

● Implement methods to:
o Access and modify CGPA using public methods.
o Create a subclass PostgraduateStudent to demonstrate the use of protected
members.*/




using System;

// Base Class
class Student
{
    // Public variable
    public int rollNumber;

    // Protected variable
    protected string name;

    // Private variable
    private double CGPA;

    // Constructor
    public Student(int rollNumber, string name, double cgpa)
    {
        this.rollNumber = rollNumber;
        this.name = name;
        this.CGPA = cgpa;
    }

    // Public method to get CGPA
    public double GetCGPA()
    {
        return CGPA;
    }

    // Public method to set CGPA
    public void SetCGPA(double cgpa)
    {
        if (cgpa >= 0 && cgpa <= 10)
        {
            CGPA = cgpa;
        }
        else
        {
            Console.WriteLine("Invalid CGPA value.");
        }
    }

    // Method to display basic student details
    public void DisplayStudent()
    {
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("CGPA        : " + CGPA);
    }
}

// Derived Class
class PostgraduateStudent : Student
{
    public string specialization;

    // Constructor
    public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
        : base(rollNumber, name, cgpa)
    {
        this.specialization = specialization;
    }

    // Method demonstrating access to protected member
    public void DisplayPostgraduateDetails()
    {
        Console.WriteLine("Roll Number     : " + rollNumber);  // public
        Console.WriteLine("Name            : " + name);        // protected
        Console.WriteLine("Specialization  : " + specialization);
        Console.WriteLine("CGPA            : " + GetCGPA());   // accessed via public method
    }
}

