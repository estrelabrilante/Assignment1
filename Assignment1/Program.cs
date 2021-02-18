using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;


namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Rectangle Area and Parameter");
            Console.WriteLine("Enter length of rectangle");// fetching parameter from user
            int lengt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width of rectagle");
            int widt = Convert.ToInt32(Console.ReadLine());
            if (lengt <= 0 || widt <= 0)
            {
                Console.WriteLine("Please enter proper value");

            }


            Rectangle cons = new Rectangle(lengt, widt); //instance created for non-default constructor
            Rectangle x = new Rectangle(); // instance created for default constructor
            Console.WriteLine("old length");
            Console.WriteLine(x.GetLength());// getting default value
            Console.WriteLine("old width");
            Console.WriteLine(x.GetWidth());
            Console.WriteLine("setting new value for length");
            Console.WriteLine(cons.SetLength(lengt));
            Console.WriteLine("setting new value for width");
            Console.WriteLine(cons.SetWidth(widt));

            cons.GetPerimeter();
            cons.GetArea();
            Console.Write("Perimeter:");
            Console.WriteLine(cons.GetPerimeter());
            Console.Write("Area:");
            Console.WriteLine(cons.GetArea());

        }
    }
}
