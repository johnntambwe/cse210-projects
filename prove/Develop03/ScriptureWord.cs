using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class ScriptureWord
    {
        private string _word;
        public ScriptureWord(string text)
        {
            _word = text;
        }

        public string GetWord()
        {
            return _word;
        }


    }
}