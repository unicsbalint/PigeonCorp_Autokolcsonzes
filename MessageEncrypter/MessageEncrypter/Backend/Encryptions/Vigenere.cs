using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    class Vigenere : IEncryption
    {
        // mivel a karaktertábla ugyanaz marad program futtatása során, az Encrypt és
        // a Decrypt függvény is csak aktuális paraméterben változnak, érdemesebb static
        // osztállyal létrehozni a titkosításokat
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
            /*// karaktertábla tesztelés
            foreach (string sor in characterMatrix)
            {
                Console.WriteLine(sor);
            }//*/
        }
        public Vigenere()
        {
            this.passwd = Settings.Password;
        }
        private string passwd;
        public string encryption(string messageToEncrypt)
        {
            string input = messageToEncrypt;
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
        public string decryption(string messageToDecrypt)
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


    }
}
