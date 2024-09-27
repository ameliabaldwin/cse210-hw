using System;
class Program
{
    static void Main(string[] args)
    {
        string newPrompts2 = "";
        string userNotes = "";
        int userInput2 = 1;
        while(userInput2 != 0)
        {   
            //gives options for tools in the journal
            Console.WriteLine("1.Write\r\n2.Display\r\n3.Load\r\n4.Save\r\n5.Quit");
            string userInput1 = Console.ReadLine();
            int userInput = int.Parse(userInput1);
            // takes userNotes and puts them into a list
            //so that they can be saved into a txt file
            if(userInput == 1)
            {
                newPrompts2 = Tools._promptGenerator();
                userNotes = Tools._read();
            }
            else if(userInput == 2)
            {
                Tools._display(userNotes, newPrompts2);
            }
            // Saves the list to a txt file
            else if(userInput == 4)
            {
                Tools._save(userNotes, newPrompts2);
            }
            // Quits the program
            else if(userInput == 5)
            {
                Console.WriteLine("Closing program...");
                userInput2 = 0;
            }
            // if user does not give a correct option number the program continues
            else
            {
                Console.WriteLine("Please use one of the options listed");
            }
        }

        
        
    }
    
}