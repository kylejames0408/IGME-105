using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
	class Homework3Game : Game
	{
		// Fields
        private static Random rng = new Random();
        List<Monster> monsters = new List<Monster>() { new Monster(), new Bouncer(), new Patterner(5), new Randomer(rng), new Wrapper() };


		/// <summary>
		/// Example constructor - Make this do whatever your game needs it to do
		/// </summary>
		public Homework3Game()
		{
			// Changes the console window's title
			Console.Title = "Welcome to the Homework 3 Game!";		
		}

		/// <summary>
		/// This method should update the game state, respond to user input, etc.
		/// 
		/// It should not actually "draw" (Console.Write or Console.WriteLine) anything
		/// to the screen.  That should happen in the Draw() method below.
		/// </summary>
		public override void Update()
		{
			// Pause to allow the user to see what's on the screen
			base.Update(); // Don't remove this

			// Ends the game if Escape is pressed
			if (KeyboardHelper.IsKeyDown(KeyCode.Escape))
			{
				GameOver = true;
			}

            // Updates all of the monsters
            for (int i = 0; i < monsters.Count; i ++)
            {
                monsters[i].Update();
            }
		}

		/// <summary>
		/// This method should handle "drawing" objects to the console window
		/// using Console.Write() or Console.WriteLine()
		/// 
		/// Remember: You can set the cursor's current position by using
		/// Console.CursorTop and Console.CursorLeft
		/// 
		/// You will get an error if you try to move the cursor outside
		/// the console's bounds.  You can find the bounds using
		/// Console.WindowWidth and Console.WindowHeight
		/// </summary>
		public override void Draw()
		{
			// Clears the screen
			base.Draw(); // Don't remove this

			// Print instructions to the screen
			Console.WriteLine("Press WASD keys to move the basic 'M' monster");

            // Draw the monsters
            for (int i = 0; i < monsters.Count; i++)
            {
                monsters[i].Draw();
            }
        }

	}
}
