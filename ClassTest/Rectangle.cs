using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    internal class Rectangle
    {
        public int Length;
        public int Width;

        public Rectangle(int length, int width)
        {
            this.Length = length;
            this.Width = width;
        }
        public void GetArea()
        {
            int Area = Length * Width;
            Console.WriteLine(Area);
        }
        public void GetPerimeter()
        {
            int Perimter = (2 * (Length + Width));
            Console.WriteLine(Perimter);
        }

    }
}
