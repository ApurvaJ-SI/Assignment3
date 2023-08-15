using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem
{
    internal class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public virtual void DisplayProductDetails()
        {
            Console.WriteLine($"Id: {Id} \t Name: {Name} \t Price: {Price}, Quantity: {Quantity}");
        }

        public Product() { }
        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }

    //child class

    class Electronics : Product
    {
        public Electronics() { Console.WriteLine(); }

        public Electronics(string brand,string feature, int id, string name, double price, int quantity):base(id, name, price,quantity)
        {
            //Console.WriteLine("From Parent Product");
            Brand = brand;
            Feature = feature;
        }

        public string Brand { get; set; }

        public string Feature { get; set; }

        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Brand: {Brand} \t Feature: {Feature}");
        }
    }

    class Clothing : Product
    { 
        public Clothing() { Console.WriteLine(); }

        public Clothing(int size,string style, int id,string name, double price, int quantity):base(id, name, price, quantity)
        {
            //Console.WriteLine("From Parent Product");
            Size = size;
            Style = style;
        }

        public int Size { get; set; }

        public string Style { get; set; }

        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Size: {Size} \t Style: {Style}");
        }
    }

    class Books : Product
    {
        public Books() { Console.WriteLine(); }

        public Books(string author, string genre, int id, string name, double price, int quantity) : base(id, name, price, quantity)
        {
            //Console.WriteLine("From Parent Product");
            Author = author;
            Genre = genre;
        }

        public string Author { get; set; }

        public string Genre { get; set; }

        public override void DisplayProductDetails()
        {
            base.DisplayProductDetails();
            Console.WriteLine($"Author: {Author} \t Genre: {Genre}");
        }
    }
}
