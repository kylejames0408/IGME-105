using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
    class MessageLog
    {
        // Fields
        private Dictionary<string, string> messages;

        // Constructors
        /// <summary>
        /// Builds a message log.
        /// </summary>
        public MessageLog()
        {
            messages = new Dictionary<string, string>();
        }

        // Methods
        /// <summary>
        /// Saves a message to the log.
        /// </summary>
        /// <param name="label">The label of the message.</param>
        /// <param name="message">The message to save.</param>
        public void Save(string label, string message)
        {
            messages[label] = message;
        }

        /// <summary>
        /// Print the message log.
        /// </summary>
        public void Print()
        {
            foreach (KeyValuePair<string, string> message in messages)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{message.Key}: ");
                Console.ResetColor();
                Console.WriteLine($"{message.Value}");
            }
        }
    }
}
