namespace EmployeeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Managers:");
            Manager m1 = new Manager("Apurva",102,50000,15,4);
            Manager m2 = new Manager("Riya", 104, 47000, 13.2, 3);

            Console.WriteLine(m1.ToString());
            Console.WriteLine(m2.ToString());

            Console.WriteLine("Developers:");
            Developer d1 = new Developer("Dipti",203,40000,12.5, 2);
            Developer d2 = new Developer("Srushti", 206, 39000, 12.3, 3);

            Console.WriteLine(d1.ToString());
            Console.WriteLine(d2.ToString());

            Console.WriteLine("SalesPersons:");
            SalesPerson s1 = new SalesPerson("Aayansh", 304, 35000,10.7,8);
            SalesPerson s2 = new SalesPerson("Siddhi", 307, 34000, 10.3, 6);

            Console.WriteLine(s1.ToString());
            Console.WriteLine(s2.ToString());
        }
    }
}