using System;
namespace inheritance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal A = new Dog("max",2);
            A.MakeSound();
            Animal B = new Cat("maxi",3);
            B.MakeSound();
        }
    }
}