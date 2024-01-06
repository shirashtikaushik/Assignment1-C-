using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

    internal class Program7
    {
       static void Main(string[] args)
    {
        //int number = 5;
        //for (int i = 1; i <= 10; i++)
        //{

        //        Console.WriteLine("{0} x {1} = {2}", number, i, number * i);

        //}

        //int number = 5;
        //int i = 1;
        //do
        //{
        //    Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
        //    i++;
        //} while (i <= 10);
        int number = 5;
        int i = 1;
        while (i <= 10)
        {
            Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            i++;
        }
    }

}

