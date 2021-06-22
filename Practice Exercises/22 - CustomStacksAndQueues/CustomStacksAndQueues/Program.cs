using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            GameStack<string> gameStack;
            GameQueue<string> gameQueue;

            // Initialize variables
            gameStack = new GameStack<string>(5);
            gameQueue = new GameQueue<string>(5);

            // Print and add names to stack
            Console.WriteLine("The following spells are being put on the stack:");
            gameStack.Push("Shock");
            Console.WriteLine($"- {gameStack.Peek()}");
            gameStack.Push("Fork");
            Console.WriteLine($"- {gameStack.Peek()}");
            gameStack.Push("Counterspell");
            Console.WriteLine($"- {gameStack.Peek()}");
            gameStack.Push("Force of Will");
            Console.WriteLine($"- {gameStack.Peek()}");
            gameStack.Push("Deflection");
            Console.WriteLine($"- {gameStack.Peek()}");

            // Loop through stacck and print names
            Console.WriteLine("\nSpells resolving (in reverse order):");
            while (gameStack.Count > 0)
            {
                Console.WriteLine($"- {gameStack.Pop()}");
            }

            // Print and add names to the queue
            Console.WriteLine("\n\nThe following players are joining the queue:");
            Console.WriteLine("- Bob");
            Console.WriteLine("- Tom");
            Console.WriteLine("- Sara");
            Console.WriteLine("- Jim");
            Console.WriteLine("- Larry");
            gameQueue.Enqueue("Bob");
            gameQueue.Enqueue("Tom");
            gameQueue.Enqueue("Sara");
            gameQueue.Enqueue("Jim");
            gameQueue.Enqueue("Larry");

            // Remove from the queue
            while (gameQueue.Count > 0)
            {
                Console.WriteLine($"\n\"{gameQueue.Dequeue()}\" has joined the server: {gameQueue.Count} player(s) left in queue");
            }

            // Keep the window open
            Console.WriteLine("\n\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
