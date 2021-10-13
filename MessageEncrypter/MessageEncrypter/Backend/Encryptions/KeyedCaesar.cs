using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageEncrypter.Backend.Encryptions
{
    class KeyedCaesar : ACaesar
    {
        public KeyedCaesar()
        {
            this.ShiftBy = Settings.Keyword;
            Type = EncryptionEnum.KeywordCaesar;
        }

        private string shiftBy;
        public string ShiftBy
        {
            get
            {
                return shiftBy;
            }
            set
            {
                value.ToLower();
                if (value.Length < 4)
                {
                    throw new Exception("The key must be at least 4 characters long.");
                }
                for (int i = 0; i < value.Length - 1; i++)
                {
                    for(int j = 0; j < value.Length; j++)
                    {
                        if (i != j && value[i] == value[j])
                            throw new Exception("All of the characters must be different from each other");
                    }
                }
               // updateCharTable();
                shiftBy = value;
            }
        }

        protected override void updateCharTable()
        {
            List<char> keys = new List<char>(this.CharacterTable.Keys);
            List<char> remainingKeys = new List<char>(this.CharacterTable.Keys);
            for (int i = 0; i < shiftBy.Length; i++)
            {
                remainingKeys.Remove(shiftBy[i]);
                CharacterTable[keys[i]] = shiftBy[i];
            }
            for(int i = shiftBy.Length; i < CharacterTable.Count; i++ )
            {
                CharacterTable[keys[i]] = remainingKeys[i - shiftBy.Length];
            }
        }

        public override string ToString()
        {
            string returnString = string.Format("{0}: {1}", Type, ShiftBy);
            if (EncryptType != null)
            {
                returnString += ";" + EncryptType.ToString();
            }
            return returnString;
        }
    }
}
