using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{

    internal class Program
    {
        public static void DisplayCart(ArrayList cart)
        {
            Console.WriteLine("Display Cart");
            for(int i=0;i<cart.Count;i++)
            {
                Console.WriteLine(i+") " + cart[i]);
                
            }
            Console.WriteLine("....................");
        }
        static void Main(string[] args)
        {
            ArrayList cart = new ArrayList();
            cart.Add(98);
            cart.Add(3.14);
            cart.Add("Mahmoud Reda");
            cart.Add(DateTime.Now);
            DisplayCart(cart);
            cart.Insert(2, "ITI");
            Console.WriteLine("Cart after insert ");
            DisplayCart(cart);
            cart.Remove(98);
            Console.WriteLine("Cart after Remove 98");
            DisplayCart(cart);


        }
    }
}
