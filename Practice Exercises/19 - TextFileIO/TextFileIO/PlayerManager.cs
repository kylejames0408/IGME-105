using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileIO
{
    class PlayerManager
    {
        // Fields
        private List<Player> players;
        private Random rng;

        // Constructors
        /// <summary>
        /// Constructs a player manager.
        /// </summary>
        /// <param name="rng"></param>
        public PlayerManager(Random rng)
        {
            players = new List<Player>();
            this.rng = rng;
        }

        // Methods
        /// <summary>
        /// Creates a new player and adds it to the manager.
        /// </summary>
        /// <param name="name">The player's name.</param>
        public void CreatePlayer(String name)
        {
            players.Add(new Player(name, rng.Next(100,886), rng.Next(160,401)));
        }

        /// <summary>
        /// Prints the data for each player.
        /// </summary>
        public void Print()
        {
            if (players.Count == 0)
            {
                Console.WriteLine("\tThere are no players in the list - try loading in player data from a file.");
                return;
            }

            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine($"{players[i].ToString()}");
            }
        }

        /// <summary>
        /// Saves the player datas to a file.
        /// </summary>
        public void Save()
        {
            // Check if there is stuff to save first
            if (players.Count == 0)
            {
                Console.WriteLine("\tThere is no player data yet.");
                return;
            }

            // Declare variables for the writer
            FileStream outStream = null;
            StreamWriter output = null;

            try
            {
                // Initialize writer
                outStream = File.OpenWrite("players.txt");
                output = new StreamWriter(outStream);

                // Write some data
                for (int i = 0; i < players.Count; i++)
                {
                    output.WriteLine($"{players[i].Name},{players[i].Health},{players[i].CarryWeight}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error saving data: {e.Message}");
            }
            finally
            {
                if (output != null)
                {
                    // Close the stream
                    output.Close();
                }
                else if (outStream != null)
                {
                    // File opening may have failed
                    outStream.Close();
                }
            }
        }

        /// <summary>
        /// Loads player saves from a file.
        /// </summary>
        public void Load()
        {
            // Clear list of players
            players.Clear();

            // Load in player data
            FileStream inStream = null;
            StreamReader input = null;

            try
            {
                inStream = File.OpenRead("players.txt");
                input = new StreamReader(inStream);

                Console.WriteLine("\tLoading data from players.txt...");

                String line = null;
                while ((line = input.ReadLine()) != null)
                {
                    String[] data = line.Split(',');
                    players.Add(new Player(data[0], int.Parse(data[1]), int.Parse(data[2])));
                    Console.WriteLine($"\tAdded {data[0]} to the list.");
                }

                Console.WriteLine("\tLoaded all data from file. Players created.");
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
        }
    }
}
