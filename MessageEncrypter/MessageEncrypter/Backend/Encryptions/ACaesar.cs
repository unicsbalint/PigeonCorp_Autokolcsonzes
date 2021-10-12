using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    abstract class ACaesar : AbstractEncryptions
    {
        Dictionary<char, char> characterTable = new Dictionary<char, char>()
        {
            { 'a', 'a' },{ 'b', 'b' },{ 'c', 'c' },{ 'd', 'd' },{ 'e', 'e' },
            { 'f', 'f' },{ 'g', 'g' },{ 'h', 'h' },{ 'i', 'i' },{ 'j', 'j' },
            { 'k', 'k' },{ 'l', 'l' },{ 'm', 'm' },{ 'n', 'n' },{ 'o', 'o' },
            { 'p', 'p' },{ 'q', 'q' },{ 'r', 'r' },{ 's', 's' },{ 't', 't' },
            { 'u', 'u' },{ 'v', 'v' },{ 'w', 'w' },{ 'x', 'x' },{ 'y', 'y' },
            { 'z', 'z' }
        };

        public Dictionary<char, char> CharacterTable { get; set; }

        protected abstract void updateCharTable();

        public override string encryption(string messageToEncrypt)
        {
            if (messageToEncrypt == "" || messageToEncrypt == " ")
                return "";

            string message = base.encryption(messageToEncrypt);

            if (message == "")
            {
                message = messageToEncrypt;
            }

            string returnMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                bool isLowerCase = (message[i] == Char.ToLower(message[i]));
                char returnChar = characterTable[Char.ToLower(message[i])];

                if (!isLowerCase)
                    returnChar = Char.ToUpper(returnChar);

                returnMessage += returnChar;
            }

            return returnMessage;
        }

        public override string decryption(string messageToDecrypt)
        {
            throw new NotImplementedException();
        }
    }
}
