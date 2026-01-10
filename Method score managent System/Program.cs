using System;

public class Program
{
    public static void Main()
    {
        RunScoreSystem();
    }


    // just the commend of these
    public static void RunScoreSystem()
    {
        Console.WriteLine("=== Score Management System ===\n\n");

        Console.Write("Enter HTML score: ");
        double html = double.Parse(Console.ReadLine());

        Console.Write("Enter Java score: ");
        double java = double.Parse(Console.ReadLine());

        Console.Write("Enter C# score: ");
        double cSharp = double.Parse(Console.ReadLine());

        Console.Write("Enter PHP score: ");
        double php = double.Parse(Console.ReadLine());

        Console.Write("Enter SQL Server score: ");
        double sqlServer = double.Parse(Console.ReadLine());
        Console.Write("just the testing of the meaning of something ");

        double totalScore = html + java + cSharp + php + sqlServer;
        double average = totalScore / 5;

        // this is the method of the code 
        string grade;

        if (average < 0 || average > 100)
        {
            grade = "Invalide grade";
        }
        else if (average < 50)
        {
            grade = "F";
        }
        else if (average < 60)
        {
            grade = "E";
        }
        else if (average < 70)
        {
            grade = "D";
        }
        else if (average < 80)
        {
            grade = "C";
        }
        else if (average < 90)
        {
            grade = "B";
        }
        else
        {
            grade = "A";
        }

        Console.WriteLine("\n-------------------------------");
        Console.WriteLine($"Total Score: {totalScore}");
        Console.WriteLine($"Average Score: {average}%");
        Console.WriteLine($"Grade: {grade}");
        Console.WriteLine("-------------------------------");
    }
}