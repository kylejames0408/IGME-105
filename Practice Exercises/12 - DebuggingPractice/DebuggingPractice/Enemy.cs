using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingPractice
{
	class Enemy
	{
		private const int MinDamage = 5;	// Inclusive lower bound for damage
		private const int MaxDamage = 10;	// Inclusive upper bound for damage

		private Random rng;
		private int health;
		private string name;

		public int Health { get { return health; } }
		public string Name { get { return name; } }

		/// <summary>
		/// Creates a new enemy
		/// </summary>
		/// <param name="name">The name of this enemy</param>
		public Enemy(string name, Random rng)
		{
			this.rng = rng;
			health = 100;
			this.name = name;
		}

		/// <summary>
		/// Reduces the enemy's health by the specified amount.
		/// Has no effect if the amount specified is negative.
		/// </summary>
		/// <param name="amount">The amount of damage to take</param>
		public void TakeDamage(int amount)
		{
			if (amount > 0)
			{
				health -= amount;
			}
		}

		/// <summary>
		/// Deals a random amount of damage between the enemy's
		/// Min and Max damage range, inclusive
		/// </summary>
		/// <returns>A random amount of damage</returns>
		public int DealDamage()
		{
			return rng.Next(MinDamage, MaxDamage);
		}
	}
}
