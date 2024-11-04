using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heredity
{
    internal abstract class Point
    {
        protected string name;
        protected int x;
        protected int y;

        public Point(string n, int x, int y) 
        { 
            name = n;
            this.x = x;
            this.y = y;
        }

        public virtual string GetName()
        {
            Console.WriteLine($"Name: {name}");
            return name;
        }
        public virtual int[] GetCords()
        {
            Console.WriteLine($"X: {x}, Y: {y}");
            return new int[] { x, y };
        }
        public abstract int GetSize();
    }

    internal class Line : Point
    {
        protected int x2;
        protected int y2;

        public Line(string n, int x1, int y1, int x2, int y2) : base(n, x1, x2)
        {
            this.x2 = x2;
            this.y2 = y2;
        }
        public override int[] GetCords()
        {
            Console.WriteLine($"X: {x}, Y: {y}; X2: {x2}, Y2: {y2}");
            return [x, y, x2, y2];
        }
        public override int GetSize()
        {
            Console.WriteLine($"{x2 - x}");
            return x2 - x;
        }
    }

    internal class Triangle : Line
    {
        protected int x3;
        protected int y3;

        public Triangle(string n, int x1, int y1, int x2, int y2, int x3, int y3) : base(n, x1, y1, x2, y2)
        {
            this.x3 = x3;
            this.y3 = y3;
        }

        public override int[] GetCords()
        {
            Console.WriteLine($"X1: {x}, Y1: {y}; X2: {x2}, Y2: {y2}; X3: {x3}, Y3: {y3}");
            return [x, y, x2, y2, x3, y3];
        }
        public override int GetSize()
        {
            return (base.GetSize() * 1) / 2;
        }
    }
}
