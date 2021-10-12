using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageEncrypter.Backend.Encryptions;

namespace MessageEncrypter
{
    class Autoclave : IEncryption
    {
        private static string[] characterMatrix;
        static Autoclave()
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
        public Autoclave()
        {
            this.passwd = Settings.Password;
        }
        private string passwd;
        public string encryption(string messageToEncrypt)
        {
            string input = messageToEncrypt;
            string result = "";
            int currentPwdChar = 0;
            int currentInputChar = 0;
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

                if (currentPwdChar < passwd.Length)
                {
                    int XIndex = characterMatrix[0].IndexOf(character);
                    int YIndex = characterMatrix[0].IndexOf(passwd[currentPwdChar]);
                    result += characterMatrix[YIndex][XIndex];
                    currentPwdChar++;
                }
                else
                {
                    int XIndex = characterMatrix[0].IndexOf(character);
                    int YIndex = characterMatrix[0].IndexOf(input[currentInputChar]);
                    result += characterMatrix[YIndex][XIndex];
                    currentInputChar++;
                }
            }
            return result;
        }
        public string decryption(string messageToDecrypt)
        {
            string input = messageToDecrypt;
            string result = "";
            int currentPwdChar = 0;
            int currentInputChar = 0;
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

                if (currentPwdChar < passwd.Length)
                {
                    int YIndex = characterMatrix[0].IndexOf(passwd[currentPwdChar]);
                    int XIndex = characterMatrix[YIndex].IndexOf(character);
                    result += characterMatrix[0][XIndex];
                    currentPwdChar++;
                }
                else
                {
                    int YIndex = characterMatrix[0].IndexOf(result[currentInputChar]);
                    int XIndex = characterMatrix[YIndex].IndexOf(character);
                    result += characterMatrix[0][XIndex];
                    currentInputChar++;
                }
            }
            return result;
        }
    }
}
