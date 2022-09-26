using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Title = "C# reviewing";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write("Hello");
        Console.WriteLine("2HelloLine");
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("3HelloLine");



        Console.WriteLine("Hello World");

        Console.WriteLine(@"..../\..../\..../\");


        string c = "world.";

        Console.WriteLine("Hello {0}", c);

        string code = "OPEN TEST";

        Console.WriteLine("Your code length is: " + code.Length);

        string myName = Console.ReadLine();
        string upperName = myName.ToUpper();

        Console.WriteLine($"Welcome to the Game, {upperName}");
        int x = 1;
        int y = 1;
        int a = 3;
        int b = 4;
        if (x == y && a != b)
        {
            Console.WriteLine("x is equal to y and a is not equal to b");
        }

        else
        {
            Console.WriteLine("X is may or may not equal to y and a may or may not be equal to b");
        }


        int i = 4;

        switch (i)
        {
            case 1:
                Console.WriteLine("i = 1");
                break;

            case 4:
                Console.WriteLine("i = 4");
                break;


        }



        Console.ResetColor();

        Console.WriteLine("===========");



    }
}