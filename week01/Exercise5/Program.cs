using System;

class Program
{
     static void Main(string[] args)
    {
        DisplayMessage();
        string userName = DisplayUserName();
        int numberSquared = NumberSquare();
        DisplayResult(userName, numberSquared);
    }
    static void DisplayMessage()
    {
        Console.WriteLine("You are welcome to the program!");
    }

    static string DisplayUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int NumberSquare()
    {
        Console.Write("Please eneter your favourite number: ");
        int number = int.Parse(Console.ReadLine());
        int numberSquared = number * number;

        return numberSquared;
    }

    static void DisplayResult(string name, int numberSquared)
    {
        Console.WriteLine($"{name}, the square of your favourite number is: {numberSquared}.");
    }
    
   
}