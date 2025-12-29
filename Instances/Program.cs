using System;

namespace instances
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Product p1 = new Product("salt", 1000);

            //Product p2 = new Product("sugar", 12200);

            //p1.DisplayProductDetails();
            //Product.DisplayTotalStudents();


            //Course course1 = new Course("C# Programming", 3, 15000);
            //Course course2 = new Course("Machine Learning", 6, 35000);

            //// Display course details
            //course1.DisplayCourseDetails();
            //course2.DisplayCourseDetails();

            //// Update institute name for all courses
            //Course.UpdateInstituteName("Tech Minds Academy");

            //Console.WriteLine("After Updating Institute Name:\n");

            //// Display details again
            //course1.DisplayCourseDetails();
            //course2.DisplayCourseDetails();


            Vehicle v1 = new Vehicle("sai", "car");
            Vehicle v2 = new Vehicle("charan", "bike");
            v1.DisplayVehicleInfo();
            Vehicle.UpdateFee(200);
        }
    }
}