﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter
{
    class InvalidPasswordException:Exception
    {
        public InvalidPasswordException():base("A jelszó tartalmaz nem elfogadott karalktert.")
        {

        }
    }
}
