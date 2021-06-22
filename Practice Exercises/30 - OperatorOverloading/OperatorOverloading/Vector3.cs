using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Vector3
    {
        // Fields
        private double x;
        private double y;
        private double z;

        // Properties
        /// <summary>
        /// Get or set the x value of the vector.
        /// </summary>
        public double X { get { return x; } set { x = value; } }

        /// <summary>
        /// Get or set the y value of the vector.
        /// </summary>
        public double Y { get { return y; } set { y = value; } }

        /// <summary>
        /// Get or set the z value of the vector.
        /// </summary>
        public double Z { get { return z; } set { z = value; } }

        // Constructors
        /// <summary>
        /// Creates a default vector (0,0,0).
        /// </summary>
        public Vector3() : this(0, 0, 0)
        {
        }

        /// <summary>
        /// Creates a vector.
        /// </summary>
        /// <param name="x">The x value of the vector.</param>
        /// <param name="y">The y value of the vector.</param>
        /// <param name="z">The z value of the vector.</param>
        public Vector3(double x, double y, double z)
        {
            // Initialize fields
            X = x;
            Y = y;
            Z = z;
        }

        // Methods
        /// <summary>
        /// Provides useful information about the vector.
        /// </summary>
        /// <returns>A string with information about the vector.</returns>
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }

        // Operator overloads
        /// <summary>
        /// Adds Vectors together.
        /// </summary>
        /// <param name="a">The first vector in the operation.</param>
        /// <param name="b">The second vector to add to the first vector.</param>
        /// <returns>A new vector with values retrieved from adding the two vectors.</returns>
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {
            // Create new vector with added values and return it
            return new Vector3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        /// <summary>
        /// Subtracts Vectors from one another.
        /// </summary>
        /// <param name="a">The first vector in the operation.</param>
        /// <param name="b">The second vector to subtract from the first vector.</param>
        /// <returns>A new vector with values retrieved from subtracting the two vectors.</returns>
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {
            // Create new vector with subtracted values and return it
            return new Vector3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        /// <summary>
        /// Multiplies a Vector.
        /// </summary>
        /// <param name="a">The vector to multiply.</param>
        /// <param name="scalar">What to multiply the vector by.</param>
        /// <returns>A new vector with values retrieved from multiplying the vector.</returns>
        public static Vector3 operator *(Vector3 a, double scalar)
        {
            // Create new vector with scaled values and return it
            return new Vector3(a.X * scalar, a.Y * scalar, a.Z * scalar);
        }

        /// <summary>
        /// Divides a Vector.
        /// </summary>
        /// <param name="a">The vector to divide.</param>
        /// <param name="scalar">What to divide the vector by.</param>
        /// <returns>A new vector with the values retrieved from dividing the vector.</returns>
        public static Vector3 operator /(Vector3 a, double scalar)
        {
            // Create new vector with scaled values and return it
            return new Vector3(a.X / scalar, a.Y / scalar, a.Z / scalar);
        }

        /// <summary>
        /// Explicitly casts Vector3 to Vector2.
        /// </summary>
        /// <param name="a">The vector to cast.</param>
        public static explicit operator Vector2(Vector3 a)
        {
            // Create new vector with current values and drop Z
            return new Vector2(a.X, a.Y);
        }
    }
}
