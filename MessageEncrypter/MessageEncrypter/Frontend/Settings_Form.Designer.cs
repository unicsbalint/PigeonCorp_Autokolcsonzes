
namespace MessageEncrypter
{
    partial class Settings_Form
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
            this.lbl_choose = new System.Windows.Forms.Label();
            this.lbl_caesar_shift = new System.Windows.Forms.Label();
            this.lbl_caesar_keyword = new System.Windows.Forms.Label();
            this.lbl_vigenere_autoclave = new System.Windows.Forms.Label();
            this.lbl_hill = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save_changes = new System.Windows.Forms.Button();
            this.nud_hill = new System.Windows.Forms.NumericUpDown();
            this.tb_vigenere_autoclave = new System.Windows.Forms.TextBox();
            this.tb_caesar_keyword = new System.Windows.Forms.TextBox();
            this.nud_caesar_shift = new System.Windows.Forms.NumericUpDown();
            this.cbx_encrypt_queue_5 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_hill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_caesar_shift)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_choose
            // 
            this.lbl_choose.AutoSize = true;
            this.lbl_choose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_choose.Location = new System.Drawing.Point(12, 9);
            this.lbl_choose.Name = "lbl_choose";
            this.lbl_choose.Size = new System.Drawing.Size(354, 25);
            this.lbl_choose.TabIndex = 6;
            this.lbl_choose.Text = "Válassza ki a titkosítási módszert(eket):";
            // 
            // lbl_caesar_shift
            // 
            this.lbl_caesar_shift.AutoSize = true;
            this.lbl_caesar_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_caesar_shift.Location = new System.Drawing.Point(14, 103);
            this.lbl_caesar_shift.Name = "lbl_caesar_shift";
            this.lbl_caesar_shift.Size = new System.Drawing.Size(348, 25);
            this.lbl_caesar_shift.TabIndex = 9;
            this.lbl_caesar_shift.Text = "Caesar-féle titkosítás - eltolás métréke:";
            // 
            // lbl_caesar_keyword
            // 
            this.lbl_caesar_keyword.AutoSize = true;
            this.lbl_caesar_keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_caesar_keyword.Location = new System.Drawing.Point(14, 147);
            this.lbl_caesar_keyword.Name = "lbl_caesar_keyword";
            this.lbl_caesar_keyword.Size = new System.Drawing.Size(405, 25);
            this.lbl_caesar_keyword.TabIndex = 10;
            this.lbl_caesar_keyword.Text = "Caesar-féle kulcsszavas titkosítás - kulcsszó:";
            // 
            // lbl_vigenere_autoclave
            // 
            this.lbl_vigenere_autoclave.AutoSize = true;
            this.lbl_vigenere_autoclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_vigenere_autoclave.Location = new System.Drawing.Point(14, 194);
            this.lbl_vigenere_autoclave.Name = "lbl_vigenere_autoclave";
            this.lbl_vigenere_autoclave.Size = new System.Drawing.Size(347, 25);
            this.lbl_vigenere_autoclave.TabIndex = 12;
            this.lbl_vigenere_autoclave.Text = "Vigenére / Autoclave titkosítás - jelszó:";
            // 
            // lbl_hill
            // 
            this.lbl_hill.AutoSize = true;
            this.lbl_hill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_hill.Location = new System.Drawing.Point(14, 241);
            this.lbl_hill.Name = "lbl_hill";
            this.lbl_hill.Size = new System.Drawing.Size(224, 25);
            this.lbl_hill.TabIndex = 14;
            this.lbl_hill.Text = "Hill-féle titkosítás - kulcs:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_cancel.Location = new System.Drawing.Point(12, 300);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(196, 82);
            this.btn_cancel.TabIndex = 13;
            this.btn_cancel.Text = "Mégse";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save_changes
            // 
            this.btn_save_changes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_save_changes.Location = new System.Drawing.Point(430, 300);
            this.btn_save_changes.Name = "btn_save_changes";
            this.btn_save_changes.Size = new System.Drawing.Size(196, 82);
            this.btn_save_changes.TabIndex = 14;
            this.btn_save_changes.Text = "Beállítások mentése";
            this.btn_save_changes.UseVisualStyleBackColor = true;
            this.btn_save_changes.Click += new System.EventHandler(this.btn_save_changes_Click);
            // 
            // nud_hill
            // 
            this.nud_hill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_hill.Location = new System.Drawing.Point(470, 243);
            this.nud_hill.Name = "nud_hill";
            this.nud_hill.Size = new System.Drawing.Size(156, 26);
            this.nud_hill.TabIndex = 12;
            // 
            // tb_vigenere_autoclave
            // 
            this.tb_vigenere_autoclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_vigenere_autoclave.Location = new System.Drawing.Point(470, 193);
            this.tb_vigenere_autoclave.Name = "tb_vigenere_autoclave";
            this.tb_vigenere_autoclave.Size = new System.Drawing.Size(156, 26);
            this.tb_vigenere_autoclave.TabIndex = 8;
            // 
            // tb_caesar_keyword
            // 
            this.tb_caesar_keyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tb_caesar_keyword.Location = new System.Drawing.Point(470, 148);
            this.tb_caesar_keyword.Name = "tb_caesar_keyword";
            this.tb_caesar_keyword.Size = new System.Drawing.Size(156, 26);
            this.tb_caesar_keyword.TabIndex = 7;
            // 
            // nud_caesar_shift
            // 
            this.nud_caesar_shift.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nud_caesar_shift.Location = new System.Drawing.Point(470, 102);
            this.nud_caesar_shift.Name = "nud_caesar_shift";
            this.nud_caesar_shift.Size = new System.Drawing.Size(156, 26);
            this.nud_caesar_shift.TabIndex = 6;
            // 
            // cbx_encrypt_queue_5
            // 
            this.cbx_encrypt_queue_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_encrypt_queue_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_encrypt_queue_5.FormattingEnabled = true;
            this.cbx_encrypt_queue_5.Items.AddRange(new object[] {
            "None",
            "Caesar",
            "Keyword-Caesar",
            "Hill",
            "Vigenere",
            "Autoclave"});
            this.cbx_encrypt_queue_5.Location = new System.Drawing.Point(12, 49);
            this.cbx_encrypt_queue_5.Name = "cbx_encrypt_queue_5";
            this.cbx_encrypt_queue_5.Size = new System.Drawing.Size(614, 33);
            this.cbx_encrypt_queue_5.TabIndex = 5;
            // 
            // Settings_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(639, 412);
            this.Controls.Add(this.tb_vigenere_autoclave);
            this.Controls.Add(this.tb_caesar_keyword);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save_changes);
            this.Controls.Add(this.nud_hill);
            this.Controls.Add(this.lbl_hill);
            this.Controls.Add(this.lbl_vigenere_autoclave);
            this.Controls.Add(this.lbl_caesar_keyword);
            this.Controls.Add(this.lbl_caesar_shift);
            this.Controls.Add(this.nud_caesar_shift);
            this.Controls.Add(this.lbl_choose);
            this.Controls.Add(this.cbx_encrypt_queue_5);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Settings_Form";
            this.Text = "Encrypt/Decript - Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nud_hill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_caesar_shift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_choose;
        private System.Windows.Forms.Label lbl_caesar_shift;
        private System.Windows.Forms.Label lbl_caesar_keyword;
        private System.Windows.Forms.Label lbl_vigenere_autoclave;
        private System.Windows.Forms.Label lbl_hill;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save_changes;
        private System.Windows.Forms.NumericUpDown nud_hill;
        private System.Windows.Forms.TextBox tb_vigenere_autoclave;
        private System.Windows.Forms.TextBox tb_caesar_keyword;
        private System.Windows.Forms.NumericUpDown nud_caesar_shift;
        private System.Windows.Forms.ComboBox cbx_encrypt_queue_5;
    }
}