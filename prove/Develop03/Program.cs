using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {

          
            Scripture obj1 = new Scripture();
            string user = " ";
            obj1.FormatAll();
            while(user != "quit"){
               
                user = Console.ReadLine();
                obj1.RemoveWord(obj1.GetText());
            }
            Console.WriteLine("Thank you for your time!");
           
            
            // Console.WriteLine("Hello Develop03 Hdden Word!");
                
            
        }
    }

}