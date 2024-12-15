using System;
using System.Data;
using System.Transactions;
using Sandclock;

class Program
{

    static void Main()
    {
        static void printstring(string str)
        {
            foreach (char letter in str)
            {
                Console.Write(letter);
                Thread.Sleep(10);
            }
            Console.WriteLine("\t");
        }
        Console.WriteLine("WELCOME TO SANDCLOCK SIMULATOR");
        string str = "Choose the amount of time for the first and second hourglass as well as the required time";
        printstring(str);

        Valuetable valuetable = new Valuetable();
        valuetable.printarr();
        Console.WriteLine("Enter time of the first hourglass: ");
        int a = Convert.ToInt32 (Console.ReadLine());
        Console.Clear();
        valuetable.putinarr(a, 2);
        valuetable.printarr();
        Console.WriteLine("Enter time of the second hourglass: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        valuetable.putinarr(b, 8);
        valuetable.printarr();
        Console.WriteLine("Enter required time");
        int requiredTime = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        valuetable.putinarr(requiredTime, 14);
        valuetable.printarr();
        Console.WriteLine("     LETS'S GO");
        Thread.Sleep(100);
        str = "Are you ready? if Yes press any key, for exit press ESCAPE";
        printstring(str);
        Console.WriteLine();
        ConsoleKeyInfo strt;
        strt = Console.ReadKey();
        if (strt.Key == ConsoleKey.Escape)
        {
            Console.Clear();
            valuetable.printarr();
            Console.WriteLine("BYE");
            Environment.Exit(0);
        }

        Console.Clear();
        valuetable.printarr();
        Console.WriteLine("Let's go");
        Hourglass hourglass = new Hourglass();
        hourglass.firstglassval = a;
        hourglass.secondglassval = b;
        hourglass.requiredtime = requiredTime;
        hourglass.putinarr();
        hourglass.printarr();
        hourglass.run();

        

    }
}

