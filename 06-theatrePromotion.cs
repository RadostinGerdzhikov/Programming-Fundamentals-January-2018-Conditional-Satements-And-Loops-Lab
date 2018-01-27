using System;

class _06_TheatrePromotions
{
    static void Main()
    {
        string typeOfDay = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());
        int price = 0;
        
		if (age < 0 || age > 122)
        {
            Console.WriteLine("Error!");
            return;
        }
       else if (age <= 18)
        {
            switch (typeOfDay)
            {
                case "weekday": price = 12; break;
                case "weekend":
                    price = 15;
                    break;
                case "holiday":
                    price = 5; break;
                default:
                    break;
            }
        }
        else if (age <= 64)
        {
            switch (typeOfDay)
            {
                case "weekday": price = 18;
                    break;
                case "weekend": price = 20;
                    break;
                case "holiday": price = 12;
                    break;
                  default:
                    break;
            }
        }
        else
        {
            switch (typeOfDay)
            {
                case "weekday":
                    price = 12;break;
                case "weekend":
                    price = 15;break;
                case "holiday":
                    price = 10;break;
                default:
                    break;
            }
        }
        Console.WriteLine(price +"$");
    }
}



