using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine("hello, its pepsi_3.5_reborn_butC#");
        Console.WriteLine(" ");
        Console.WriteLine("---menu---");
        Console.WriteLine("play");
        Console.WriteLine("change log");
        Console.WriteLine("github");
        Console.WriteLine("credit");
        Console.WriteLine("exit");
        Console.Write("choise: ");
        string? answer = Console.ReadLine()?.ToLower();
        if (answer == "play")
        {
            int number = random.Next(1, 10);
            Console.WriteLine(" ");
            Console.WriteLine("goodluck!");
            while (true)
            {
               Console.WriteLine("number?: ");
               int guess = int.Parse(Console.ReadLine());
               if (guess < number)
               {
                    Console.WriteLine("nah, that's not enough");
               }
               else if (guess > number)
               {
                    Console.WriteLine("nah, that's a lot");
               }            
               else
               {
                   Console.WriteLine($"yeah, you win, correct number {number}"); 
                   Thread.Sleep(1000);
                   Console.WriteLine("see you in next game!");
                   Thread.Sleep(1500);
                   break;
               }
            }
        }
        else if (answer == "change log")
        {
            Console.WriteLine("pepsi_3.5_reborn_butC# change log:");
            Console.WriteLine("pepsi_3.5_reborn_butC# was exit");
        }
        else if (answer == "github")
        {
            Console.WriteLine("https://github.com/mishkagumiberr-star");
        }
        else if (answer == "credit")
        {
            Console.WriteLine("game by tret_game");
        }
        else if (answer == "exit")
        {
            Console.WriteLine("bye");
            Thread.Sleep(2000);
            return;
        }
    }
}