using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    static class Settings
    {
        // egy osztályba ki van gyűjtve az összes beállítás, és a beállítások kezelésével foglalkozó metódusok
        // ajánlott, hogy minden titksoítási módszer innen kérje a paramétereit
        static Settings()
        {
            matrix = new int[2, 2];
        }
        // egységesen el lehet érni az elfogadott karaktereket, így a titkosításoknak nem kell külön ezt lementeni
        public const string ALLOWED_CHARACTERS = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789#\n\'\".?!:_,;<>()[]{}+-*%/€$&@# ";

        private static bool isCaesarChecked;
        public static bool IsCaesarChecked
        {
            get
            {
                return isCaesarChecked;
            }
            set
            {
                isCaesarChecked = value;
            }
        }
        private static int shift;
        public static int Shift
        {
            get
            {
                return shift;
            }
            set
            {
                if (value > ALLOWED_CHARACTERS.Length || value < 0)
                {
                    throw new ShiftHasIncorrectValueException();
                }
                shift = value;
            }
        }

        private static bool isKWCaesarChecked;
        public static bool IsKWCaesarChecked
        {
            get
            {
                return isKWCaesarChecked;
            }
            set
            {
                isKWCaesarChecked = value;
            }
        }
        private static string keyword;
        public static string Keyword
        {
            get
            {
                return keyword;
            }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!ALLOWED_CHARACTERS.Contains(value[i]))
                    {
                        throw new KeywordHasDuplicateCharactersException();
                    }
                    for (int j = 0; j < value.Length; j++)
                    {
                        if (i != j && value[i] == value[j])
                        {
                            throw new KeywordHasDuplicateCharactersException();
                        }
                    }
                }
                keyword = value;
            }
        }

        private static bool isHillChecked;
        public static bool IsHillChecked
        {
            get { return isHillChecked; }
            set { isHillChecked = value; }
        }
        private static int[,] matrix;
        public static int[,] Matrix
        {
            get
            {
                return matrix;
            }
            set
            {
                if (value.GetLength(0) != 2 || value.GetLength(1) != 2)
                {
                    throw new InvalidMatrixException();
                }
                if (value[0,0] + value[1,1] - value[0,1] - value[1,0] == 0)
                {
                    throw new MatrixHasNoInverseException();
                }
            }
        }

        private static bool isVigenereChecked;
        public static bool IsVigenereChecked
        {
            get
            {
                return isVigenereChecked;
            }
            set
            {
                isVigenereChecked = value;
            }
        }

        private static string password;
        public static string Password
        {
            get
            {
                return password;
            }
            set
            {
                foreach (char c in value)
                {
                    if (!ALLOWED_CHARACTERS.Contains(c))
                    {
                        throw new InvalidPasswordException();
                    }
                }
                password = value;
            }
        }

        private static bool isAutoclaveChecked;
        public static bool IsAutoclaveChecked
        {
            get
            {
                return isAutoclaveChecked;
            }
            set
            {
                isAutoclaveChecked = value;
            }
        }

        public static void ReadSettingsFile()
        {
            throw new NotImplementedException();
        }
        public static void SaveSettings()
        {
            throw new NotImplementedException();
        }

    }
}
