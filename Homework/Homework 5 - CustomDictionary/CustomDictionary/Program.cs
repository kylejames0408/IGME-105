using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool continueRunning;
            string userKey;
            string userValue;
            string userInput;
            CustomDictionary<string, string> customDictionary;

            // Initialize variables
            continueRunning = true;
            customDictionary = new CustomDictionary<string, string>();

            // Seed dictionary with 6 initial values
            try
            {
                customDictionary.Add("milkshake", "cookies and cream");
                customDictionary.Add("pizza", "cheese");
                customDictionary.Add("steak", "rare with eggs on the side");
                customDictionary["ice"] = "cold";
                customDictionary["fire"] = "hot";
                customDictionary["time"] = "relative";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            // Loop for user commands
            while (continueRunning)
            {
                Console.Write("Custom Dictionary menu:\nCount   Add   Remove   Get   Set   Clear   Quit   >> ");
                userInput = Console.ReadLine().ToLower();

                // Compare user input and perform action
                //  NOTE: Use try catch to catch the errors that we threw
                //        and the errors that the hash function may throw
                switch (userInput)
                {
                    case "count":
                        Console.WriteLine($"The dictionary has {customDictionary.Count} entries.\n");
                        break;
                    case "add":
                        Console.Write("Key: ");
                        userKey = Console.ReadLine().ToLower();
                        Console.Write("Value: ");
                        userValue = Console.ReadLine().ToLower();
                        try
                        {
                            customDictionary.Add(userKey, userValue);
                            Console.WriteLine($"The key '{userKey}' was added\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}\n");
                        }
                        break;
                    case "remove":
                        Console.Write("Key: ");
                        userKey = Console.ReadLine().ToLower();
                        try
                        {
                            if (customDictionary.Remove(userKey) == true)
                            {
                                Console.WriteLine($"The key '{userKey}' was removed\n");
                            }
                            else
                            {
                                Console.WriteLine($"The key '{userKey}' is not in the dictionary.\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}\n");
                        }
                        break;
                    case "get":
                        Console.Write("Key: ");
                        userKey = Console.ReadLine().ToLower();
                        try
                        {
                            Console.WriteLine($"Value is: '{customDictionary[userKey]}'\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}\n");
                        }
                        break;
                    case "set":
                        Console.Write("Key: ");
                        userKey = Console.ReadLine().ToLower();
                        Console.Write("Value: ");
                        userValue = Console.ReadLine().ToLower();
                        try
                        {
                            if (customDictionary.ContainsKey(userKey))
                            {
                                customDictionary[userKey] = userValue;
                                Console.WriteLine($"The value was changed for the key '{userKey}'\n");
                            }
                            else
                            {
                                customDictionary[userKey] = userValue;
                                Console.WriteLine($"The key '{userKey}' was added\n");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}\n");
                        }
                        break;
                    case "clear":
                        customDictionary.Clear();
                        Console.WriteLine("Dictionary was cleared\n");
                        break;
                    case "quit":
                        Console.WriteLine("Goodbye!\n");
                        continueRunning = false;
                        break;
                    default:
                        Console.WriteLine($"{userInput} was not a valid entry.\n");
                        break;
                }
            }

            // Keep window open
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
        }
    }
}
