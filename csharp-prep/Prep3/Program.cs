using System;

class Program
{
    static void Main(string[] args)
    {
        Random getmagicNumber = new Random();
        int magicNumber = getmagicNumber.Next(1,100);

        Console.WriteLine("Welcome to the Guessing number Game!");
        int number = -1;
        int count = 0;
        String continu = "yes";

        while (continu == "yes")
        {
            number = -1;
            count = 0;
            magicNumber = getmagicNumber.Next(1,100);

            while(number != magicNumber)
            {

                Console.Write("What is your guess? ");
                number = int.Parse(Console.ReadLine());

                if (number > magicNumber)
                {
                    Console.WriteLine("The number is Higher");            
                }
                
                if (number < magicNumber)
                {
                    Console.WriteLine("The number is Lower");            
                }
                
                else if (number == magicNumber)
                {
                    Console.WriteLine($"Well done the right number is {magicNumber}");
                }
                count++;
                // else
                // {
                //     Console.WriteLine($"Sorry you picked the wrong number! \n the right one was {magicNumber}");
                // }

                // Console.WriteLine("Hello Prep3 World!");

            }

            Console.WriteLine($"You did {count} guesses.");

            Console.WriteLine("Do you want to continu?");
            continu = Console.ReadLine().ToLower();

        }

       Console.WriteLine("Thank you!\nThe Game is Over!");

    }

}