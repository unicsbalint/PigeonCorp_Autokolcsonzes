using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MessageEncrypter.Backend;
using MessageEncrypter.Backend.Exceptions;
using MessageEncrypter.Backend.Encryptions;

namespace MessageEncrypter
{
    static class Database

    {
        private static List<Message> datas = new List<Message>();

        static Random rnd = new Random();

        internal static List<Message> Datas { get => datas; set => datas = value; }

        static public string getEncryptedMessageByKey(string key)
        {
            for (int i = 0; i < datas.Count; i++)
            {
                if (datas[i].Key == key)
                {
                    return datas[i].MessageText;
                }
            }
            throw new KeyDoesNotExistsException();
        }

        public static string getOriginalMessageByKey(string key)
        {
            for (int i = 0; i < datas.Count; i++)
            {
                if(datas[i].Key == key)
                {
                    return datas[i].OriginalText;
                }
            }
            throw new KeyDoesNotExistsException();
        }

        static public void storeNewMessage(Message message)
        {
            if (!checkKeyExist(message.Key))
            {
                datas.Add(message);
            }
            else 
                throw new Exception("Létezik ilyen kulcsú bejegyzés!");
        }

        static public string generateNewKey()
        {
            string characterMap = "aAbBcCdDeEfFgGhHiIjJkKlLmMnNoOpPqQrRsStTuUvVwWxXyYzZ0123456789";
            string newKey = "";
            for (int i = 0; i < 11; i++)
            {
                newKey += characterMap[rnd.Next(0, characterMap.Length)];
            }
            return newKey;
        }

        static public bool checkKeyExist(string key)
        {
            foreach (Message msg in datas)
            {
                if (msg.Key == key)
                {
                    return true;
                }
            }
            return false;
        }

        static public void initializeDatabase(string filePath)
        {
            if (!File.Exists(filePath))
            {
            }
            else
            {
                Datas.Clear();
                StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
                while (!sr.EndOfStream)
                {
                    string text = sr.ReadLine();
                    string[] adatok = text.Split('|');
                    IEncryption typeofencryption;
                    switch (adatok[2])
                    {
                        case "caesar":
                            typeofencryption = new Caesar();
                            break;
                        case "keyed_caesar":
                            typeofencryption = new KeyedCaesar();
                            break;
                        case "hill":
                            typeofencryption = new Hill();
                            break;
                        case "vigenere":
                            typeofencryption = new Vigenere();
                            break;
                        case "autoclave":
                            typeofencryption = new Autoclave();
                            break;
                        default: throw new Exception("Ismeretlen titkosítási forma");

                    }
                    Message ujuzenet = new Message(adatok[0], adatok[1], typeofencryption);
                    storeNewMessage(ujuzenet);
                }
                sr.Close();
                
            }
        }

        static public void saveDatabase(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);

            foreach (Message msg in Datas)
            {
                string line = msg.Key + "|";
                line += msg.MessageText + "|";

                if (msg.Encryption is Caesar)
                {
                    line += "caesar";
                }
                else if (msg.Encryption is KeyedCaesar)
                {
                    line += "keyed_caesar";
                }
                else if (msg.Encryption is Hill)
                {
                    line += "hill";
                }
                else if (msg.Encryption is Vigenere)
                {
                    line += "vigenere";
                }
                else if (msg.Encryption is Autoclave)
                {
                    line += "autoclave";
                }
                else
                {
                    line += "caesar";
                }
                sw.WriteLine(line);

            }
            sw.Close();
        }
    }
}
