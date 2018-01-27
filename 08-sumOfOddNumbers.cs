using System;




class _08_SumOffOddNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int current = 1;
        int sum = 0;
        while (n > 0 && n < 101)
        {
            Console.WriteLine(current);

            sum += current;
            n--;
            current = current + 2;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}
