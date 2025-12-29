using System;
namespace Level_1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book obj = new Book();
            obj.Display();
            Book obj2 = new Book("alice", "asdf", 199);
            obj2.Display();
        }
    }
}