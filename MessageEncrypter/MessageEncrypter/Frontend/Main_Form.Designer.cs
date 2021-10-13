
namespace MessageEncrypter
{
    partial class Main_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_azAZ09 = new System.Windows.Forms.Label();
            this.lbl_spec_chars = new System.Windows.Forms.Label();
            this.btn_settings_open = new System.Windows.Forms.Button();
            this.btn_file_choosing = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_filehelye = new System.Windows.Forms.Label();
            this.lbl_file_location = new System.Windows.Forms.Label();
            this.cb_encrypt = new System.Windows.Forms.CheckBox();
            this.cb_decrypt = new System.Windows.Forms.CheckBox();
            this.cb_read_from_file = new System.Windows.Forms.CheckBox();
            this.lbl_io_label = new System.Windows.Forms.Label();
            this.file_chosing = new System.Windows.Forms.OpenFileDialog();
            this.tb_IO = new System.Windows.Forms.TextBox();
            this.tb_keyIO = new System.Windows.Forms.MaskedTextBox();
            this.lbl_key = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_azAZ09
            // 
            this.lbl_azAZ09.AutoSize = true;
            this.lbl_azAZ09.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_azAZ09.Location = new System.Drawing.Point(660, 50);
            this.lbl_azAZ09.Name = "lbl_azAZ09";
            this.lbl_azAZ09.Size = new System.Drawing.Size(335, 40);
            this.lbl_azAZ09.TabIndex = 2;
            this.lbl_azAZ09.Text = "Megengedett betűk és számok:\nAngol ABC kis,-és nagybetűi, 0-9 ig számok";
            // 
            // lbl_spec_chars
            // 
            this.lbl_spec_chars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_spec_chars.Location = new System.Drawing.Point(660, 104);
            this.lbl_spec_chars.Name = "lbl_spec_chars";
            this.lbl_spec_chars.Size = new System.Drawing.Size(359, 64);
            this.lbl_spec_chars.TabIndex = 4;
            this.lbl_spec_chars.Text = "Speciális karakterek: .?!:_,;<>()[]{}+-*%/€$&@# (+szóköz)";
            // 
            // btn_settings_open
            // 
            this.btn_settings_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_settings_open.Location = new System.Drawing.Point(664, 221);
            this.btn_settings_open.Name = "btn_settings_open";
            this.btn_settings_open.Size = new System.Drawing.Size(238, 51);
            this.btn_settings_open.TabIndex = 2;
            this.btn_settings_open.Text = "Beállítások megnyitása";
            this.btn_settings_open.UseVisualStyleBackColor = true;
            this.btn_settings_open.Click += new System.EventHandler(this.btn_settings_open_Click);
            // 
            // btn_file_choosing
            // 
            this.btn_file_choosing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_file_choosing.Location = new System.Drawing.Point(664, 278);
            this.btn_file_choosing.Name = "btn_file_choosing";
            this.btn_file_choosing.Size = new System.Drawing.Size(238, 51);
            this.btn_file_choosing.TabIndex = 3;
            this.btn_file_choosing.Text = "Fájl kiválasztása";
            this.btn_file_choosing.UseVisualStyleBackColor = true;
            this.btn_file_choosing.Click += new System.EventHandler(this.btn_file_choosing_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_start.Location = new System.Drawing.Point(664, 537);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(238, 51);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Művelet indítása";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // lbl_filehelye
            // 
            this.lbl_filehelye.AutoSize = true;
            this.lbl_filehelye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_filehelye.Location = new System.Drawing.Point(660, 332);
            this.lbl_filehelye.Name = "lbl_filehelye";
            this.lbl_filehelye.Size = new System.Drawing.Size(151, 20);
            this.lbl_filehelye.TabIndex = 8;
            this.lbl_filehelye.Text = "Jelenlegi fájl helye:";
            this.lbl_filehelye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_file_location
            // 
            this.lbl_file_location.Location = new System.Drawing.Point(661, 352);
            this.lbl_file_location.Name = "lbl_file_location";
            this.lbl_file_location.Size = new System.Drawing.Size(358, 44);
            this.lbl_file_location.TabIndex = 9;
            this.lbl_file_location.Text = "nincs hely megadva";
            // 
            // cb_encrypt
            // 
            this.cb_encrypt.AutoSize = true;
            this.cb_encrypt.Checked = true;
            this.cb_encrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_encrypt.Location = new System.Drawing.Point(689, 489);
            this.cb_encrypt.Name = "cb_encrypt";
            this.cb_encrypt.Size = new System.Drawing.Size(172, 24);
            this.cb_encrypt.TabIndex = 7;
            this.cb_encrypt.Text = "Szöveg Titkosítása";
            this.cb_encrypt.UseVisualStyleBackColor = true;
            this.cb_encrypt.Click += new System.EventHandler(this.cb_encrypt_Click);
            // 
            // cb_decrypt
            // 
            this.cb_decrypt.AutoSize = true;
            this.cb_decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_decrypt.Location = new System.Drawing.Point(689, 399);
            this.cb_decrypt.Name = "cb_decrypt";
            this.cb_decrypt.Size = new System.Drawing.Size(192, 24);
            this.cb_decrypt.TabIndex = 4;
            this.cb_decrypt.Text = "Szöveg Visszafejtése";
            this.cb_decrypt.UseVisualStyleBackColor = true;
            this.cb_decrypt.Click += new System.EventHandler(this.cb_decrypt_Click);
            // 
            // cb_read_from_file
            // 
            this.cb_read_from_file.AutoSize = true;
            this.cb_read_from_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cb_read_from_file.Location = new System.Drawing.Point(689, 444);
            this.cb_read_from_file.Name = "cb_read_from_file";
            this.cb_read_from_file.Size = new System.Drawing.Size(206, 24);
            this.cb_read_from_file.TabIndex = 6;
            this.cb_read_from_file.Text = "Szöveg fájlból olvasása";
            this.cb_read_from_file.UseVisualStyleBackColor = true;
            // 
            // lbl_io_label
            // 
            this.lbl_io_label.AutoSize = true;
            this.lbl_io_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_io_label.Location = new System.Drawing.Point(12, 22);
            this.lbl_io_label.Name = "lbl_io_label";
            this.lbl_io_label.Size = new System.Drawing.Size(303, 25);
            this.lbl_io_label.TabIndex = 14;
            this.lbl_io_label.Text = "Szöveg beírása a művelethez:";
            // 
            // file_chosing
            // 
            this.file_chosing.FileName = "openFileDialog1";
            // 
            // tb_IO
            // 
            this.tb_IO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_IO.Location = new System.Drawing.Point(12, 50);
            this.tb_IO.Multiline = true;
            this.tb_IO.Name = "tb_IO";
            this.tb_IO.Size = new System.Drawing.Size(642, 538);
            this.tb_IO.TabIndex = 15;
            // 
            // tb_keyIO
            // 
            this.tb_keyIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_keyIO.Location = new System.Drawing.Point(664, 189);
            this.tb_keyIO.Name = "tb_keyIO";
            this.tb_keyIO.Size = new System.Drawing.Size(238, 26);
            this.tb_keyIO.TabIndex = 16;
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_key.Location = new System.Drawing.Point(660, 161);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(213, 20);
            this.lbl_key.TabIndex = 17;
            this.lbl_key.Text = "Kulcs ki és bemeneti helye:";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.tb_keyIO);
            this.Controls.Add(this.tb_IO);
            this.Controls.Add(this.lbl_io_label);
            this.Controls.Add(this.cb_read_from_file);
            this.Controls.Add(this.cb_decrypt);
            this.Controls.Add(this.cb_encrypt);
            this.Controls.Add(this.lbl_file_location);
            this.Controls.Add(this.lbl_filehelye);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_file_choosing);
            this.Controls.Add(this.btn_settings_open);
            this.Controls.Add(this.lbl_spec_chars);
            this.Controls.Add(this.lbl_azAZ09);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main_Form";
            this.Text = "Encrypt/Decript - Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_azAZ09;
        private System.Windows.Forms.Label lbl_spec_chars;
        private System.Windows.Forms.Button btn_settings_open;
        private System.Windows.Forms.Button btn_file_choosing;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_filehelye;
        private System.Windows.Forms.Label lbl_file_location;
        private System.Windows.Forms.CheckBox cb_encrypt;
        private System.Windows.Forms.CheckBox cb_decrypt;
        private System.Windows.Forms.CheckBox cb_read_from_file;
        private System.Windows.Forms.Label lbl_io_label;
        private System.Windows.Forms.OpenFileDialog file_chosing;
        private System.Windows.Forms.TextBox tb_IO;
        private System.Windows.Forms.MaskedTextBox tb_keyIO;
        private System.Windows.Forms.Label lbl_key;
    }
}

