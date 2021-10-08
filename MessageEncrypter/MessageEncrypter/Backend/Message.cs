using MessageEncrypter.Backend.Encryptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend
{
    class Message
    {
        public Message(string messageText, IEncryption encryption)
        {
            this.MessageText = messageText;
            this.Encryption = encryption;
        }

        public Message(string key, string messageText, IEncryption encryption)
            :this(messageText, encryption)
        {
            this.Key = key;
        }

        private string messageText;
        private string key;
        private IEncryption encryption;

        public string MessageText { get => messageText; set => messageText = value; }
        public string Key { get => key; set => key = value; }
        internal IEncryption Encryption { get => encryption; set => encryption = value; }

        //override toString();
    }
}
