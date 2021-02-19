using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
   public class Rectangle
    {

        private int length, width; // private integer attributes
        public Rectangle()// default constructor
        {
           length = 1; //set length and width as 1
           width = 1;
        }
        public Rectangle(int lengt, int widt) //non default constructor
        {
            length = lengt;
            width = widt;

        }
        public int GetLength()
        {
            //  return this.length; 
            return length;
        }
        public int SetLength(int length)
        {

            // return length;
            return this.length = length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            //  return width;
            return this.width = width;

        }
        public int GetPerimeter()
        {
            int Perimeter = 2 * (length + width);
            return Perimeter;
        }
        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
