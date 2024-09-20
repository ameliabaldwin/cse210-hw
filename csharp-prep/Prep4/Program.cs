using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 1;
        List<int> numbers;
        numbers = new List<int>();
        while(userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        float average = ((float)total) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers.Max();
        Console.WriteLine($"The Largest Number is: {max}");
        

    }
}