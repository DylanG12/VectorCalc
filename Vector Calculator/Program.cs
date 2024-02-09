using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector test1 = new Vector(6, 21, 0);
            Vector test2 = new Vector(30, 9, 0);


            // This should be
            Console.WriteLine("These are the vectors: " + test1 + test2 + "\n");
            Console.WriteLine("Insert a random number (can include decimals) for scale (cannot be a fraction and MUST NOT be in letters): ");
            double userScale = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("This is the magnitude of both vectors: ");
            Console.WriteLine(test1.GetMagnitude() + "\n");
            Console.WriteLine(test2.GetMagnitude() + "\n");
            Console.WriteLine("This is the direction of the vectors: ");
            Console.WriteLine(test1.GetDirection() + "\n");
            Console.WriteLine("This is the result of the vectors being added: ");
            Console.WriteLine(Vector.Add(test1, test2) + "\n");
            Console.WriteLine("These are the vectors negated: ");
            Console.WriteLine(Vector.Negate(test1));
            Console.WriteLine(Vector.Negate(test2) + "\n");
            Console.WriteLine("This is the result of the vectors being subtracted: ");
            Console.WriteLine(Vector.Subtract(test1, test2) + "\n");
            Console.WriteLine("This is the result of the vectors being scaled by a factor of " + userScale + "\n");
            Console.WriteLine(Vector.Scale(test1, userScale));
            Console.WriteLine(Vector.Scale(test2, userScale) + "\n");
            Console.WriteLine("This is the vectors normalized: ");
            Console.WriteLine(Vector.Normalize(test1) + "\n");
            Console.WriteLine("This is the dot product of the vectors: ");
            Console.WriteLine(Vector.DotProduct(test1, test2) + "\n");
            Console.WriteLine("This is the cross product of the vectors: ");
            Console.WriteLine(Vector.CrossProduct(test1, test2) + "\n");
            Console.WriteLine("This is the angle in radians between both vectors: ");
            Console.WriteLine(Vector.AngleBetween(test1, test2) + "\n");
            Console.WriteLine("This is the vectors projected onto each other: ");
            Console.WriteLine(Vector.ProjectOnto(test1, test2) + "\n");
        }
    }
}
