namespace ShapeHierarchy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            static void DisplayMenu()
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Area and Perimeter of Circle:");
                Console.WriteLine("2. Area and Perimeter of Traingle:");
                Console.WriteLine("3. Area and Perimeter of Reactangle:");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice:");
            }

            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            Rectangle rectangle = new Rectangle();

            int choice;
            do
            {DisplayMenu();

                choice = int.Parse(Console.ReadLine());
                

                switch (choice)
                {
                    case 1:
                        circle.CalculateArea();
                        circle.CalculatePerimeter();
                        break;
                    case 2:
                        triangle.CalculateArea();
                        triangle.CalculatePerimeter();
                        break;
                    case 3:
                        rectangle.CalculateArea();
                        rectangle.CalculatePerimeter();
                        break;
                    case 4:
                        Console.WriteLine("Thank you!!");
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                        
                }
                Console.WriteLine("Press y to Continue");
                char a = char.Parse(Console.ReadLine());
                if(a.Equals("y") || a.Equals("Y"))
                {
                    DisplayMenu();

                }

            } while (choice != 4);


        }
    }
}