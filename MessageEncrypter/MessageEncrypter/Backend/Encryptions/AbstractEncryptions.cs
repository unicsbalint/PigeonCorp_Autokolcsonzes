using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    abstract class AbstractEncryptions : IEncryption
    {
        IEncryption encryptType;
        public IEncryption EncryptType 
        {
            get
            {
                return encryptType;
            }
            set 
            {
                encryptType = value;
            } 
        }
        public virtual string decryption(string messageToDecrypt)
        {
            if (encryptType != null)
            {
                return encryptType.decryption(messageToDecrypt);
            }
            return "";
        }

        public virtual string encryption(string messageToEncrypt)
        {
            if(encryptType != null)
            {
                return encryptType.encryption(messageToEncrypt);
            }
            return "";
        }
    }
}
