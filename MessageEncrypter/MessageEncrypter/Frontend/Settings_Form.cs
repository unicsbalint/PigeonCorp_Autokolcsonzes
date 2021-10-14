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

namespace MessageEncrypter
{
    public partial class Settings_Form : Form
    {

        public Settings_Form(Main_Form Main)
        {
            InitializeComponent();
            this.Main = Main;
            InitializeControls();
        }

        public Main_Form Main { get; set; }
        public Settings_Form()
        {
            InitializeComponent();
        }
        private void SetDefaultEncryptionQueue()
        {
            //cbx_encrypt_queue_1.SelectedIndex = 0;
            //cbx_encrypt_queue_2.SelectedIndex = 0;
            //cbx_encrypt_queue_3.SelectedIndex = 0;
            //cbx_encrypt_queue_4.SelectedIndex = 0;
            cbx_encrypt_queue_5.SelectedIndex = 0;
        }

        private void InitializeControls()
        {
           
            SetDefaultEncryptionQueue();

            //if (Settings.GetEncryptionList().Count > 0)
            //{
            //    cbx_encrypt_queue_1.SelectedIndex = (int)Settings.GetEncryptionList()[0];
            //}
            //if (Settings.GetEncryptionList().Count > 1)
            //{
            //    cbx_encrypt_queue_2.SelectedIndex = (int)Settings.GetEncryptionList()[1];
            //}
            //if (Settings.GetEncryptionList().Count > 2)
            //{
            //    cbx_encrypt_queue_3.SelectedIndex = (int)Settings.GetEncryptionList()[2];
            //}
            //if (Settings.GetEncryptionList().Count > 3)
            //{
            //    cbx_encrypt_queue_4.SelectedIndex = (int)Settings.GetEncryptionList()[3];
            //}
            if (Settings.GetEncryptionList().Count == 1)
            {
                cbx_encrypt_queue_5.SelectedIndex = (int)Settings.GetEncryptionList()[0];
            }

            nud_caesar_shift.Value = Settings.Shift;
            tb_caesar_keyword.Text = Settings.Keyword;
            tb_vigenere_autoclave.Text = Settings.Password;
            nud_hill.Value = Settings.MatrixKey;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_save_changes_Click(object sender, EventArgs e)
        {
            try
            {
                Settings.SetEncryptionList(new EncryptionEnum[]
                {
                    //(EncryptionEnum)cbx_encrypt_queue_1.SelectedIndex,
                    //(EncryptionEnum)cbx_encrypt_queue_2.SelectedIndex,
                    //(EncryptionEnum)cbx_encrypt_queue_3.SelectedIndex,
                    //(EncryptionEnum)cbx_encrypt_queue_4.SelectedIndex,
                    (EncryptionEnum)cbx_encrypt_queue_5.SelectedIndex
                });

                Settings.Shift = (int)nud_caesar_shift.Value;
                Settings.Keyword = tb_caesar_keyword.Text;
                Settings.Password = tb_vigenere_autoclave.Text;
                Settings.MatrixKey = (int)nud_hill.Value;
                this.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            Settings.SaveSettings();

        }

        
    }
}
