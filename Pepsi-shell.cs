using System;
using System.Threading;
using System.IO;
namespace Pepsi;
class PepsiShell
{
     static void Main()
    {
        PepsiLogic pps1 = new PepsiLogic();
        Console.WriteLine(" ");
        Console.WriteLine("hello! its pepsi_4.1_reborn_butC#");
        Console.WriteLine(" "); 
        while (true) 
        { 
            Console.WriteLine("-menu-"); 
            Console.WriteLine("play"); 
            Console.WriteLine("change log"); 
            Console.WriteLine("github"); 
            Console.WriteLine("telegram"); 
            Console.WriteLine("opensource"); 
            Console.WriteLine("credit"); 
            Console.WriteLine("exit"); 
            Console.WriteLine(" "); 
            Console.Write("choose: "); 
            string? answer = Console.ReadLine()?.ToLower(); 
        if (answer == "play") 
        { 
            Console.Clear(); 
            Console.WriteLine("goodluck"); 
            pps1.Logic(); 
        } 
        else if (answer == "change log") 
        { 
            Console.Clear(); 
            Console.WriteLine("pepsi_3.5_reborn_butC#:"); 
            Console.WriteLine("pepsi_3.5_reborn_butC# was exit"); 
            Console.WriteLine("pepsi_3.9_reborn_butC#:"); 
            Console.WriteLine("add 'Console.Clear();' into code"); 
            Console.WriteLine("pepsi_3.9.2_reborn_butC#:"); 
            Console.WriteLine("bug fix"); 
            Console.WriteLine("pepsi_4.0_reborn_butC#:");
            Console.WriteLine("add 'System.IO'");
            Console.WriteLine("pepsi_4.1_reborn_butC#");
            Console.WriteLine("add TryParse");
            Console.WriteLine("add OOP");
            Console.WriteLine(" "); 
            Console.WriteLine("press any key"); 
            Console.ReadKey(); 
            Console.Clear();
        } 
        else if (answer == "github") 
        { 
            Console.Clear(); 
            Console.WriteLine("https://github.com/mishkagumiberr-star"); 
            Thread.Sleep(2000); 
            Console.Clear(); 
        } 
        else if (answer == "telegram") 
        { 
            Console.Clear(); 
            Console.WriteLine("t.me/peshera_treta"); 
            Thread.Sleep(2000); 
            Console.Clear(); 
        } 
        else if (answer == "credit") 
        { 
            Console.Clear(); 
            Console.WriteLine("game by - tret_game"); 
            Thread.Sleep(1500); 
            Console.Clear(); 
        } 
        else if (answer == "exit") 
        { 
            Console.WriteLine("goodbye"); 
            return; 
        } 
        //финя для того чтобы я мог иметь доступ к исходнику, зачем? доступ к исходнику на любом устройстве 
        else if (answer == "opensource") 
        { 
            string pepsi_reborn_opensorce = "pepsi_reborn_4.0CS.cs"; 
            if (File.Exists(pepsi_reborn_opensorce)) 
            { 
                Console.Clear(); 
                string source = File.ReadAllText(pepsi_reborn_opensorce); 
                Console.WriteLine(source); Console.ReadKey(); 
                Console.Clear(); 
            } 
            else 
            { 
                Console.Clear(); 
                Console.WriteLine("non"); 
                Thread.Sleep(1000); 
                Console.Clear(); 
            } 
        } 
        else 
        { 
            Console.WriteLine(" "); 
            Console.WriteLine("i dont know what you say"); 
            Console.WriteLine(" "); 
            Thread.Sleep(1000); 
            Console.Clear(); 
            } 
        } 
    }
}//дальше нет вкусности
