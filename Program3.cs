using System;

     class Program3
{
    static void Main(string[] args)
    {
        //int time = 21;
        //if(time > 21)
        //{
        //    Console.WriteLine("Good Evening");
        //}

        // else if(time < 21)
        //{
        //    Console.WriteLine("Good Morning");
        //}

        //else
        //{
        //    Console.WriteLine("Good Afternoon");
        //}

        int time = 1;
        switch (time)
        {
            case 1:
            case 2:
                Console.WriteLine("Good evening");
                break;

                //case 2:
                //Console.WriteLine("Good Morning"); 
                //break;

                case 3:
                Console.WriteLine("Good Afternoon");
                break;
        }

        }
    }



