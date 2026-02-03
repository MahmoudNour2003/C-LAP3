using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Student
    {
        public Student() { }
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public void Display()
        {
            Console.WriteLine("ID :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("GPA :" + GPA);
        }
    }
    internal class Program
    {
        public static void DisplayStudents(List<Student> std)
        {
            foreach (Student student in std) { 
                student.Display();
                Console.WriteLine("............");
            }
        }
        static void Main(string[] args)
        {
            var students = new List<Student> {
               new Student { Id = 1, Name = "Mahmoud", GPA = 3.65 }
               , new Student { Id = 2,Name= "Ahmed",GPA =3.4 },
               new Student {Id= 3,Name="Mariam",GPA=3.5 } };
            DisplayStudents(students);
            Student found = students.Find(s => s.Name == "Mahmoud");
            Console.WriteLine("Found Student:");
            found.Display();
            List<Student> honors = students.FindAll(s => s.GPA >= 3.5);
            Console.WriteLine("students with GPA more than 3.5");
            DisplayStudents(honors);
            students.Sort((a, b) => b.GPA.CompareTo(a.GPA));
            Console.WriteLine("students after sorting by GPA");
            DisplayStudents(students);
        }
    }
}
