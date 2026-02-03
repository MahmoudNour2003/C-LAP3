using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Person
    {
        public Person() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"ID :{Id}");
            Console.WriteLine($"Name :{Name}");
            Console.WriteLine($"Age :{Age}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Id = 1, Name = "Mahmoud Reda", Age = 23 };
            p.DisplayInfo();

        }
    }
}
