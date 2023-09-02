using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point__Counter__Fraction
{
    internal class Point
    {
        private int x;
        public int X { get => x; set { x = value; } }

        private int y;
        public int Y { get => y; set { y = value; } }

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void ShowData() => Console.WriteLine($"X: {x}\nY: {y}");

        public override string ToString() => $"X: {x}\nY: {y}";
    }
}
