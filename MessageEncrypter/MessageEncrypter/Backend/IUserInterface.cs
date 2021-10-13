using MessageEncrypter.Backend.Encryptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend
{
    interface IUserInterface
    {
        string encryption(string message, IEncryption encryptionMethod);

        string decryption(string message, string key, IEncryption encryptionMethod);
        string decryption(string key, IEncryption encryptionMethod);

        void onProgramOpen();

        void onProgramClosed();
    }
}
