using System;
public class Loading
{
    private int counter;
    public Loading()
    {
        counter = 0;
    }
    public void Sleep(int time)
    {
        System.Threading.Thread.Sleep(time);
    }
    public void Loadingdots()
    {
        counter++;
        switch (counter % 4)
        {
            case 0: Console.Write("/"); break;
            case 1: Console.Write("-"); break;
            case 2: Console.Write("\\"); break;
            case 3: Console.Write("|"); break;
        }
         Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
    }
    public void countdown()
    {
        for (int i = 5; i>0; i--)
        {
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write($"Beginning in...{i}");
            Sleep(2000);
        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Clear();
        Console.WriteLine("\n--Starting now!--");
        
    }
    public void menu(string newNames)
    {
        Console.WriteLine("--The Main Menus of Menu--\n");
        Sleep(200);
        Console.WriteLine("1. Breathing Activity: Will help you blow down your enemies\n");
        Sleep(200);
        Console.WriteLine("2. Reflection Activity: Will teach you how to use the reflection of the sun to burn holes through the earth\n");
        Sleep(200);
        Console.WriteLine("3. Listing Activity: Have too many girl or boy friends \nphone numbers then pick this one, it will help you list all of them\n");
        Sleep(200);
        Console.WriteLine("4. Quit: this quits and shuts down the program");
        Sleep(200);
        Console.WriteLine("**DISCLAIMER: WE CAN'T PROMISE THAT ANY OF THESE THINGS WILL ACTUALLY DO WHAT THEY SAY AND THEY MIGHT CAUSE IREVERSABLE DAMAGE TO YOUR FUNKY SOUL**\n");
        Sleep(200);
        Console.Write($"okay let's keep this train going, {newNames} pick one of these options...:");
    }
    
}