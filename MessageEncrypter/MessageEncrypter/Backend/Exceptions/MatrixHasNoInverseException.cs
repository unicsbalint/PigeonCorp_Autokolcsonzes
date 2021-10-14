using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class MatrixHasNoInverseException : Exception
    {
        public MatrixHasNoInverseException() : base("A megadott mátrixnak nincs inverze")
        {

        }
    }
}
