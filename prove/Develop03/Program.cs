using System;

class Program
{
    static void Main(string[] args)
    {
        Word w = new Word();
        string text = "And the waters returned from off the earth continually: and after the end of the hundred and fifty days the waters were abated.";
        w.SetText(text);
        string texts = w.GetDisplayText();

        
        Reference r = new Reference("Genesis", 8, 3);

        Scripture scrip = new Scripture(r, text);

        string response = "";
        while(response != "quit")
        {
            if (scrip.isCompletelyHidden())
            {
                Console.WriteLine($"{r.GetDisplayText()} {scrip.GetDisplayText()}");
                Console.WriteLine("You're done");
                break;
            }
            Console.WriteLine($"{r.GetDisplayText()} {scrip.GetDisplayText()}");
            scrip.HideRandomWords(3);
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
        }

    }
}