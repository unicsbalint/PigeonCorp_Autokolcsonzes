using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class InvalidMatrixException:Exception
    {
        public InvalidMatrixException():base("The given matrix key is invalid")
        {

        }
    }
}
