using System;



    class P_13_NumberChekcer
{
        static void Main()
    {
        
        try
        {
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("It is a number.");
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
            
        }
        }
    }

