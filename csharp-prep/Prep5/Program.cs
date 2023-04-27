using System;

class Program
{
    static void Main(string[] args)
    {
        //Calling all Functions
        DisplayWelecome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int userSquare = SquareNumber(userNumber);
        DisplayResult(userName, userSquare);

        //first function 
        static void DisplayWelecome(){
            Console.WriteLine("Welcomw to the program!");
        }

        // second function
        static string PromptUserName(){
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            return name;
        } 

        //third function
        static int PromptUserNumber(){
            Console.Write("What is your favorite number?: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        } 

        // forth function
        static int SquareNumber(int number){
            int square = number * number;
            return square;
        } 
        static void DisplayResult(string name, int square){
            Console.WriteLine($"{name}, the square of your number is {square}");
        }


    }
}