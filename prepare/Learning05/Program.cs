using System;

class Program
{
    static void Main(string[] args)
    {
        
        Assignment a = new Assignment("Amelia Baldwin", "C-Sharp");
        Console.WriteLine(a.GetSummary());

        MathAssignment ma = new MathAssignment("Section 10.6", "Problems 1-25", "Amelia Baldwin", "Algebra");
        Console.WriteLine(ma.GetSummary());
        Console.WriteLine(ma.GetHomeworkList());

        WritingAssignment wa = new WritingAssignment("The problem that parents have with stepping on legos", "Amelia Baldwin", "Lego");
        Console.WriteLine(wa.GetSummary());
        Console.WriteLine(wa.GetWritingInformation());
    }
}