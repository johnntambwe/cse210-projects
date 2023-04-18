using System.ComponentModel;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade? ");
        int grade = int.Parse(Console.ReadLine());
        String letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        // Display the result or the grade
        
        Console.WriteLine($"Your grade is {letter}");

        // verify if the student pass or not

        int isPass = 70;

        if (grade >= isPass)
        {
            Console.WriteLine("Congrats, You pass!");
        }
        else
        {
            Console.WriteLine("Sorry, work hard and try next time.");
        }
    }
}