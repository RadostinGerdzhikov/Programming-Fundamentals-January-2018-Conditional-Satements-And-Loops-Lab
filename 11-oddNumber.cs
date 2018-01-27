using System;



class _12_oddNumber
{
    static void Main(string[] args)
    {
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        while (true)
        {
            if (n % 2 == 1)
                break;
            {
                Console.WriteLine("Please write an odd number.");
                n = Math.Abs(int.Parse(Console.ReadLine()));
            }
            
        }
        Console.WriteLine("The number is: " + n);



    }
}

