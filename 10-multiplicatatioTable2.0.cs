


class _10_MultiplicationTable2.0
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int times = int.Parse(Console.ReadLine());

        do
        {
            Console.WriteLine($"{n} X {times} = {n       * times}");
              times++;
        } while (times<=10);




    }
}
