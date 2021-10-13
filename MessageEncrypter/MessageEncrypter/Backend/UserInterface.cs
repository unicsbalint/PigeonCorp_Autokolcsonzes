using MessageEncrypter.Backend.Encryptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend
{
    class UserInterface : IUserInterface
    {
        public string encryption(string messageToEncrypt, IEncryption encryptionMethod)
        {
            string result = encryptionMethod.encryption(messageToEncrypt);

            Message message = new Message(Database.generateNewKey(), result, encryptionMethod);

            //átmeneti
            message.OriginalText = messageToEncrypt;

            Database.storeNewMessage(message);

            return result;
        }
        
        public void decryption(string message, string key, IEncryption encryptionMethod)
        {
            throw new NotImplementedException();
        }

        public void decryption(string key, IEncryption encryptionMethod)
        {
            string messageToDecrypt = Database.getMessageByKey(key);
            
        }

        public void onProgramOpen()
        {
            throw new NotImplementedException();
        }

        public void onProgramClosed()
        {
            throw new NotImplementedException();
        }
    }
}
