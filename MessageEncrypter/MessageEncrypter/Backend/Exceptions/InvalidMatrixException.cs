using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class InvalidMatrixException:Exception
    {
        public InvalidMatrixException():base("A megadott mátrix kulcs érték hibás!")
        {

        }
    }
}
