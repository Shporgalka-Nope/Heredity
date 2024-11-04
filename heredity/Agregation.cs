using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heredity
{
    internal class PointA
    {
        protected string name;
        protected int x;
        protected int y;

        public PointA(string n, int x, int y)
        {
            name = n;
            this.x = x;
            this.y = y;
        }

        public string GetName()
        {
            return name;
        }
        public int[] GetCords()
        {
            return [x, y];
        }
    }
    
    internal class LineA
    {
        public string name;
        private PointA p1;
        private PointA p2;

        public LineA(string n, int x1, int y1, int x2, int y2)
        {
            name = n;
            p1 = new PointA("p1", x1, y1);
            p2 = new PointA("p2", x2, y2);
        }

        public string GetName() 
        {
            return name;
        }
        public int[] GetCords() 
        {
            int[] cords = new int[4];
            cords[0] = p1.GetCords()[0];
            cords[1] = p1.GetCords()[1];
            cords[3] = p2.GetCords()[0];
            cords[4] = p2.GetCords()[1];
            return cords;
        }
        public int GetSize()
        {
            return p2.GetCords()[0] - p1.GetCords()[0];
        }
    }

    internal class Rectange
    {
        public string name;
        private LineA l1;
        private LineA l2;
        private LineA l3;
        private LineA l4;

        public Rectange(string n, int x, int y, int x2, int y2, int x3, int y3, int x4, int y4)
        {
            l1 = new LineA("a", x, y, x2, y2);
            l2 = new LineA("b", x3, y3, x4, y4);
            l3 = new LineA("c", x, y, x3, x4);
            l4 = new LineA("d", x2, y2, x4, y4);
        }

        public string GetName()
        {
            return name;
        }
        public int[] GetCords() 
        {
            int[] cords =
            [
                l1.GetCords()[0],
                l1.GetCords()[1],
                l2.GetCords()[0],
                l2.GetCords()[1],
                l3.GetCords()[0],
                l3.GetCords()[1],
                l4.GetCords()[0],
                l4.GetCords()[1],
            ];
            return cords;
        }
    }
}