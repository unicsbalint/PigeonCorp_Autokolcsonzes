using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MessageEncrypter.Backend;
using MessageEncrypter.Backend.Exceptions;

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
            throw new NotImplementedException();
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

        static public string initializeDatabase(string filePath)
        {
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

        static public void saveDatabase(string filePath)
        {
            StreamWriter sw = new StreamWriter(filePath);
            foreach (Message message in datas)
            {
                sw.WriteLine(message.ToString());
            }
            sw.Close();
        }
    }
}
