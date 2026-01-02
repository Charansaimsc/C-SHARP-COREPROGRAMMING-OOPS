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

            Employee e1 = new Intern("Sai", 122, 100.99, "c#");
            e1.DisplayDetails();
            Employee e2 = new Manager(100,"charan", 101, 1000.99);
            e2 .DisplayDetails();
        }
    }
}