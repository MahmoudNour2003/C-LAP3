using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Resource
    {
        private string fileName;
        private bool isOpen = false;

        public Resource(string fileName)
        {
            this.fileName = fileName;
        }

        public void Open()
        {
            isOpen = true;
            Console.WriteLine($"File {fileName} opened.");
        }

        public string Read()
        {
            if (!isOpen)
                throw new InvalidOperationException("File is not open!");

            Console.WriteLine("Reading data from file...");
            return "Sample Data";
        }

        public void Close()
        {
            if (isOpen)
            {
                isOpen = false;
                Console.WriteLine($"File {fileName} closed.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Resource file = new Resource("data.txt");

            try
            {
                file.Open();
                string data = file.Read();
                Console.WriteLine("Processing data: " + data);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                file.Close();
            }

            Console.WriteLine("Program continues...");
        }
    }
}
