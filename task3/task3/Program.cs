using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Gradebook
    {
        private int size;
        private float[] grades ;
        public Gradebook(int size)
        {
            this.size = size;
            grades = new float[size];
        }
        public float this[int index]
        {
            get {
                if (index >= 0 && index < size)
                {
                    return grades[index];
                }
                else { return -1; }
            }
            set { grades[index] = value; }

        }
        public void Display()
        {
            Console.WriteLine(string.Join("|", grades));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Gradebook grades = new Gradebook(4);
            grades[0] = 70;
            grades[1] = 85;
            grades[2] = 96;
            grades[3] = 97;
            grades.Display();
        }
    }
}
