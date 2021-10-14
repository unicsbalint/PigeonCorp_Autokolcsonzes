using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Exceptions
{
    class KeyDoesNotExistsException : Exception
    {
        public KeyDoesNotExistsException() : base("A megadott kulcs nem létezik.")
        {

        }
    }
}
