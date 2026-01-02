using System;

public class Course
{
    public string CourseName { get; }
    public int Duration { get; } 

    public Course(string courseName, int duration)
    {
        CourseName = courseName;
        Duration = duration;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Course Name : {CourseName}");
        Console.WriteLine($"Duration    : {Duration} hours");
    }
}
public class OnlineCourse : Course
{
    public string Platform { get; }
    public bool IsRecorded { get; }

    public OnlineCourse(string courseName, int duration, string platform, bool isRecorded)
        : base(courseName, duration)
    {
        Platform = platform;
        IsRecorded = isRecorded;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Platform    : {Platform}");
        Console.WriteLine($"Recorded    : {(IsRecorded ? "Yes" : "No")}");
    }
}
public class PaidOnlineCourse : OnlineCourse
{
    public double Fee { get; }
    public double Discount { get; } // percentage

    public PaidOnlineCourse(string courseName, int duration, string platform, bool isRecorded, double fee, double discount) : base(courseName, duration, platform, isRecorded)
    { 
        Fee = fee;
        Discount = discount;
    }

    public double GetFinalPrice()
    {
        return Fee - (Fee * Discount / 100);
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Fee         : ₹{Fee}");
        Console.WriteLine($"Discount    : {Discount}%");
        Console.WriteLine($"Final Price : ₹{GetFinalPrice()}");
    }
}
