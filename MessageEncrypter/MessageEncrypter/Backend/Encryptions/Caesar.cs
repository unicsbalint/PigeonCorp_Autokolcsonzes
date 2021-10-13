using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    class Caesar : ACaesar
    {
        public Caesar()
        {
            this.ShiftBy = Settings.Shift;
            Type = EncryptionEnum.Caesar;
        }

        private int shiftBy;
        public int ShiftBy 
        {
            get
            {
                return shiftBy;
            }

            set
            {
                if (value > 25 || value < 1)
                    throw new Exception("You must choose a number between 1 and 25");
                //updateCharTable();
                shiftBy = value;
            }
        }

        protected override void updateCharTable()
        {
            List<char> keys = new List<char>(this.CharacterTable.Keys);
            for (int i = 0; i < CharacterTable.Count; i++)
            {
                int valueindex = (i + shiftBy) % CharacterTable.Count;
                CharacterTable[keys[i]] = keys[valueindex];
            }
        }

        public override string ToString()
        {
            string returnString = string.Format("{0}: {1}", Type, ShiftBy);
            if(EncryptType != null)
            {
                returnString += ";" + EncryptType.ToString();
            }
            return returnString;
        }
    }
}
