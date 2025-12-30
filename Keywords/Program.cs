using System;
namespace keywords
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BankAccount acc1 = new BankAccount("Charan", 101, 50000);
            //BankAccount acc2 = new BankAccount("Sai", 102, 75000);


            //if (acc1 is BankAccount)
            //{
            //    acc1.DisplayDetails();
            //}

            //if (acc2 is BankAccount)
            //{
            //    acc2.DisplayDetails();
            //}

            //BankAccount.GetTotalAccounts();


            //Vehicle v1 = new Vehicle("Charan", "2-wheeler", 7129);
            //Vehicle v2 = new Vehicle("sai", "4-wheeler", 7129);

            //if(v1 is Vehicle)
            //{
            //    Vehicle.UpdateRegisytrationFee(100);
            //    v1.Display();

            //}



            Student s1 = new Student("sai", 10, 'c');
            Student s2 = new Student("sai", 10, 'c');
            if(s1 is Student)
            {
                s1.Display();
                Student.DisplayTotalStudents();
            }
        }
    }
}