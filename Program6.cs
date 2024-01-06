using System;
internal class Program6
{
    static void Main(string[] args)
    {
        //for (int number = 0; number < 20; number++)
        //{
        //    if (number % 2 != 0)
        //    {
        //        Console.WriteLine(number);
        //    }

        //}

        //int number = 0;
        //do
        //{
        //    if (number % 2 != 0)
        //    {
        //        Console.WriteLine(number);
        //    }
        //    number++;
        //}while (number<=20);

        int number = 0;
        while (number <= 20) 
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
            number++;
        }
    }
}
