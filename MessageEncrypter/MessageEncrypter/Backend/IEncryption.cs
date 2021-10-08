using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend
{
    interface IEncryption
    {
        string encryption();

        void decryption(string message);
    }
}
