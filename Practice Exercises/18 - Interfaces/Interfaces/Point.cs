using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Point : IPosition
    {
        // Fields
        double x;
        double y;

        // Properties
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        // Constructors
        public Point(double x, double y)
        {
            MoveTo(x, y);
        }

        // Methods
        public double DistanceTo(IPosition position)
        {
            return Math.Sqrt(Math.Pow(x - position.X, 2) + Math.Pow(y - position.Y, 2));
        }

        public void MoveBy(double xOffest, double yOffset)
        {
            x += xOffest;
            y += yOffset;
        }

        public void MoveTo(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"Point: | x: {x} | y: {y}";
        }
    }
}
