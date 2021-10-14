using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class PasswordIsTooShortException : Exception
    {
        public PasswordIsTooShortException() : base("A megadott jelszó túl rövid.")
        {

        }
    }
}
