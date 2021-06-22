using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BinaryFileIO
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
            players.Add(new Player(name, rng.Next(100, 886), rng.Next(160, 401)));
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
            Stream outStream = null;
            BinaryWriter output = null;

            try
            {
                // Initialize writer
                outStream = File.OpenWrite("players.data");
                output = new BinaryWriter(outStream);

                // Write some data
                output.Write(players.Count);
                for (int i = 0; i < players.Count; i++)
                {
                    output.Write(players[i].Name);
                    output.Write(players[i].Health);
                    output.Write(players[i].CarryWeight);
                }

                Console.WriteLine("\tFile successfully saved.");
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
            Stream inStream = null;
            BinaryReader input = null;

            try
            {
                inStream = File.OpenRead("players.data");
                input = new BinaryReader(inStream);

                Console.WriteLine("\tLoading data from players.data...");

                int numberOfPlayers = input.ReadInt32();

                for (int i = 0; i < numberOfPlayers; i++)
                {
                    string name = input.ReadString();
                    int health = input.ReadInt32();
                    int carryWeight = input.ReadInt32();
                    players.Add(new Player(name, health, carryWeight));
                    Console.WriteLine($"\tAdded {name} to the list.");
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
