using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Vector2
    {
        // Fields
        private double x;
        private double y;

        // Properties
        /// <summary>
        /// Get or set the x value of the vector.
        /// </summary>
        public double X { get { return x; } set { x = value; } }

        /// <summary>
        /// Get or set the y value of the vector.
        /// </summary>
        public double Y { get { return y; } set { y = value; } }

        // Constructors
        /// <summary>
        /// Creates a default vector (0,0).
        /// </summary>
        public Vector2() : this(0, 0)
        {
        }

        /// <summary>
        /// Creates a vector.
        /// </summary>
        /// <param name="x">The x value of the vector.</param>
        /// <param name="y">The y value of the vector.</param>
        public Vector2(double x, double y)
        {
            // Initialize fields
            X = x;
            Y = y;
        }

        // Methods
        /// <summary>
        /// Provides useful information about the vector.
        /// </summary>
        /// <returns>A string with information about the vector.</returns>
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        // Operator overloads
        /// <summary>
        /// Adds Vectors together.
        /// </summary>
        /// <param name="a">The first vector in the operation.</param>
        /// <param name="b">The second vector to add to the first vector.</param>
        /// <returns>A new vector with values retrieved from adding the two vectors.</returns>
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            // Create new vector with added values and return it
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        /// <summary>
        /// Subtracts Vectors from one another.
        /// </summary>
        /// <param name="a">The first vector in the operation.</param>
        /// <param name="b">The second vector to subtract from the first vector.</param>
        /// <returns>A new vector with values retrieved from subtracting the two vectors.</returns>
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            // Create new vector with subtracted values and return it
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }

        /// <summary>
        /// Multiplies a Vector.
        /// </summary>
        /// <param name="a">The vector to multiply.</param>
        /// <param name="scalar">What to multiply the vector by.</param>
        /// <returns>A new vector with values retrieved from multiplying the vector.</returns>
        public static Vector2 operator *(Vector2 a, double scalar)
        {
            // Create new vector with scaled values and return it
            return new Vector2(a.X * scalar, a.Y * scalar);
        }

        /// <summary>
        /// Divides a Vector.
        /// </summary>
        /// <param name="a">The vector to divide.</param>
        /// <param name="scalar">What to divide the vector by.</param>
        /// <returns>A new vector with the values retrieved from dividing the vector.</returns>
        public static Vector2 operator /(Vector2 a, double scalar)
        {
            // Create new vector with scaled values and return it
            return new Vector2(a.X / scalar, a.Y / scalar);
        }

        /// <summary>
        /// Implicitly casts Vector2 to Vector3.
        /// </summary>
        /// <param name="a">The vector to cast.</param>
        public static implicit operator Vector3(Vector2 a)
        {
            // Create new vector with current values and a basic Z
            return new Vector3(a.X, a.Y, 0);
        }
    }
}
