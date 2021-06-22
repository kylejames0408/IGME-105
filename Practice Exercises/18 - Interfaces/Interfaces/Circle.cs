using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Circle : IPosition, IArea
    {
        // Fields
        double area;
        double perimeter;
        double r;
        double x;
        double y;

        // Properties
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public double Area { get { return area; } }

        public double Perimeter { get { return perimeter; } }

        // Constructors
        public Circle(double x, double y, double r)
        {
            this.r = r;
            MoveTo(x, y);
            area = Math.PI * Math.Pow(r, 2);
            perimeter = 2 * Math.PI * r;
        }

        // Methods
        public bool ContainsPosition(IPosition position)
        {
            if (DistanceTo(position) <= r)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double DistanceTo(IPosition position)
        {
            return Math.Sqrt(Math.Pow(x - position.X, 2) + Math.Pow(y - position.Y, 2));
        }

        public bool IsLargerThan(IArea areaToCheck)
        {
            if (area > areaToCheck.Area)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            return $"Circle: | center x: {x} | center y: {y} | radius: {r} | area: {area} | perimeter: {perimeter}";
        }
    }
}
