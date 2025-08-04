using System;

class TriangleIdentifier
{
    static string GetTriangleType(int a, int b, int c)
    {
        if (a == b && b == c)
            return "Equilateral";
        else if (a == b || b == c || a == c)
            return "Isosceles";
        else
            return "Scalene";
    }

    static void Main()
    {
        Console.WriteLine("Enter the sides of the triangle:");

        Console.Write("First Side: ");
        int side1 = int.Parse(Console.ReadLine());

        Console.Write("Second Side: ");
        int side2 = int.Parse(Console.ReadLine());

        Console.Write("Third Side: ");
        int side3 = int.Parse(Console.ReadLine());

        
        if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        {
            string triangleType = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"This is a {triangleType} triangle.");
        }
        else
        {
            Console.WriteLine("The sides do not form a valid triangle.");
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
