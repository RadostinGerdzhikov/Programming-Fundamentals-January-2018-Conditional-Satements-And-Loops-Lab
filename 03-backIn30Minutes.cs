using System;


class  BackIn30Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        minutes += 30; // minutes = minutes + 30;

        if (minutes >= 60)
        {
            hours++;
            minutes -= 60; // може и с оператора процент %, който взима остатъка при рзделянето на минутите на 60
        }

        if (hours >=24)
        {
            hours -= 24;
        }


        Console.WriteLine($"{hours}:{minutes:d2}");
    }
}

