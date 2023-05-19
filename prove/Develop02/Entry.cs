using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop02
{
    public class Entry
    {
        public string _prompt;
        public DateTime _currentDate = DateTime.Now;
        public string _userEntry;
        public void AddEntry(Entry entry){
            Journal.entries.Add(entry);
        }

        
    }
}