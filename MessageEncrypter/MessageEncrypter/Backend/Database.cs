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
            throw new NotImplementedException();
        }

        static private void checkKeyExist(string key)
        {
            throw new NotImplementedException();
        }

        //fájlba írás - olvasás
        static public string initializeDatabase(string filePath)
        {
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }

        static public void saveDatabase(string filePath, string output)
        {
            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(output);
            sw.Close();
        }
    }
}
