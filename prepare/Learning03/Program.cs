using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f = new Fraction();
        int quit = 0;
        string response = "";
        while(quit == 0)
        {
            Console.Write("What is the top number: ");
            int top = int.Parse(Console.ReadLine());

            Console.Write("What is the bottom number: ");
            int bottom = int.Parse(Console.ReadLine());

            f.SetTop(top);
            f.SetBottom(bottom);

            Console.WriteLine(f.GetFractionString());
            Console.WriteLine(f.GetDecimalValue());
            Console.Write("Want to continue(Yes or No): ");
            response = Console.ReadLine();
            if (response == "No")
            {
                quit = 1;
            }
            else
            {
                Console.WriteLine("Okie dokie, continuing the program...");
            }
        }
        
        
    }
}