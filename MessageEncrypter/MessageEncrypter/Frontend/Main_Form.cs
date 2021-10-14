using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageEncrypter.Backend;
using MessageEncrypter.Backend.Encryptions;
using System.IO;

namespace MessageEncrypter
{
    public partial class Main_Form : Form
    {
        public static string path;
        public Main_Form()
        {
            InitializeComponent();
            Settings.ReadSettingsFile();
        }

        private void btn_settings_open_Click(object sender, EventArgs e)
        {
            Settings_Form settings_form = new Settings_Form(this);
            settings_form.ShowDialog();
        }

        private void btn_file_choosing_Click(object sender, EventArgs e)
        {
            file_chosing.ShowDialog();
            string pathOfFile = file_chosing.FileName.ToString();
            if (!(pathOfFile == "openFileDialog1"))
            {
                path = file_chosing.FileName;
                lbl_file_location.Text =path.ToString();
            }
        }

        private static string databasePath = "app.database";

        private void btn_start_Click(object sender, EventArgs e)
        {

            if (Settings.GetEncryptionList().Count == 0)
            {
                MessageBox.Show("Nincs kiválasztva titkosítás!");
                return;
            }

            IEncryption typeofencrypthion;

            switch (Settings.GetEncryptionList()[0])
            {
                case EncryptionEnum.Caesar:
                    typeofencrypthion = new Caesar();
                    break;
                case EncryptionEnum.KeywordCaesar:
                    typeofencrypthion = new KeyedCaesar();
                    break;
                case EncryptionEnum.Hill:
                    typeofencrypthion = new Hill();
                    break;
                case EncryptionEnum.Vigenere:
                    typeofencrypthion = new Vigenere();
                    break;
                case EncryptionEnum.Autoclave:
                    typeofencrypthion = new Autoclave();
                    break;
                default:
                    MessageBox.Show("Nincs kiválasztva titkosítás!");
                    return;
            }

            string Mainkey = tb_keyIO.Text;
            string input;

            if (cb_read_from_file.Checked)
            {
                if (!File.Exists(path))
                {
                    MessageBox.Show("Nem választott ki fájlt, vagy nem létezik az adott fájl!");
                    return;
                }
                StreamReader be = new StreamReader(path);
                input = be.ReadToEnd();
                {

                }
                be.Close();
            }
            else
            {
                input = tb_IO.Text;
            }
            string temp = input;
            input = "";
            foreach (char c in temp)
            {
                if (c == '\n' || c == '|')
                {
                    input += " ";
                }
                else if (c == '\r')
                {

                }
                else
                {
                    input += c;
                }
                
            }
            
            
            string output;
            Database.initializeDatabase(databasePath);

            if (cb_encrypt.Checked)
            {
                if (input.Length < 5)
                {
                    MessageBox.Show("A beolvasott szöveg túl kevés karaktert tartalmaz!\nLegalább 5 karakter hosszúnak kell lennie.");
                    return;
                }
                string key;
                do
                {
                    key = Database.generateNewKey();
                } while (Database.checkKeyExist(key));
                tb_keyIO.Text = key;
                Database.storeNewMessage(new Backend.Message(key, input, typeofencrypthion));
                Database.saveDatabase(databasePath);

                tb_IO.Text = "";
            }
            else
            {
                if (!Database.checkKeyExist(Mainkey))
                {
                    MessageBox.Show("Nem létezik a megadott kulccsal üzenet!");
                    return;
                }

                output = "";
                Backend.Message outputmsg = null;
                foreach (Backend.Message msg in Database.Datas)
                {
                    if (msg.Key == Mainkey)
                    {
                        outputmsg = msg;
                        break;
                    }
                }

                if (Settings.GetEncryptionList().Count == 0)
                {
                    MessageBox.Show("nem választott ki titkosítási módzsert!");
                    return;
                }

                bool found_right_encr = false;
                switch (Settings.GetEncryptionList()[0])
                {
                    case EncryptionEnum.Caesar:
                        if (outputmsg.Encryption is Caesar)
                        {
                            found_right_encr = true;
                            output = outputmsg.MessageText;
                        }
                        break;
                    case EncryptionEnum.KeywordCaesar:
                        if (outputmsg.Encryption is KeyedCaesar)
                        {
                            found_right_encr = true;
                            output = outputmsg.MessageText;
                        }
                        break;
                    case EncryptionEnum.Hill:
                        if (outputmsg.Encryption is Hill)
                        {
                            found_right_encr = true;
                            output = outputmsg.MessageText;
                        }
                        break;
                    case EncryptionEnum.Vigenere:
                        if (outputmsg.Encryption is Vigenere)
                        {
                            found_right_encr = true;
                            output = outputmsg.MessageText;
                        }
                        break;
                    case EncryptionEnum.Autoclave:
                        if (outputmsg.Encryption is Autoclave)
                        {
                            found_right_encr = true;
                            output = outputmsg.MessageText;
                        }
                        break;
                    default:
                        break;
                }
                if (!found_right_encr)
                {
                    tb_IO.Text = "";
                    MessageBox.Show("Nincs ilyen kulccsú bejegyzés!");
                    return;
                }
                tb_IO.Text = output;
            }

        }

        private void cb_decrypt_Click(object sender, EventArgs e)
        {
            if (cb_decrypt.Checked)
            {
                cb_encrypt.Checked = false;
            }
            else
            {
                cb_encrypt.Checked = true;
            }
            
        }

        private void cb_encrypt_Click(object sender, EventArgs e)
        {
            if (cb_encrypt.Checked)
            {
                cb_decrypt.Checked = false;
            }
            else
            {
                cb_decrypt.Checked = true;
            }

        }
    }
}
