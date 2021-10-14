using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class ShiftHasIncorrectValueException : Exception
    {
        public ShiftHasIncorrectValueException() : base("A megadott eltolási érték túl esik az elfogadott tartományon.")
        {

        }
    }
}
