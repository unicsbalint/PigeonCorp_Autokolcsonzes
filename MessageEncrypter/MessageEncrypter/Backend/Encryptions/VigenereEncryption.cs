using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    static class VigenereEncryption
    {
        private static string[] characterMatrix;
        static VigenereEncryption()
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
        public static string Encrypt(string passwd, string input)
        {
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
        public static string Decrypt(string passwd, string input)
        {

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
    }
}
