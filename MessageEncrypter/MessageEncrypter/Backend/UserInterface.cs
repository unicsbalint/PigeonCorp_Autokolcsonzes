using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend
{
    class UserInterface : IUserInterface
    {
        public string encryption(string message, IEncryption encryptionMethod)
        {
            throw new NotImplementedException();
        }
        
        public void decryption(string message, string key, IEncryption encryptionMethod)
        {
            throw new NotImplementedException();
        }

        public void loadSettings()
        {
            throw new NotImplementedException();
        }

        public void saveSettings()
        {
            throw new NotImplementedException();
        }

        public void onProgramOpen()
        {
            throw new NotImplementedException();
        }

        public void onProgramClosed()
        {
            throw new NotImplementedException();
        }
    }
}
