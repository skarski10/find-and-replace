using System;
using System.Collections.Generic;
using System.IO;

namespace FindAndReplaceApp.Objects
{
    public class FindAndReplace
    {
        private string _userString;
        private string _findWord;
        private string _replaceWord;

        public FindAndReplace(string newUserString, string newFindWord, string newReplaceWord)
        {
            _userString = newUserString;
            _findWord = newFindWord;
            _replaceWord = newReplaceWord;
        }

        public bool LocateFindWord()
        {
            if (_userString.Contains(_findWord))
            {
                return true;
            }
            return false;
        }

        public string ReplaceFindWord()
        {
            return "blah";
        }

        public string GetUserString()
        {
            return _userString;
        }
        public string GetFindWord()
        {
            return _findWord;
        }
        public string GetReplaceWord()
        {
            return _replaceWord;
        }

    }
}
