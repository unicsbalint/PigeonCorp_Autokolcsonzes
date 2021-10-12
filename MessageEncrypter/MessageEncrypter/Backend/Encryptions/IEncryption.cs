using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    interface IEncryption
    {
        string encryption(string messageToEncrypt);

        string decryption(string messageToDecrypt);
    }
}
