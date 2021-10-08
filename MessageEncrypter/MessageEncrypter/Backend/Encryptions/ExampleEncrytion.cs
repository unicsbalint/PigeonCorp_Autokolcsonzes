using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    class ExampleEncrytion : IEncryption
    {
        public ExampleEncrytion() //paramétereket bekérni amik szükségesek a titkosításhoz pl.: kulcsszó
        {

        }

        //paraméterek eltárolása
        //például:
        private string kulcsszo;
        public string Kulcsszo { get; set; }

        public string encryption()
        {
            //ide jön a titkosítás
            return ""; //titkosított üzenet
        }

        //kidolgozni a lesz rá idő
        public string decryption(string message)
        {
            //Ide jön a fejtés
            return ""; //fejtett üzenet
        }
    }
}
