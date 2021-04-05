using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize objects
            Point p1 = new Point(5, 7);
            Point p2 = new Point(10, 10);
            Circle c1 = new Circle(10, 10, 3);
            Circle c2 = new Circle(0, 0, 5);

            // Output initial objects
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // Move two objects
            Console.WriteLine("\nMoving point 2 to (2, 2)");
            Console.WriteLine("Moving circle 2 by (-1, -1)\n");
            p2.MoveTo(2, 2);
            c2.MoveBy(-1, -1);

            // Output moved objects
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(c1);
            Console.WriteLine(c2);

            // Output distances
            Console.WriteLine($"\nDistance between point 1 and point 2: {p1.DistanceTo(p2)}");
            Console.WriteLine($"Distance between point 1 and circle 1: {p1.DistanceTo(c1)}");
            Console.WriteLine($"Distance between point 1 and circle 2: {p1.DistanceTo(c2)}");
            Console.WriteLine($"Distance between point 2 and circle 1: {p2.DistanceTo(c1)}");
            Console.WriteLine($"Distance between point 2 and circle 2: {p2.DistanceTo(c2)}\n");

            // Compare circle areas
            if (c1.IsLargerThan(c2))
            {
                Console.WriteLine($"Circle 1's area ({c1.Area}) is larger than circle 2's area ({c2.Area})\n");
            }
            else if (c2.IsLargerThan(c1))
            {
                Console.WriteLine($"Circle 2's area ({c2.Area}) is larger than circle 1's area ({c1.Area})\n");
            }
            else
            {
                Console.WriteLine($"Circle 1's area ({c1.Area}) is equal to circle 2's area ({c2.Area})\n");
            }

            // Check is circles contain points
            Console.Write("Does circle 1 contain point 1?: ");
            if (c1.ContainsPosition(p1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.Write("Does circle 1 contain point 2?: ");
            if (c1.ContainsPosition(p2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.Write("Does circle 2 contain point 1?: ");
            if (c2.ContainsPosition(p1))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.Write("Does circle 2 contain point 2?: ");
            if (c2.ContainsPosition(p2))
            {
                Console.WriteLine("Yes\n");
            }
            else
            {
                Console.WriteLine("No\n");
            }

            // Keep the window open!
            Console.WriteLine("Press any key to continue. . .");
            Console.ReadKey();
        }
    }
}
