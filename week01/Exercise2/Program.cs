using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int PercentageGrade = int.Parse(gradePercentage);

        string Letter = "";
        string sign = "";

        int remainder = PercentageGrade % 10;

        if (PercentageGrade >= 90)
        {
            Letter = "A";
        }
        else if (PercentageGrade >= 80)
        {
            Letter = "B";
        }
        else if (PercentageGrade >= 70)
        {
            Letter = "C";
        }
        else if (PercentageGrade >= 60)
        {
            Letter = "D";
        }
        else if (PercentageGrade < 60)
        {
            Letter = "F";
        }
        else
        {
            Console.WriteLine("You entered an invalid percentage grade");
        }

        if (remainder >= 7 && PercentageGrade < 90 && PercentageGrade >= 60)
        {
            sign = "+";
        }
        else if (remainder < 3 && PercentageGrade >= 60)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade letter is {Letter}{sign}.");

        if (PercentageGrade > 70)
        {
            Console.WriteLine("Congratulation, you passed the course!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the course; work harder next time");
        }
    }
}