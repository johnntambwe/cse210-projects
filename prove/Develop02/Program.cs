using System;

namespace Develop02{
    class Program
    {
        static void Main(string[] args)
        {
          int quit = 0; 

            while(quit != 5){
                Console.WriteLine("Welcome to the Journal Program! ");
                Console.WriteLine("Please select one of the following choices: ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Dispaly");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What would you like to do?");
                int option = int.Parse(Console.ReadLine());
    
                switch(option){
                    case 1:
                        Entry entry1 = new Entry();
                        entry1._prompt = PromptGenerator.getPrompt();
                        Console.WriteLine(entry1._prompt);
                        entry1._userEntry = PromptGenerator.getInput();
                        entry1.AddEntry(entry1);
                        break;
                    case 2:
                        Journal.DisplayEntry();
                        break;
                    case 3:
                        Console.WriteLine("Please Enter the name of the file you want to load");
                        string fileN = Console.ReadLine();
                        Journal.LoadJournal(fileN);;
                        break;
                    case 4:
                        Console.WriteLine("Please Enter the name of the file you want to save");
                        string file = Console.ReadLine();
                        Journal.SaveJournal(file);
                        break;
                    case 5:
                        Console.WriteLine("Thank you so much for your time !"+
                        "\n See you next time.");
                        quit = 5;
                        break;
                    default:
                        Console.WriteLine("Nothing");
                        break;
                }
            }
        }
    }

}