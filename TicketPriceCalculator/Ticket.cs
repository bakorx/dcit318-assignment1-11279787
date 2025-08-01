using System;

class TicketCalculator
{
    static int TicketPrice(int age)
    {
        if (age <= 12 || age >= 65)
            return 7;
        else
            return 10;
    }

    static void Main()
    {
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        int age;
        if (int.TryParse(input, out age) && age >= 0)
        {
            int price = TicketPrice(age);
            Console.WriteLine($"Your ticket price is GHC{price}.");
        }
        else
        {
            Console.WriteLine("Invalid age entered.");
        }

        Console.WriteLine("\nPress Enter to exit...");
        Console.ReadLine();
    }
}
