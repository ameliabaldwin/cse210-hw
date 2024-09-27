using System;

using System.IO;

public class Tools
{
    public static string _promptGenerator()
    {
        string[] prompts = "How was your day?:|What did you have for breakfast?:|What went well today?:|What went well today?:".Split('|');
        Random rnd = new Random();
        string newPrompts = prompts[rnd.Next(0, prompts.Length - 1)];
        Console.WriteLine(newPrompts);
        string newPrompts2 = newPrompts.ToString();
        return newPrompts2;
    }
    public static string _read()
    {
        Console.Write(">");
        string userNotes = Console.ReadLine();
        return userNotes;
    }
    public static void _save(string userNotes, string newPrompts2)
    {   
        //creates a journal list
        List<string> journal;
        journal = new List<string>();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        journal.Add($"Date: {dateText} - Prompt: {newPrompts2} \r\n{userNotes}");
        string journalNotes = string.Join(",", journal);

        Console.WriteLine("What is the filename?");
        string fileName = Console.ReadLine();
        
        using(StreamWriter outputFile = new StreamWriter(fileName))
        {    
            outputFile.WriteLine($"{journalNotes}");
            Console.WriteLine("program is working fine");
        }
    }
    
    public static void _display(string userNotes, string newPrompts2)
    {
        List<string> display;
        display = new List<string>();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        display.Add($"Date: {dateText} - Prompt: {newPrompts2} \r\n{userNotes}");
        string displayNotes = string.Join(",", display);
        Console.WriteLine($"{displayNotes}");
    }

}