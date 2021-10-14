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
                if (value > ALLOWED_CHARACTERS.Length - 1 || value < 1)
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
                if (value.Length < 5)
                {
                    throw new KeywordIsTooShortException();
                }
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

        private static int matrixKey;
        public static int MatrixKey
        {
            get
            {
                return matrixKey;
            }
            set
            {
                if (value < 0)
                {
                    throw new InvalidMatrixException();
                }
                matrixKey = value;
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
                if (value.Length < 5)
                {
                    throw new PasswordIsTooShortException();
                }
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
                                try
                                {
                                    Shift = value;
                                    isShiftSet = true;
                                }
                                catch (ShiftHasIncorrectValueException)
                                {
                                }
                            }
                            break;
                        case "keyword":
                            try
                            {
                                Keyword = dataAndValue[1];
                                isKeywordSet = true;
                            }
                            catch (KeywordHasDuplicateCharactersException)
                            {
                            }
                            catch (KeywordIsTooShortException)
                            {
                            }
                            break;
                        case "matrix":
                            int Mvalue;
                            if (int.TryParse(dataAndValue[1], out Mvalue))
                            {
                                if (Mvalue >= 1 && Mvalue <= 100)
                                {
                                    matrixKey = Mvalue;
                                    isMatrixSet = true;
                                }
                            }
                            break;
                        case "password":
                            try
                            {
                                Password = dataAndValue[1];
                                isPasswordSet = true;
                            }
                            catch (PasswordIsTooShortException)
                            { }
                            catch (InvalidPasswordException)
                            { }
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
                    matrixKey = 25;
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
            matrixKey = 25;
            Password = "Password";
        }
        public static void SaveSettings()
        {
            StreamWriter sw = new StreamWriter(SETTINGS_FILE);
            sw.WriteLine($"shift={shift}");
            sw.WriteLine($"keyword={keyword}");
            sw.WriteLine($"matrix={matrixKey}");
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
                        encList += "hill;";
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
                        encList += "hill";
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
