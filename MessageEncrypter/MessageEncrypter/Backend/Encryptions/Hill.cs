using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageEncrypter.Backend.Encryptions;

namespace MessageEncrypter.Backend.Encryptions
{
    class Hill : AbstractEncryptions
    {
        static string charmap = Settings.ALLOWED_CHARACTERS;
        public Hill()
        {
            //matrixKey = Settings.matrixKey;
        }
        private int matrixKey;
        public override string encryption(string messageToEncryption)
        {
            string input = messageToEncryption;
            int[,] keyMatrix = new int[,]
            {
                {1, matrixKey },
                {1, matrixKey + 1 }
            };
            string result = "";
            if (input.Length % 2 == 1)
            {
                input += " ";
            }
            for (int i = 0; i < input.Length; i += 2)
            {
                int char1 = charmap.IndexOf(input[i]);
                int char2 = charmap.IndexOf(input[i + 1]);
                double newChar1 = (keyMatrix[0, 0] * char1 + keyMatrix[0, 1] * char2);
                double newChar2 = (keyMatrix[1, 0] * char1 + keyMatrix[1, 1] * char2);
                newChar1 %= charmap.Length;
                newChar2 %= charmap.Length;
                result += charmap[(int)newChar1].ToString() + charmap[(int)newChar2].ToString();
            }
            return result;
        }
        public override string decryption(string messageToDecryption)
        {
            string input = messageToDecryption;
            int[,] Matrix = new int[,]
            {
                {1, matrixKey },
                {1, matrixKey + 1 }
            };
            string result = "";
            int determinant;
            double[,] iMatrix = inverse(Matrix, out determinant);
            for (int i = 0; i < input.Length; i += 2)
            {
                int char1 = charmap.IndexOf(input[i]);
                int char2 = charmap.IndexOf(input[i + 1]);
                int newChar1 = (int)(iMatrix[0, 0] * char1 + iMatrix[0, 1] * char2) % charmap.Length;
                int newChar2 = (int)(iMatrix[1, 0] * char1 + iMatrix[1, 1] * char2) % charmap.Length;
                if (newChar1 < 0)
                {
                    newChar1 += charmap.Length;
                }
                if (newChar2 < 0)
                {
                    newChar2 += charmap.Length;
                }
                result += charmap[newChar1].ToString() + charmap[newChar2].ToString();
            }
            return result;
        }
        private double[,] inverse(int[,] matrix, out int determinant)
        {
            double[,] result = new double[2, 2];
            determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            result[0, 0] = matrix[1, 1] / determinant;
            result[0, 1] = -matrix[0, 1] / determinant;
            result[1, 0] = -matrix[1, 0] / determinant;
            result[1, 1] = matrix[0, 0] / determinant;
            return result;
        }
    }
}
