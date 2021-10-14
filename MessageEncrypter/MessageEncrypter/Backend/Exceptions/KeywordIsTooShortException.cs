using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class KeywordIsTooShortException : Exception
    {
        public KeywordIsTooShortException() : base("A megadott kulcsszó túl rövid.")
        {

        }
    }
}
