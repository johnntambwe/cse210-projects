using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class PromptGenerator
    {
        public static List<string> prompts = new List<string>(){
            "What did you do to day?",
            "What was your wonderful moment?",
            "What is the scripture you red?",
            "What did you eat today?"
        };
        
        public static string getPrompt()
        {
            Random generator = new Random();
            int generated = generator.Next(prompts.Count-1);
            return prompts[generated];
        }
        public static string getInput()
        {
            return Console.ReadLine(); 
        }


    }
}