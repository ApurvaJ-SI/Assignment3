using System.Security.Cryptography;

namespace InventorySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //child class electronics
            Console.WriteLine("Electronics:");
            Electronics e1 = new Electronics("Dell","Camera",101, "Laptop", 40000, 10);
            Electronics e2 = new Electronics("Samsung","Camera", 102, "Phone", 20000, 5 );
            Electronics e3 = new Electronics("Philips", "Ultra wide", 103, "TV", 30000, 7);

            e1.DisplayProductDetails();
            e2.DisplayProductDetails();
            e3.DisplayProductDetails();

            Console.WriteLine("Clothing:");
            //child class clothes
            Clothing c1 = new Clothing(30,"Western",201, "One piece",2000,5);
            Clothing c2 = new Clothing(28, "Western", 202, "Jeans", 1000, 10);
            Clothing c3 = new Clothing(32, "Traditional", 203, "Kurta", 5000, 15);

            c1.DisplayProductDetails();
            c2.DisplayProductDetails();
            c3.DisplayProductDetails();


            Console.WriteLine("Books:");
            //child class books
            Books b1 = new Books("J.K Rowling", "Fantasy", 301, "Harry Potter", 500, 6);
            Books b2 = new Books("Colleen Hoover","Romance",302, "It Ends With Us",600, 10);
            Books b3 = new Books("Hector Garsia","Self help book", 303, "Ikigai", 400, 4);

            b1.DisplayProductDetails();
            b2.DisplayProductDetails();
            b3.DisplayProductDetails();

            Console.ReadKey();
        }
    }
}


            