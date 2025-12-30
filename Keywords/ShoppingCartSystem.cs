/*Create a Product class to manage shopping cart items with the following features:
● static:
o A static variable Discount shared by all products.

o A static method UpdateDiscount() to modify the discount percentage.
● this:
o Use this to initialize ProductName, Price, and Quantity in the constructor.
● readonly:
o Use a readonly variable ProductID to ensure each product has a unique
identifier that cannot be changed.

● is operator:
o Validate whether an object is an instance of the Product class before
processing its details.*/


using System;

class Product
{
    public static double Discount = 0;  

    public readonly int ProductID;
    public string ProductName;
    public double Price;
    public int Quantity;

   private static int idCounter = 1000;

    public Product(string productName, double price, int quantity)
    {
        this.ProductName = productName;
        this.Price = price;
        this.Quantity = quantity;

        ProductID = ++idCounter; 
    }

    public static void UpdateDiscount(double newDiscount)
    {
        Discount = newDiscount;
    }

    public double GetFinalPrice()
    {
        double total = Price * Quantity;
        return total - (total * Discount / 100);
    }

    public static void DisplayProductDetails(object obj)
    {
        if (obj is Product p)
        {
            Console.WriteLine("Product ID   : " + p.ProductID);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Price        : " + p.Price);
            Console.WriteLine("Quantity     : " + p.Quantity);
            Console.WriteLine("Discount     : " + Discount + "%");
            Console.WriteLine("Final Price  : " + p.GetFinalPrice());
        }
        else
        {
            Console.WriteLine("Invalid object. Not a Product.");
        }
    }
}


