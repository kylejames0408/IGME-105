/*
 * The purpose of the program is to prompt the user to fill a list and perform various functions with it (generic).
 * 
 * Author: Kyle James
 * Version: 9/29/2019
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            bool isValidEntry;
            bool run;
            ConsoleColor error = ConsoleColor.DarkRed;
            ConsoleColor userEntry = ConsoleColor.White;
            int index;
            CustomList<string> list;
            CustomList<int> integerList;
            string userInput;

            // Introduce user to program
            Console.WriteLine("Welcome to the CustomList homework!");

            // Get user input
            Console.Write("Specify the initial capacity of the list: ");
            Console.ForegroundColor = userEntry;
            userInput = Console.ReadLine();

            // Check if the input was valid
            isValidEntry = int.TryParse(userInput, out int listSize);
            while (!isValidEntry || listSize <= 0)
            {
                Console.ForegroundColor = error;
                Console.Write("The entered capacity was invalid, please enter a number greater than 0: ");
                Console.ForegroundColor = userEntry;
                userInput = Console.ReadLine();

                isValidEntry = int.TryParse(userInput, out listSize);
            }

            list = new CustomList<string>(listSize);
            Console.WriteLine();

            // Perform list functions and exit the program when the user is done
            Console.ResetColor();
            run = true;

            while (run)
            {
                // Get user input
                Console.Write("Enter a word: ");
                Console.ForegroundColor = userEntry;
                userInput = Console.ReadLine();
                Console.ResetColor();

                // Check what to do with user input
                switch (userInput.ToLower())
                {
                    // If the user is done, exit the program
                    case "done":
                        run = false;
                        Console.WriteLine("Quitting program.\n");
                        break;
                    // Print the list
                    case "print":
                        if (list.Count == 0)
                        {
                            Console.WriteLine("List is empty\n");
                            break;
                        }
                        Console.WriteLine("Printing list contents: ");
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }
                        Console.WriteLine();
                        break;
                    // Get the index of a value in the list
                    case "indexof":
                        Console.Write("Word to search for: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();

                        Console.ResetColor();

                        Console.WriteLine($"The index of \"{userInput}\" is {list.IndexOf(userInput)}\n");
                        break;
                    // See if the list contains a value
                    case "contains":
                        Console.Write("Word to search for: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();

                        Console.ResetColor();

                        if (list.Contains(userInput))
                        {
                            Console.WriteLine($"{userInput} is in the list\n");
                        }
                        else
                        {
                            Console.WriteLine($"{userInput} is NOT in the list\n");
                        }
                        break;
                    // Remove a value at an index
                    case "removeat":
                        Console.Write("Which index to remove?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();

                        isValidEntry = int.TryParse(userInput, out index);
                        if (!isValidEntry || index < 0 || index > list.Count - 1)
                        {
                            Console.ForegroundColor = error;
                            Console.WriteLine("That is not a valid index\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            list.RemoveAt(index);
                            Console.ResetColor();
                            Console.WriteLine($"Data at index {index} removed\n");
                        }
                        break;
                    // Remove a value from the list
                    case "remove":
                        Console.Write("Word to remove: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();

                        if (!list.Remove(userInput))
                        {
                            Console.ForegroundColor = error;
                            Console.WriteLine($"\"{userInput}\" was not found\n");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.WriteLine($"{userInput} was removed\n");
                        }
                        break;
                    // Insert a value at a certain place in the list
                    case "insert":
                        Console.Write("Which index?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        isValidEntry = int.TryParse(userInput, out index);
                        while (!isValidEntry)
                        {
                            Console.ForegroundColor = error;
                            Console.Write("That was not a valid entry, please enter a number: ");
                            Console.ForegroundColor = userEntry;
                            userInput = Console.ReadLine();

                            isValidEntry = int.TryParse(userInput, out index);
                            Console.ResetColor();
                        }
                        if (index < 0 || index >= list.Count)
                        {
                            Console.ForegroundColor = error;
                            Console.WriteLine("That is not a valid index.\n");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write("Which word to insert?: ");
                            Console.ForegroundColor = userEntry;
                            userInput = Console.ReadLine();
                            list.Insert(index, userInput);
                            Console.ResetColor();
                            Console.WriteLine($"Inserted \"{userInput}\" into index {index}\n");
                        }
                        break;
                    // Clear the list
                    case "clear":
                        list.Clear();
                        Console.WriteLine("List has been cleared\n");
                        break;
                    // Get the value at a certain index
                    case "get":
                        Console.Write("Which index to retrieve?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        isValidEntry = int.TryParse(userInput, out index);
                        while (!isValidEntry)
                        {
                            Console.ForegroundColor = error;
                            Console.Write("That was not a valid entry, please enter a number: ");
                            Console.ForegroundColor = userEntry;
                            userInput = Console.ReadLine();

                            isValidEntry = int.TryParse(userInput, out index);
                            Console.ResetColor();
                        }

                        if (index < 0 || index >= list.Count)
                        {
                            Console.ForegroundColor = error;
                            Console.WriteLine($"{index} is not a valid index\n");
                            Console.ResetColor();
                            break;
                        }

                        Console.ResetColor();
                        Console.WriteLine($"The item at index {index} is \"{list[index]}\"\n");
                        break;
                    // Set the value at a certain index
                    case "set":
                        Console.Write("Which index?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        isValidEntry = int.TryParse(userInput, out index);
                        while (!isValidEntry)
                        {
                            Console.ForegroundColor = error;
                            Console.Write("That was not a valid entry, please enter a number: ");
                            Console.ForegroundColor = userEntry;
                            userInput = Console.ReadLine();

                            isValidEntry = int.TryParse(userInput, out index);
                            Console.ResetColor();
                        }

                        if (index < 0 || index >= list.Count)
                        {
                            Console.ForegroundColor = error;
                            Console.WriteLine($"{index} is not a valid index\n");
                            Console.ResetColor();
                            break;
                        }

                        Console.ResetColor();
                        Console.Write("Which word?: ");
                        Console.ForegroundColor = userEntry;
                        userInput = Console.ReadLine();
                        list[index] = userInput;
                        Console.ResetColor();
                        Console.WriteLine($"\"{userInput}\" has been placed at index {index}\n");
                        Console.WriteLine();
                        break;
                    // Add it to the list if it isn't one of these options
                    default:
                        list.Add(userInput);
                        Console.WriteLine($"\"{userInput}\" added to list\n");
                        break;
                }
            }

            // Present an integer presentation of the CustomList
            Console.WriteLine("\n\nInteger List");
            integerList = new CustomList<int>();
            integerList.Add(2);
            integerList.Add(3);
            integerList.Add(4);
            Console.WriteLine("List contents: ");
            integerList.Print();
            Console.WriteLine("\nWhat is the index of the number 2?: ");
            Console.WriteLine(integerList.IndexOf(2));
            Console.WriteLine("\nDoes the list contain 3?: ");
            Console.WriteLine(integerList.Contains(3));
            Console.WriteLine("\nRemove 2");
            integerList.Remove(2);
            Console.WriteLine("List contents: ");
            integerList.Print();
            Console.WriteLine("\nRemove the number at index 0:");
            integerList.RemoveAt(0);
            Console.WriteLine("List contents: ");
            integerList.Print();
            Console.WriteLine("\nInsert the number 4 at the index of 0:");
            integerList.Insert(0, 4);
            Console.WriteLine("List contents: ");
            integerList.Print();
            Console.WriteLine("\nClear the list: ");
            integerList.Clear();
            Console.WriteLine("List contents: ");
            integerList.Print();

            // Keep the window open
            Console.WriteLine("\nPress any key to continue. . .");
            Console.ReadKey();
        }
    }
}
