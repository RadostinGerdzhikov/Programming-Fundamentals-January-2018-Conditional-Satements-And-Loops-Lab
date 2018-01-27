using System;

class _05_ForeignLanguages
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine().ToLower();
        /*if (country == "england" || country == "usa")
         {
             Console.WriteLine("English");
         }
         else if (country == "spain" || country == "argentina" || country == "mexico")
         {
             Console.WriteLine("Spanish");
         }
         else
         {
             Console.WriteLine("unknown");
         }*/
        switch (country)
        {
            case "usa":
            case "england": Console.WriteLine("English"); break;
            case "spain":
            case "argenitna":
            case "mexico":
                Console.WriteLine("Spanish");
                break;
                default:
                Console.WriteLine("unknown");    break;
        }




    }
}
