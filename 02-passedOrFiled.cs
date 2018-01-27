using System;
using System.Collections.Generic;
using System.Linq;

class PASSED

{
    static void Main()
    {

        
        double grade = double.Parse(Console.ReadLine());
        if (grade >= 3.00)
        {
            Console.WriteLine("Passed!");return;

        }
        Console.WriteLine("Failed!");

    }
}

