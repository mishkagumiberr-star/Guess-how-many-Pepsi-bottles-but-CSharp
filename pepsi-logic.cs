using System;
using System.Threading;
namespace Pepsi;
class PepsiLogic
{
    Random random = new Random();
    public void Logic()
    {
        int number = random.Next(1, 100 + 1);
        while (true)
        {
            Console.Write("number?: ");
            if (!float.TryParse(Console.ReadLine(), out float guess))
            {
                Console.WriteLine("i think its not a number");
                continue;
            }
            if (number < guess)
            {
                Console.WriteLine("nah, thats a lot");
            }
            else if (number > guess)
            {
                Console.WriteLine("nah, thats not enough");
            }
            else if (number == guess)
            {
                Console.WriteLine($"good job, your number is {number}");
                Thread.Sleep(1500);
                Console.Clear();
                break;
            }
        }
    }
}            