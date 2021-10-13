using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    class Vigenere : AbstractEncryptions
    {
        private static string[] characterMatrix;
        static Vigenere()
        {
            string charmap = Settings.ALLOWED_CHARACTERS;
            int d = charmap.Length;
            characterMatrix = new string[d];
            characterMatrix[0] = charmap;
            for (int i = 1; i < charmap.Length; i++)
            {
                characterMatrix[i] += charmap.Substring(i);
                characterMatrix[i] += charmap.Substring(0, i);
            }
        }
        public Vigenere()
        {
            this.passwd = Settings.Password;
            Type = EncryptionEnum.Vigenere;
        }

        private string passwd;

        public override string encryption(string messageToEncrypt)
        {
            if (messageToEncrypt == "" || messageToEncrypt == " ")
                return "";

            string input = base.encryption(messageToEncrypt);

            if (input == "")
            {
                input = messageToEncrypt;
            }

            string result = "";
            int currentPwdChar = 0;
            foreach (char icharacter in input)
            {
                char character;
                if (icharacter == '\r')
                {
                    character = '\n';
                }
                else
                {
                    character = icharacter;
                }
                int XIndex = characterMatrix[0].IndexOf(character);
                int YIndex = characterMatrix[0].IndexOf(passwd[currentPwdChar]);
                result += characterMatrix[YIndex][XIndex];
                if (++currentPwdChar == passwd.Length)
                {
                    currentPwdChar = 0;
                }
            }
            return result;
        }
        public override string decryption(string messageToDecrypt)
        {
            string input = messageToDecrypt;
            string result = "";
            int currentPwdChar = 0;
            foreach (char icharacter in input)
            {
                char character;
                if (icharacter == '\r')
                {
                    character = '\n';
                }
                else
                {
                    character = icharacter;
                }
                int YIndex = characterMatrix[0].IndexOf(passwd[currentPwdChar]);
                int XIndex = characterMatrix[YIndex].IndexOf(character);
                result += characterMatrix[0][XIndex];
                if (++currentPwdChar == passwd.Length)
                {
                    currentPwdChar = 0;
                }
            }
            return result;
        }

        public override string ToString()
        {
            string returnString = string.Format("{0}: {1}", Type, passwd);
            if (EncryptType != null)
            {
                returnString += ";" + EncryptType.ToString();
            }
            return returnString;
        }
    }
}
