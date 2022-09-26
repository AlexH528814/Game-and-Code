using System;

class Program
{
    static void Main(string[] args)
    {
        int age;
 string s;
        Console.WriteLine("Please enter your age");

        age = Convert.ToInt32(Console.ReadLine());

        if (age <= 0)
        {
            Console.WriteLine("You are 0 or less years old");
        }

       
        else
        {
            Console.WriteLine("You are old enough to be on this site");
        }
        int n = 1;
        
        for (int f = 1; f < 10; f++)
        {
           
            Console.WriteLine(f);
             if (f == 1)
            {
Console.WriteLine("f is equals to 1");
            }
                
            
        }
        s = Convert.ToString(n);

        Console.WriteLine("This is a string {0}", s);

    }
}