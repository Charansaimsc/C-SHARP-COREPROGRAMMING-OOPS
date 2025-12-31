/*Description: Model a School with multiple Student objects, where each student can enroll in
multiple courses, and each course can have multiple students.
Tasks:
● Define School, Student, and Course classes.
● Model an association between Student and Course to show that students can enroll
in multiple courses.
● Model an aggregation relationship between School and Student.
● Demonstrate how a student can view the courses they are enrolled in and how a
course can show its enrolled students.
Goal: Practice association by modeling many-to-many relationships between students and
courses.*/



using System;
using System.Collections.Generic;

public class Course
{
    public string CourseName { get; set; }
    public List<Student> Students { get; set; }

    public Course(string courseName)
    {
        CourseName = courseName;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        if (!Students.Contains(student))
        {
            Students.Add(student);
        }
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Students enrolled in {CourseName}:");
        foreach (var student in Students)
        {
            Console.WriteLine($"Student ID: {student.StudentId}");
        }
    }
}
public class Student
{
    public int StudentId { get; set; }
    public List<Course> Courses { get; set; }

    public Student(int studentId)
    {
        StudentId = studentId;
        Courses = new List<Course>();
    }

    public void EnrollCourse(Course course)
    {
        if (!Courses.Contains(course))
        {
            Courses.Add(course);
            course.AddStudent(this); 
        }
    }

    public void ShowCourses()
    {
        Console.WriteLine($"Courses enrolled by Student {StudentId}:");
        foreach (var course in Courses)
        {
            Console.WriteLine(course.CourseName);
        }
    }
}
public class School
{
    public string SchoolName { get; set; }
    public List<Student> Students { get; set; }

    public School(string schoolName)
    {
        SchoolName = schoolName;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Students in {SchoolName}:");
        foreach (var student in Students)
        {
            Console.WriteLine($"Student ID: {student.StudentId}");
        }
    }
}

