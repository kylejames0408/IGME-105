using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			// Display each problem, then wait and clear the screen

			// === PROBLEM 0 ===
			Console.WriteLine("--- Problem 0 - Demo ---\n");
			Problem0_Demo();
			WaitAndClear();

			// === PROBLEM 1 ===
			Console.WriteLine("--- Problem 1 - Array Search ---\n");
			Problem1_ArraySearch();
			WaitAndClear();

			// === PROBLEM 2 ===
			Console.WriteLine("--- Problem 2 - Enemy Fight ---\n");
			Problem2_EnemyFight();
			WaitAndClear();

			// === PROBLEM 3 ===
			Console.WriteLine("--- Problem 3 - Number Removal ---\n");
			Problem3_NumberRemoval();
			WaitAndClear();
			
			// === PROBLEM 4 ===
			Console.WriteLine("--- Problem 4 - Pizza Contest ---\n");
			Problem4_PizzaContest();
			WaitAndClear();
		}

		/// <summary>
		/// Waits until the user presses enter, then clears the screen
		/// </summary>
		static void WaitAndClear()
		{
			Console.WriteLine("\nPress enter to continue...");
			Console.ReadLine();
			Console.Clear();
		}


		/// <summary>
		/// TO DO: Describe what this method does
		/// 
		///  - What is the expected output?
		///  - How might you test it?
		///  - What issues have you identified?
		///  - How have you fixed them?
		/// </summary>
		static void Problem0_Demo()
		{
			// Prepare to roll dice and record results
			Random rng = new Random();
			int[] rollTotals = new int[13];

			// Total number of rolls to perform
			const int rolls = 1000;
			for (int i = 0; i < rolls; i++)
			{
				// Roll two dice
				int die1 = rng.Next(1, 7);
				int die2 = rng.Next(1, 7);

				// Record that we've rolled this sum
				rollTotals[die1 + die2]++;
			}

			// Print percentages
			for (int i = 2; i < 13; i++)
			{
				Console.WriteLine(i +  ": " + (rollTotals[i] / (double)rolls) * 100 + "%");
			}
		}



		/// <summary>
		/// TO DO: Describe what this method does
		/// 
		///  - What is the expected output?
		///  - How might you test it?
		///  - What issues have you identified?
		///  - How have you fixed them?
		/// </summary>
		static void Problem1_ArraySearch()
		{
			// An example array of data to search through
			int[] data = { 92, -12, 46, 999, 123, 46, 52, 63, 38, 4, 8, 15, 16, 23, 42 };

			// Get a number from the user
			int userNumber = 0;
			Console.Write("Enter an integer to search for: ");
			while (!int.TryParse(Console.ReadLine(), out userNumber))
			{
				Console.Write("Invalid integer - please re-enter: ");
			}

            // Search for the number
            bool found = false;
			for (int i = 0; i < data.Length; i++)
			{
				if (data[i] == userNumber)
				{
                    found = true;
					Console.WriteLine("Data found at index " + i);
				}
			}

            if(!found)
            {
                Console.WriteLine("Data not found!");
            }
		}

		/// <summary>
		/// TO DO: Describe what this method does
		/// 
		///  - What is the expected output?
		///  - How might you test it?
		///  - What issues have you identified?
		///  - How have you fixed them?
		/// </summary>
		static void Problem2_EnemyFight()
		{
            Random rng = new Random();
            // Create two enemies
			Enemy e1 = new Enemy("Bob", rng);
			Enemy e2 = new Enemy("Jan", rng);

			// Print out the enemy names
			Console.WriteLine("Enemies " + e1.Name + " and " + e2.Name + " begin to fight\n");
			Console.WriteLine("Press enter to see who wins!");
			Console.ReadLine();

			// Loop and deal damage to each other
			while (e1.Health > 0 && e2.Health > 0)
			{
				// Enemy 1 takes the damage enemy 2 deals
				e1.TakeDamage(e2.DealDamage());

				// Enemy 2 takes the damage enemy 1 deals
				e2.TakeDamage(e1.DealDamage());
			}

			// Check for winner
			if (e1.Health <= 0 && e2.Health <= 0)
			{
				Console.WriteLine("It's a tie!");
			}
			else if (e1.Health <= 0)
			{
				Console.WriteLine(e2.Name + " is the winner!");
			}
			else
			{
				Console.WriteLine(e1.Name + " is the winner!");
			}
		}

		/// <summary>
		/// TO DO: Describe what this method does
		/// 
		///  - What is the expected output?
		///  - How might you test it?
		///  - What issues have you identified?
		///  - How have you fixed them?
		/// </summary>
		static void Problem3_NumberRemoval()
		{
			List<int> numbers = new List<int>() { 12, 99, -3, -72, 14, -5, -6, -7, -8, 32, 64 };
			Console.WriteLine("Removing all negative numbers from the list\n");

			// Print the numbers
			Console.WriteLine("Current numbers:");
			foreach(int num in numbers)
				Console.WriteLine(num);

			// Loop and remove all negative numbers
			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] < 0)
				{
					numbers.RemoveAt(i);
                    i--;
				}
			}

			// Print the numbers again
			Console.WriteLine("\nNumbers after removal:");
			foreach (int num in numbers)
				Console.WriteLine(num);
		}

		/// <summary>
		/// TO DO: Describe what this method does
		/// 
		///  - What is the expected output?
		///  - How might you test it?
		///  - What issues have you identified?
		///  - How have you fixed them?
		/// </summary>
		static void Problem4_PizzaContest()
		{
			// Print greeting and rules
			Console.WriteLine("Answer questions to determine if you're eligible to win a free pizza!\n");
			Console.WriteLine("Here are the rules:");
			Console.WriteLine("1. Your name must have at least 5 letters or it must not start with a vowel");
			Console.WriteLine("2. You must like pizza or you must have at least 3 friends who like pizza");
			Console.WriteLine("3. You must have never won free pizza before, or if you have, it was more than 2 weeks ago\n");

			// Variables for eligibility (initializing to default values)
			string name = null;
			string likePizza = null;
			int friendPizzaCount = 0;
			string hasWonPizza = null;
			int wonPizzaWeeks = 0;

			// Name
			Console.Write("Enter your first name: ");
			name = Console.ReadLine();

			// Like pizza?
			do
			{
				Console.Write("Do you like pizza? (y/n): ");
				likePizza = Console.ReadLine().ToLower();
			} while (likePizza != "y" && likePizza != "n");

			// How many friends like pizza?
			Console.Write("How many of your friends like pizza? ");
			while (!int.TryParse(Console.ReadLine(), out friendPizzaCount))
			{
				Console.Write("Invalid input, please enter an integer: ");
			}

			// Previous winner?
			do
			{
				Console.Write("Have you ever won free pizza before? (y/n): ");
				hasWonPizza = Console.ReadLine().ToLower();
			} while (hasWonPizza != "y" && hasWonPizza != "n");

			// Only ask this question if the user has won free pizza before
			if (hasWonPizza == "y")
			{
				Console.Write("How many weeks ago did you win free pizza? ");
				while (!int.TryParse(Console.ReadLine(), out wonPizzaWeeks))
				{
					Console.Write("Invalid input, please enter an integer: ");
				}
			}

			// Make checking first letter easier
			name = name.ToUpper();

			// Determine if the user is eligible!
			if (name.Length > 5 || name[0] != 'A' || name[0] != 'E' || name[0] != 'I' || name[0] != 'O' || name[0] != 'U' 
				&& likePizza == "y" || friendPizzaCount >= 3 && hasWonPizza == "n" || wonPizzaWeeks >= 2)
			{
				Console.WriteLine("\nCongrats, you have been entered into the contest!");
			}
			else
			{
				Console.WriteLine("\nSorry, you are not eligible to win.");
			}

		}

	}
}
