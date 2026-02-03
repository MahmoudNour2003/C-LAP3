using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public string Color { get; set; } = "Black";
        public string Unit { get; set; } = "cm";
        public int Id { get; }
        public double Area => Width * Height;
        public Rectangle() { }
        public void DisplayInfo()
        {
            Console.WriteLine($"Width :{Width} {Unit} Height :{Height} {Unit}");
            Console.WriteLine($"color :{Color}");
            Console.WriteLine($"Area :{Area}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var r =new Rectangle { Width=2, Height=2 ,Unit="inch"};
            r.DisplayInfo();
        }
    }
}
