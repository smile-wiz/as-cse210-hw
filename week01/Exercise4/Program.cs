using System.Collections.Generic;
using System;

class Program
{
    static void Main(string[] args)
    {
      List<int> numbers = new List<int>();

      int userNumber = -2;

      while (userNumber != 0)
      {
        Console.Write("enter a number (enter 0 to quit): ");

        userNumber = int.Parse(Console.ReadLine());

        if (userNumber != 0)
        {
            numbers.Add(userNumber);
        }

      } 
      
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers is: {sum}");

        float average = 0;
        if (numbers.Count > 0)
        {
            average = sum / numbers.Count;
        }
        else
        {
            Console.WriteLine("The list is empty.");
        }
        Console.WriteLine($"Average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (max < number)
            {
                max = number;
            }
        }
        Console.WriteLine($"The highest number is: {max}");
    }
}