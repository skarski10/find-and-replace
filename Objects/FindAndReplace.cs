using System;
using System.Collections.Generic;
using System.IO;

namespace FindAndReplaceApp.Objects
{
    public class FindAndReplace
    {
        private string _userString;

        public FindAndReplace(string newUserString)
        {
            _userString = newUserString;
        }

        public string GetUserString()
        {
            return _userString;
        }

    }
}
