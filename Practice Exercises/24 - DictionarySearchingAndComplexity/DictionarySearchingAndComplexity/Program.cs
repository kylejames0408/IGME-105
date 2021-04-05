using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DictionarySearchingAndComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            bool keepSectionRunning;
            string userInput;
            Dictionary<string, bool> dictionaryOfWords;
            List<string> listOfWords;
            FileStream inStream = null;
            StreamReader input = null;

            // Initialize variables
            keepSectionRunning = true;
            dictionaryOfWords = new Dictionary<string, bool>();
            listOfWords = new List<string>();

            // Load in words
            try
            {
                // Initialize streams
                inStream = File.OpenRead("words.txt");
                input = new StreamReader(inStream);

                // Load in each line to the data structures
                String line = null;
                while ((line = input.ReadLine()) != null)
                {
                    dictionaryOfWords.Add(line, false);
                    listOfWords.Add(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error loading in data: {e.Message}");
            }
            finally
            {
                if (input != null)
                {
                    // Close the stream
                    input.Close();
                }
                else if (inStream != null)
                {
                    // File opening may have failed
                    inStream.Close();
                }
            }

            // Searching the List
            //for (int i = 0; i < listOfWords.Count; i++)
            //{
            //    string dupeWord = listOfWords[i] + listOfWords[i];
            //    if (listOfWords.Contains(dupeWord))
            //    {
            //        Console.WriteLine(dupeWord);
            //    }
            //}

            /* Questions
             * 1. The complexity (Big O) of .Contains() on a List is n
             * 2. The complexity of doing .Contains() once for EACH word in the list is n^2
             * 3. The complexity of #2 if we replace List.Contains() with a Dictionary.ContainsKey() is n
             */

            // Searching the Dictionary
            for (int i = 0; i < listOfWords.Count; i++)
            {
                string dupeWord = listOfWords[i] + listOfWords[i];
                if (dictionaryOfWords.ContainsKey(dupeWord))
                {
                    Console.WriteLine(dupeWord);
                    dictionaryOfWords[dupeWord] = true;
                }
            }

            /* Questions
             * 1. The new method is faster because it directly checks for that key in the array, rather than the entire array
             * 2. The first implementation is n^2 and the second implementation is n
             */

            // Loop for user input
            while (keepSectionRunning)
            {
                Console.Write("\nEnter a word: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "quit" || userInput == "done")
                {
                    Console.WriteLine("Goodbye!");
                    keepSectionRunning = false;
                }
                else
                {
                    if (dictionaryOfWords.ContainsKey(userInput))
                    {
                        if (dictionaryOfWords[userInput] == true)
                        {
                            Console.WriteLine($"\"{userInput}\" is a duplicated word\n");
                        }
                        else
                        {
                            Console.WriteLine($"\"{userInput}\" is not a duplicated word\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\"{userInput}\" is not found\n");
                    }
                }
            }

            // Keep the window open!
            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
