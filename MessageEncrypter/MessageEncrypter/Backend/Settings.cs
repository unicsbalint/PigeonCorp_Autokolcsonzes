using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MessageEncrypter
{
    static class Settings
    {
        static Settings()
        {
            matrix = new int[2, 2];
        }
        public const string ALLOWED_CHARACTERS = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789\n\'\".?!:_,;<>()[]{}+-*%/€$&@# ";

        private static List<EncryptionEnum> encryptionList = new List<EncryptionEnum>();
        public static List<EncryptionEnum> GetEncryptionList()
        {
            return encryptionList;
        }
        public static void SetEncryptionList(List<EncryptionEnum> inputList)
        {
            encryptionList.Clear();
            foreach (EncryptionEnum listItem in inputList)
            {
                switch (listItem)
                {
                    case EncryptionEnum.None:
                        break;
                    case EncryptionEnum.Caesar:
                    case EncryptionEnum.KeywordCaesar:
                    case EncryptionEnum.Hill:
                    case EncryptionEnum.Vigenere:
                    case EncryptionEnum.Autoclave:
                        encryptionList.Add(listItem);
                        break;
                    default:
                        break;
                }
            }
        }
        public static void SetEncryptionList(EncryptionEnum[] inputArray)
        {
            encryptionList.Clear();
            foreach (EncryptionEnum listItem in inputArray)
            {
                switch (listItem)
                {
                    case EncryptionEnum.None:
                        break;
                    case EncryptionEnum.Caesar:
                    case EncryptionEnum.KeywordCaesar:
                    case EncryptionEnum.Hill:
                    case EncryptionEnum.Vigenere:
                    case EncryptionEnum.Autoclave:
                        encryptionList.Add(listItem);
                        break;
                    default:
                        break;
                }
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
                if (value > ALLOWED_CHARACTERS.Length / 2 || value < 0)
                {
                    throw new ShiftHasIncorrectValueException();
                }
                shift = value;
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
                if (value[0, 0] + value[1, 1] - value[1, 0] - value[0, 1] == 0)
                {
                    throw new MatrixHasNoInverseException();
                }
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

        private const string SETTINGS_FILE = "app.cfg";
        public static void ReadSettingsFile()
        {
            if (!File.Exists(SETTINGS_FILE))
            {
                SetDefaults();
                SaveSettings();
            }
            else
            {
                bool isKeywordSet = false;
                bool isShiftSet = false;
                bool isMatrixSet = false;
                bool isPasswordSet = false;
                StreamReader sr = new StreamReader(SETTINGS_FILE);
                while (!sr.EndOfStream)
                {
                    string[] dataAndValue = sr.ReadLine().Split('=');
                    switch (dataAndValue[0])
                    {
                        case "shift":
                            int value;
                            if (int.TryParse(dataAndValue[1], out value))
                            {
                                isShiftSet = true;
                                Shift = value;
                            }
                            break;
                        case "keyword":
                            isKeywordSet = true;
                            Keyword = dataAndValue[1];
                            break;
                        case "matrix":
                            string[] elements = dataAndValue[1].Split(';');
                            int[,] newMatrix = new int[2, 2];
                            try
                            {
                                newMatrix[0, 0] = int.Parse(elements[0]);
                                newMatrix[0, 1] = int.Parse(elements[1]);
                                newMatrix[1, 0] = int.Parse(elements[2]);
                                newMatrix[1, 1] = int.Parse(elements[3]);
                                isMatrixSet = true;
                            }
                            catch (FormatException)
                            {

                            }
                            finally
                            {
                            }
                            break;
                        case "password":
                            Password = dataAndValue[1];
                            break;
                        case "encryption_list":
                            string[] encryptions = dataAndValue[1].Split(';');
                            encryptionList.Clear();
                            foreach (string en in encryptions)
                            {
                                switch (en)
                                {
                                    case "caesar":
                                        encryptionList.Add(EncryptionEnum.Caesar);
                                        break;
                                    case "kwcaesar":
                                        encryptionList.Add(EncryptionEnum.KeywordCaesar);
                                        break;
                                    case "hill":
                                        encryptionList.Add(EncryptionEnum.Hill);
                                        break;
                                    case "vigenere":
                                        encryptionList.Add(EncryptionEnum.Vigenere);
                                        break;
                                    case "autoclave":
                                        encryptionList.Add(EncryptionEnum.Autoclave);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                sr.Close();
                if (!isKeywordSet)
                {
                    Keyword = "keyword";
                }
                if (!isShiftSet)
                {
                    Shift = 5;
                }
                if (!isMatrixSet)
                {
                    Matrix = new int[,]
                    {
                        { 10,15 },
                        { 5,25 }
                    };
                }
                if (!isPasswordSet)
                {
                    Password = "Password";
                }
            }
        }
        private static void SetDefaults()
        {
            Keyword = "Keyword";
            Shift = 5;
            Matrix = new int[,]
            {
                { 10,15 },
                { 5,25 }
            };
            Password = "Password";
        }
        public static void SaveSettings()
        {
            StreamWriter sw = new StreamWriter(SETTINGS_FILE);
            sw.WriteLine($"shift={shift}");
            sw.WriteLine($"keyword={keyword}");
            sw.WriteLine($"matrix={matrix[0, 0]};{matrix[0, 1]};{matrix[1, 0]};{matrix[1, 1]}");
            sw.WriteLine($"password={password}");
            string encList = "";
            for (int i = 0; i < encryptionList.Count - 1; i++)
            {
                switch (encryptionList[i])
                {
                    case EncryptionEnum.Caesar:
                        encList += "caesar;";
                        break;
                    case EncryptionEnum.KeywordCaesar:
                        encList += "kwcaesar;";
                        break;
                    case EncryptionEnum.Hill:
                        encList += "hillr;";
                        break;
                    case EncryptionEnum.Vigenere:
                        encList += "vigenere;";
                        break;
                    case EncryptionEnum.Autoclave:
                        encList += "autoclave;";
                        break;
                    default:
                        break;
                }
            }
            if (encryptionList.Count > 0)
            {
                switch (encryptionList.Last())
                {
                    case EncryptionEnum.Caesar:
                        encList += "caesar";
                        break;
                    case EncryptionEnum.KeywordCaesar:
                        encList += "kwcaesar";
                        break;
                    case EncryptionEnum.Hill:
                        encList += "hillr";
                        break;
                    case EncryptionEnum.Vigenere:
                        encList += "vigenere";
                        break;
                    case EncryptionEnum.Autoclave:
                        encList += "autoclave";
                        break;
                    default:
                        break;
                }
            }
            sw.WriteLine($"encryption_list={encList}");
            sw.Close();
        }

    }
}
