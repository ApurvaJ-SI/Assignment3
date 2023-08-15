using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeHierarchy
{
    abstract internal class Employee
    {
        public string Name { get; set; }

        public int EmpId { get; set; }

        public double Salary { get; set; }

        public double Bonus { get; set; }

        string name;
        int empId;
        double salary;
        double bonus;

        public Employee(string name, int empId, double salary, double bonus)
        {
            Name = name;
            EmpId = empId;
            Salary = salary;
            Bonus = bonus;
        }
        
        public override string ToString()
        {
            return $"Name = {Name}   EmpId = {EmpId}    Salary = {Salary}    Bonus = {Bonus}";
        }

        abstract public double CalculateBonus();
        
    }

    class Manager : Employee
    {
        public Manager(string name, int empid, double salary, double bonus, int projects) : base(name, empid, salary, bonus)
        {
            NoOfProjects = projects;
        }
        public int NoOfProjects { get; set; }
        public override double CalculateBonus()
        {
            return ((Bonus / 100) * Salary) + 9000;
        }
    }

    class Developer : Employee
    {
        public Developer(string name, int empid, double salary, double bonus, int tasks): base(name, empid, salary, bonus)
        {
            NoOfTasks = tasks;
        }
        public int NoOfTasks { get; set; }

        public override double CalculateBonus()
        {
            return ((Bonus / 100) * Salary) + 6000;   
        }
    }

    class SalesPerson : Employee
    {
        public SalesPerson(string name, int empid, double salary, double bonus, int clients):base(name, empid, salary, bonus)
        {
            NoOfClients = clients;
        }
        public int NoOfClients { get; set; }
        public override double CalculateBonus()
        {
            return ((Bonus / 100) * Salary) + 4000;
        }
    }

    
}
