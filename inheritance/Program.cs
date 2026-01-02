using System;
namespace inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Animal A = new Dog("max",2);
            //A.MakeSound();
            //Animal B = new Cat("maxi",3);
            //B.MakeSound();

            //Employee e1 = new Intern("Sai", 122, 100.99, "c#");
            //e1.DisplayDetails();
            //Employee e2 = new Manager(100,"charan", 101, 1000.99);
            //e2 .DisplayDetails();
            //    Vehicle[] vehicles =
            //           {
            //    new Car(5, 180, "Petrol"),
            //    new Truck(2000, 120, "Diesel"),
            //    new Motorcycle(true, 150, "Petrol")
            //};

            //    foreach (Vehicle v in vehicles)
            //    {
            //        v.DisplayInfo();
            //        Console.WriteLine();


            //      Book book = new Author(
            //    "c#principles",
            //    2004,
            //    "Charan",
            //    "agile"
            //);

            //      book.DisplayInfo();


            //Device device = new Device(101, "ON");
            //device.DisplayStatus();

            //Device thermostat = new Thermostat(201, "ACTIVE", 24);
            //thermostat.DisplayStatus();


            //Order order1 = new Order("ORD101", "01-Jan-2026");
            //order1.DisplayOrderStatus();
            //Order order2 = new ShippedOrder("ORD102", "02-Jan-2026", 456789);
            //order2.DisplayOrderStatus();
            //Order order3 = new DeliveredOrder("ORD103", "03-Jan-2026", 987654, "05-Jan-2026");
            //order3.DisplayOrderStatus();


            //Course c1 = new Course("C# Basics", 20);
            //c1.DisplayDetails();
            //Course c2 = new OnlineCourse("OOP with C#", 30, "Udemy", true);
            //c2.DisplayDetails();
            //Course c3 = new PaidOnlineCourse("Advanced C#", 40, "Coursera", true, 5000, 20);
            //c3.DisplayDetails();



            //BankAccount acc1 = new SavingsAccount("SB101", 50000, 4.5);
            //acc1.DisplayAccountType();
            //acc1.DisplayDetails();
            //BankAccount acc2 = new CheckingAccount("CA201", 30000, 10000);
            //acc2.DisplayAccountType();
            //acc2.DisplayDetails();
            //BankAccount acc3 = new FixedDepositAccount("FD301", 100000, 24);
            //acc3.DisplayAccountType();
            //acc3.DisplayDetails();


            Person p1 = new Teacher("Mr. Kumar", 40, "Mathematics");
            p1.DisplayRole();
            p1.DisplayDetails();
            Person p2 = new Student("Anita", 16, "10th Grade");
            p2.DisplayRole();
            p2.DisplayDetails();
            Person p3 = new Staff("Ramesh", 45, "Administration");
            p3.DisplayRole();
            p3.DisplayDetails();



        }


    }
    
}