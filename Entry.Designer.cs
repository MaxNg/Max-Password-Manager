
namespace Password_Manager
{
    partial class Entry
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnGeneratePassword = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSaveNClose = new System.Windows.Forms.Button();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxWebsite = new System.Windows.Forms.TextBox();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.rTxtBoxNotes = new System.Windows.Forms.RichTextBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblPasswordLength = new System.Windows.Forms.Label();
            this.lblSymbols = new System.Windows.Forms.Label();
            this.lblDigits = new System.Windows.Forms.Label();
            this.txtBoxPasswordLength = new System.Windows.Forms.TextBox();
            this.txtBoxSymbols = new System.Windows.Forms.TextBox();
            this.txtBoxDigits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(71, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.Location = new System.Drawing.Point(61, 67);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(52, 15);
            this.lblWebsite.TabIndex = 1;
            this.lblWebsite.Text = "Website:";
            this.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(45, 105);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 15);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "User Name:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(84, 15);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email Address:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(53, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(60, 15);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGeneratePassword
            // 
            this.btnGeneratePassword.Location = new System.Drawing.Point(557, 142);
            this.btnGeneratePassword.Name = "btnGeneratePassword";
            this.btnGeneratePassword.Size = new System.Drawing.Size(151, 23);
            this.btnGeneratePassword.TabIndex = 5;
            this.btnGeneratePassword.Text = "Generate Password";
            this.btnGeneratePassword.UseVisualStyleBackColor = true;
            this.btnGeneratePassword.Click += new System.EventHandler(this.btnGeneratePassword_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Location = new System.Drawing.Point(72, 257);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(41, 15);
            this.lblNotes.TabIndex = 6;
            this.lblNotes.Text = "Notes:";
            this.lblNotes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(55, 219);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(58, 15);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(593, 271);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSaveNClose
            // 
            this.btnSaveNClose.Location = new System.Drawing.Point(572, 310);
            this.btnSaveNClose.Name = "btnSaveNClose";
            this.btnSaveNClose.Size = new System.Drawing.Size(117, 23);
            this.btnSaveNClose.TabIndex = 9;
            this.btnSaveNClose.Text = "Save and Close";
            this.btnSaveNClose.UseVisualStyleBackColor = true;
            this.btnSaveNClose.Click += new System.EventHandler(this.btnSaveNClose_Click);
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(114, 28);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(176, 23);
            this.txtBoxName.TabIndex = 1;
            // 
            // txtBoxWebsite
            // 
            this.txtBoxWebsite.Location = new System.Drawing.Point(114, 66);
            this.txtBoxWebsite.Name = "txtBoxWebsite";
            this.txtBoxWebsite.Size = new System.Drawing.Size(176, 23);
            this.txtBoxWebsite.TabIndex = 2;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(114, 104);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(176, 23);
            this.txtBoxUsername.TabIndex = 3;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(114, 142);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(176, 23);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(114, 180);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.Size = new System.Drawing.Size(176, 23);
            this.txtBoxPassword.TabIndex = 5;
            // 
            // rTxtBoxNotes
            // 
            this.rTxtBoxNotes.Location = new System.Drawing.Point(114, 256);
            this.rTxtBoxNotes.Name = "rTxtBoxNotes";
            this.rTxtBoxNotes.Size = new System.Drawing.Size(373, 96);
            this.rTxtBoxNotes.TabIndex = 7;
            this.rTxtBoxNotes.Text = "";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Essential",
            "Important",
            "Casual"});
            this.comboBoxCategory.Location = new System.Drawing.Point(114, 218);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCategory.TabIndex = 6;
            // 
            // lblPasswordLength
            // 
            this.lblPasswordLength.AutoSize = true;
            this.lblPasswordLength.Location = new System.Drawing.Point(532, 32);
            this.lblPasswordLength.Name = "lblPasswordLength";
            this.lblPasswordLength.Size = new System.Drawing.Size(100, 15);
            this.lblPasswordLength.TabIndex = 17;
            this.lblPasswordLength.Text = "Password Length:";
            this.lblPasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSymbols
            // 
            this.lblSymbols.AutoSize = true;
            this.lblSymbols.Location = new System.Drawing.Point(516, 105);
            this.lblSymbols.Name = "lblSymbols";
            this.lblSymbols.Size = new System.Drawing.Size(116, 15);
            this.lblSymbols.TabIndex = 18;
            this.lblSymbols.Text = "Number of Symbols:";
            this.lblSymbols.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDigits
            // 
            this.lblDigits.AutoSize = true;
            this.lblDigits.Location = new System.Drawing.Point(531, 67);
            this.lblDigits.Name = "lblDigits";
            this.lblDigits.Size = new System.Drawing.Size(101, 15);
            this.lblDigits.TabIndex = 19;
            this.lblDigits.Text = "Number of Digits:";
            this.lblDigits.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBoxPasswordLength
            // 
            this.txtBoxPasswordLength.Location = new System.Drawing.Point(633, 31);
            this.txtBoxPasswordLength.Name = "txtBoxPasswordLength";
            this.txtBoxPasswordLength.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPasswordLength.TabIndex = 8;
            this.txtBoxPasswordLength.Text = "12";
            // 
            // txtBoxSymbols
            // 
            this.txtBoxSymbols.Location = new System.Drawing.Point(633, 104);
            this.txtBoxSymbols.Name = "txtBoxSymbols";
            this.txtBoxSymbols.Size = new System.Drawing.Size(100, 23);
            this.txtBoxSymbols.TabIndex = 10;
            this.txtBoxSymbols.Text = "2";
            // 
            // txtBoxDigits
            // 
            this.txtBoxDigits.Location = new System.Drawing.Point(633, 66);
            this.txtBoxDigits.Name = "txtBoxDigits";
            this.txtBoxDigits.Size = new System.Drawing.Size(100, 23);
            this.txtBoxDigits.TabIndex = 9;
            this.txtBoxDigits.Text = "2";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Password_Manager.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxDigits);
            this.Controls.Add(this.txtBoxSymbols);
            this.Controls.Add(this.txtBoxPasswordLength);
            this.Controls.Add(this.lblDigits);
            this.Controls.Add(this.lblSymbols);
            this.Controls.Add(this.lblPasswordLength);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.rTxtBoxNotes);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxUsername);
            this.Controls.Add(this.txtBoxWebsite);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.btnSaveNClose);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnGeneratePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblName);
            this.Name = "Entry";
            this.Text = "Entry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWebsite;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnGeneratePassword;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveNClose;
        private System.Windows.Forms.Label lblPasswordLength;
        private System.Windows.Forms.Label lblSymbols;
        private System.Windows.Forms.Label lblDigits;
        private System.Windows.Forms.TextBox txtBoxPasswordLength;
        private System.Windows.Forms.TextBox txtBoxSymbols;
        private System.Windows.Forms.TextBox txtBoxDigits;
        internal System.Windows.Forms.TextBox txtBoxName;
        internal System.Windows.Forms.TextBox txtBoxWebsite;
        internal System.Windows.Forms.TextBox txtBoxUsername;
        internal System.Windows.Forms.TextBox txtBoxEmail;
        internal System.Windows.Forms.TextBox txtBoxPassword;
        internal System.Windows.Forms.RichTextBox rTxtBoxNotes;
        internal System.Windows.Forms.ComboBox comboBoxCategory;
    }
}