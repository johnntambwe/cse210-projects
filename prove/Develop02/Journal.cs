using System.Reflection.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Journal
    {
        public static List<Entry> entries = new List<Entry>(){};
        
        
        public static void DisplayEntry(){
            foreach(Entry entry in entries){
                Console.WriteLine($"{entry._currentDate} - {entry._prompt}");
                Console.WriteLine(entry._userEntry);
            }
           
        }
        public static void SaveJournal(string fileName)
        {
            using (StreamWriter saveJournal = new StreamWriter(fileName))
            {
                foreach(Entry entry in entries){
                    saveJournal.WriteLine($"{entry._currentDate} - {entry._prompt}");
                    saveJournal.WriteLine(entry._userEntry);
                }
            }

        }

        public static void LoadJournal(string fileName)
        {
            string [] lines = System.IO.File.ReadAllLines(fileName);
            foreach(string line in lines)
            {
                Console.WriteLine(line);
            }
        }
      
    }
    
}