namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            Console.WriteLine("Enter name of the student:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter number of grades to be entered:");
            int numberofgrades = Convert.ToInt32(Console.ReadLine());

            s.Name = name;

            s.Grades = new int[numberofgrades];
            for(int i=0;i<numberofgrades; i++)
            {
                Console.WriteLine($"Enter grade:{i+1}");
                try
                {
                    int v = Convert.ToInt32(Console.ReadLine());
                    if (v<0 || v > 100)
                    {
                        throw new Exception();
                    }
                    s.Grades[i] = v;
                }
                catch
                {
                    Console.WriteLine("Invalid Input !! ");
                    i--;
                }
            }
            Console.WriteLine(s.AverageGrade());
        }
    }
}