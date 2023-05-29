using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class Scripture
    {
        private ScriptureWord _word = new ScriptureWord("Verily I say unto you leave your home and serve me.");
        private ScriptureReference _reference = new ScriptureReference("1 Nephie", 4, 5);

        // private List<ScriptureWord> _words = new List<ScriptureWord>();
        // private List<ScriptureReference> _references = new List<ScriptureReference>();
        
        public string GetText()
        {
            return _word.GetWord();
        }
        public void FormatAll()
        {
            Console.WriteLine($"{_reference.ReferenceFormated1()} : {_word.GetWord()}");
        }

        public void RemoveWord(string texts){

            // foreach (char text in texts)
            // {
                // List<char> list1 = new List<char>();
                // list1.Add(text);
                string s1 = texts;
                string s2 = s1.Replace("you","_ _ _");
                Console.Write(s2);
                Console.WriteLine("");
            // }
            
        

        } 


    }

}