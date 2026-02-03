using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class StringCollection
    {
        private List<string> values = new List<string>();

        private List<string> keys = new List<string>();
        private List<string> keyValues = new List<string>();
        public string this[int index]
        {
            get
            {
                return values[index];
            }
            set
            {
                while (values.Count <= index)
                {
                    values.Add(null);
                }
                values[index] = value;
            }
        }

        public string this[string key]
        {
            get
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i] == key)
                        return keyValues[i];
                }
                return null;
            }
            set
            {
                for (int i = 0; i < keys.Count; i++)
                {
                    if (keys[i] == key)
                    {
                        keyValues[i] = value;
                        return;
                    }
                }

                keys.Add(key);
                keyValues.Add(value);
            }
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            StringCollection collection = new StringCollection();

           
            collection[0] = "Ahmed";
            collection[1] = "Sara";
            collection[2] = "Omar";

            Console.WriteLine(collection[0]);
            Console.WriteLine(collection[1]);
            Console.WriteLine(collection[2]);


            collection["server"] = "localhost";
            collection["port"] = "8080";
            collection["db"] = "mydb";

            Console.WriteLine(collection["server"]);
            Console.WriteLine(collection["port"]);
            Console.WriteLine(collection["db"]);
        }
    }
}
