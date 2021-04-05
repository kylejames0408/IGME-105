using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            Vector2 vector2a;
            Vector2 vector2b;
            Vector3 vector3a;
            Vector3 vector3b;
            List<Vector3> vectors;
            Vector3 average;

            // Initialize variables
            vector2a = new Vector2(10, 10);
            vector2b = new Vector2(2, 4);
            vector3a = new Vector3(1.5, 2, 3.14159);
            vector3b = new Vector3(5, 5, 5);
            vectors = new List<Vector3>();
            average = new Vector3(0, 0, 0);

            // Show initial vectors
            Console.WriteLine("--- Initial vectors ---");

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(vector2a);
            Console.WriteLine(vector2b);
            Console.WriteLine(vector3a);
            Console.WriteLine(vector3b);

            Console.ResetColor();

            // Make changes
            Console.WriteLine("\n--- After changes ---");

            // Adding 2a and another vector
            Console.Write($"Adding {vector2a} and (4, -13): ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vector2a += new Vector2(4, -13));
            Console.ResetColor();

            // Multiplying 2b
            Console.Write($"Multiplying {vector2b} by 2: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vector2b *= 2);
            Console.ResetColor();

            // Subtracting a vector from 3a
            Console.Write($"Subtracting (1, 2, 3) from {vector3a}: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vector3a -= new Vector3(1, 2, 3));
            Console.ResetColor();

            // Dividing 3b
            Console.Write($"Dividing {vector3b} by 2.5: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(vector3b /= 2.5);
            Console.ResetColor();

            // Add to the list of vectors
            vectors.Add(vector2a);
            vectors.Add(vector2b);
            vectors.Add(vector3a);
            vectors.Add(vector3b);

            // Print explicitly casted vector
            Console.WriteLine("\n--- After explicit cast ---");
            Console.Write("Element at index 3: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine((Vector2)vectors[3]);
            Console.ResetColor();

            // Average the vectors in the list
            Console.WriteLine("\n--- Average ---");
            for (int i = 0; i < vectors.Count; i++)
            {
                average += vectors[i];
            }

            average /= vectors.Count;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(average);
            Console.ResetColor();

            // Keep window open
            Console.ReadKey();
        }
    }
}
