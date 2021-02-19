using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Assignment1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int menu;
            Rectangle cons = new Rectangle();

            do
            {
                Console.WriteLine("Choose any menu");
                Console.WriteLine("1-Get Rectangle Length ");
                Console.WriteLine("2-Change Rectangle Length ");
                Console.WriteLine("3-Get Rectangle Width ");
                Console.WriteLine("4-Change Rectangle Width ");
                Console.WriteLine("5-Get Rectangle Perimeter ");
                Console.WriteLine("6-Get Rectangle Area ");
                Console.WriteLine("7-Exit");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {


                    case 1:
                        Console.WriteLine("Length is ");
                        Console.WriteLine(cons.GetLength());
                        break;
                    case 2:
                       start:
                        Console.WriteLine("Enter new value to set for length");// fetching parameter from user
                        int lengt = Convert.ToInt32(Console.ReadLine());
                        if (lengt <= 0)
                        {
                            Console.WriteLine("Enter a value grater than 0");
                            goto start;
                        }
                        else
                        {
                            Console.WriteLine("setting new value for length" + "\n" + lengt);
                            cons.SetLength(lengt);
                        }
                        break;
                        
                    case 3:
                        Console.WriteLine("Width is");
                        Console.WriteLine(cons.GetWidth());
                        break;

                    case 4:
                        circle:
                        Console.WriteLine("Enter new value to set width of rectagle");
                        int widt = Convert.ToInt32(Console.ReadLine());
                        if (widt <= 0)
                        {
                            Console.WriteLine("Enter a proper value greater that 0");
                            goto circle;
                        }
                        else
                        {
                            Console.WriteLine("setting new value for width" + "\n" + widt);
                            cons.SetWidth(widt);
                        }
                        break;

                    case 5:

                        Console.Write("Perimeter:");
                        Console.WriteLine(cons.GetPerimeter());
                        break;


                    case 6:
                        Console.Write("Area:");
                        Console.WriteLine(cons.GetArea());
                        break;


                    case 7:
                        break;
                }

            } while (menu != 7);



        }

    }
}





