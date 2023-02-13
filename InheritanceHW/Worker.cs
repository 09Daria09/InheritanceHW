using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    abstract class Worker
    {
        public string Name { get; set; }
        public double Salary { get; set; } 
        public Worker(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }
       public Worker()
        {
            Name = null;
            Salary = 0;
        }
        public abstract void Print();
    }
    class President : Worker
    {
        public President(): base()
        { }
        public President(string name, double salary) : base(name, salary)
        { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary}");
        }
    }

    class Security : Worker
    {
        public string NameSecurity { get; set; }
        public Security() : base()
        {
            NameSecurity = null;
        }
        public Security(string name, double salary, string namesecurity) : base(name, salary)
        {
            NameSecurity = namesecurity;
        }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary} Protects a person: {NameSecurity}");
        }
    }

    class Manager : Worker
    {
        public Manager() : base()
        {}
        public Manager(string name, double salary) : base(name, salary)
        {}
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary}");
        }
    }

    class Engineer : Worker
    {
        public Engineer() : base()
        { }
        public Engineer(string name, double salary) : base(name, salary)
        { }
        public override void Print()
        {
            Console.WriteLine($"Name: {Name} Salary: {Salary}");
        }
    }
}
