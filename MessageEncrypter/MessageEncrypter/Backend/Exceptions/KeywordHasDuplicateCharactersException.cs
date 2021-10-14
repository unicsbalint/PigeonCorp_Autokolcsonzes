using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class KeywordHasDuplicateCharactersException : Exception
    {
        public KeywordHasDuplicateCharactersException() : base("A megadott kulcsszó duplikált karaktereket tartalmaz.")
        {

        }
    }
}
