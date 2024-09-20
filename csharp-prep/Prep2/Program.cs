using System;

class Program
{
    static void Main(string[] args)
    {
        int A = 90;
        int B = 80;
        int C = 70;
        int D = 60;

        string Letter = "";
        
        Console.Write("Please insert grade percentage here: ");
        string Graded = Console.ReadLine();
        int Grade = int.Parse(Graded);
        
        if(Grade >= A)
        {
            Letter = "A";
        }
        else if(Grade >= B)
        {
            Letter = "B";
        }
        else if(Grade >= C)
        {
            Letter = "C";
        }
        else if(Grade >= D)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine($"Your final grade is: {Letter}");
        
        if (Grade >= 70)
        {
            Console.WriteLine("Congrats you passed the class");
        }
        else
        {
            Console.WriteLine("Looks like you failed the class, better luck next year");
        }
        if (Grade < 0)
        {
            Console.WriteLine("Please insert a valid grade");
        }
    }
}