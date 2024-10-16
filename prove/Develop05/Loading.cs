using System;
public class Loading
{
    private int _time{get;set;}
    int counter;
    public Loading()
    {
        _time = 0;
        counter = 0;
    }
    public Loading(int time)
    {
        _time = time;
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
        counter++;
        switch (counter % 4)
        {
            case 0: Console.Write("5"); break;
            case 1: Console.Write("4"); break;
            case 2: Console.Write("3"); break;
            case 3: Console.Write("2"); break;
            case 4: Console.Write("1"); break;
            case 5: Console.Write("0"); break;
        }
        
    }
    
}