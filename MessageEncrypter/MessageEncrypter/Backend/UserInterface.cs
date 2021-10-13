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
        
        public string decryption(string message, string key, IEncryption encryptionMethod)
        {
            string messageToDecrypt = Database.getEncryptedMessageByKey(key);

            if (message != messageToDecrypt)
                throw new Exception("The message is not valid.");

            //string result = encryptionMethod.decryption(message);

            //átmeneti
            string result = Database.getOriginalMessageByKey(key);

            return result;
        }

        public string decryption(string key, IEncryption encryptionMethod)
        {
            string messageToDecrypt = Database.getEncryptedMessageByKey(key);

            //string result = encryptionMethod.decryption(messageToDecrypt);

            //átmeneti
            string result = Database.getOriginalMessageByKey(key);

            return result;
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
