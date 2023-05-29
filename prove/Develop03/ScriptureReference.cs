using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Develop03
{
    public class ScriptureReference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int  _endVerse;

        public ScriptureReference(string book, int chapter, int startV)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startV;
        }
        public ScriptureReference(string book, int chapter, int startV, int endV)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startV;
            _endVerse = endV;
        }


        public string ReferenceFormated1()
        {
            return $"{_book} {_chapter} : {_startVerse}";
        }

         public string ReferenceFormated2()
        {
            return $"{_book} {_chapter} : {_startVerse} - {_endVerse}";
        }


    }
}