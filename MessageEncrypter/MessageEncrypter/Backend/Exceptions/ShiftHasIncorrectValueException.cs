using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class ShiftHasIncorrectValueException : Exception
    {
        public ShiftHasIncorrectValueException() : base("The given shift value is out of the allowed range.")
        {

        }
    }
}
