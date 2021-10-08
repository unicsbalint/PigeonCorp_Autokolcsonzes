using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend
{
    static class Database
    {
        private static List<Message> datas = new List<Message>();
        internal static List<Message> Datas { get => datas; set => datas = value; }

        static public string getMessageByKey(string key)
        {
            throw new NotImplementedException();
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
        static public void initializeDatabase()
        {
            throw new NotImplementedException();
        }

        static public void saveDatabase()
        {
            throw new NotImplementedException();
        }
    }
}
