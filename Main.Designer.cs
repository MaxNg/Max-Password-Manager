
namespace Password_Manager
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCreateEntry = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.lstViewEntries = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.btnWebsite = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBAll = new System.Windows.Forms.RadioButton();
            this.rBCasual = new System.Windows.Forms.RadioButton();
            this.rBImportant = new System.Windows.Forms.RadioButton();
            this.rBEssential = new System.Windows.Forms.RadioButton();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateEntry
            // 
            this.btnCreateEntry.Location = new System.Drawing.Point(38, 28);
            this.btnCreateEntry.Name = "btnCreateEntry";
            this.btnCreateEntry.Size = new System.Drawing.Size(118, 23);
            this.btnCreateEntry.TabIndex = 0;
            this.btnCreateEntry.Text = "Create Entry";
            this.btnCreateEntry.UseVisualStyleBackColor = true;
            this.btnCreateEntry.Click += new System.EventHandler(this.btnCreateEntry_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(38, 70);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteEntry.TabIndex = 1;
            this.btnDeleteEntry.Text = "Delete Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // lstViewEntries
            // 
            this.lstViewEntries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstViewEntries.HideSelection = false;
            this.lstViewEntries.Location = new System.Drawing.Point(206, 28);
            this.lstViewEntries.Name = "lstViewEntries";
            this.lstViewEntries.Size = new System.Drawing.Size(231, 390);
            this.lstViewEntries.TabIndex = 3;
            this.lstViewEntries.UseCompatibleStateImageBehavior = false;
            this.lstViewEntries.View = System.Windows.Forms.View.Details;
            this.lstViewEntries.DoubleClick += new System.EventHandler(this.lstViewEntries_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 170;
            // 
            // btnWebsite
            // 
            this.btnWebsite.Location = new System.Drawing.Point(37, 112);
            this.btnWebsite.Name = "btnWebsite";
            this.btnWebsite.Size = new System.Drawing.Size(118, 23);
            this.btnWebsite.TabIndex = 4;
            this.btnWebsite.Text = "Go to Website";
            this.btnWebsite.UseVisualStyleBackColor = true;
            this.btnWebsite.Click += new System.EventHandler(this.btnWebsite_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBAll);
            this.groupBox1.Controls.Add(this.rBCasual);
            this.groupBox1.Controls.Add(this.rBImportant);
            this.groupBox1.Controls.Add(this.rBEssential);
            this.groupBox1.Location = new System.Drawing.Point(38, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 128);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category";
            // 
            // rBAll
            // 
            this.rBAll.AutoSize = true;
            this.rBAll.Location = new System.Drawing.Point(23, 98);
            this.rBAll.Name = "rBAll";
            this.rBAll.Size = new System.Drawing.Size(77, 19);
            this.rBAll.TabIndex = 3;
            this.rBAll.TabStop = true;
            this.rBAll.Text = "All Entries";
            this.rBAll.UseVisualStyleBackColor = true;
            this.rBAll.CheckedChanged += new System.EventHandler(this.rBAll_CheckedChanged);
            // 
            // rBCasual
            // 
            this.rBCasual.AutoSize = true;
            this.rBCasual.Location = new System.Drawing.Point(23, 72);
            this.rBCasual.Name = "rBCasual";
            this.rBCasual.Size = new System.Drawing.Size(60, 19);
            this.rBCasual.TabIndex = 2;
            this.rBCasual.TabStop = true;
            this.rBCasual.Text = "Casual";
            this.rBCasual.UseVisualStyleBackColor = true;
            this.rBCasual.CheckedChanged += new System.EventHandler(this.rBCasual_CheckedChanged);
            // 
            // rBImportant
            // 
            this.rBImportant.AutoSize = true;
            this.rBImportant.Location = new System.Drawing.Point(23, 47);
            this.rBImportant.Name = "rBImportant";
            this.rBImportant.Size = new System.Drawing.Size(78, 19);
            this.rBImportant.TabIndex = 1;
            this.rBImportant.TabStop = true;
            this.rBImportant.Text = "Important";
            this.rBImportant.UseVisualStyleBackColor = true;
            this.rBImportant.CheckedChanged += new System.EventHandler(this.rBImportant_CheckedChanged);
            // 
            // rBEssential
            // 
            this.rBEssential.AutoSize = true;
            this.rBEssential.Location = new System.Drawing.Point(23, 22);
            this.rBEssential.Name = "rBEssential";
            this.rBEssential.Size = new System.Drawing.Size(70, 19);
            this.rBEssential.TabIndex = 0;
            this.rBEssential.TabStop = true;
            this.rBEssential.Text = "Essential";
            this.rBEssential.UseVisualStyleBackColor = true;
            this.rBEssential.CheckedChanged += new System.EventHandler(this.rBEssential_CheckedChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(38, 311);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(51, 15);
            this.lblSearch.TabIndex = 6;
            this.lblSearch.Text = "Search...";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(55, 327);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(135, 23);
            this.txtBoxSearch.TabIndex = 7;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Password_Manager.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 472);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWebsite);
            this.Controls.Add(this.lstViewEntries);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.btnCreateEntry);
            this.Name = "Main";
            this.Text = "Max Password Manager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateEntry;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnWebsite;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rBCasual;
        private System.Windows.Forms.RadioButton rBImportant;
        private System.Windows.Forms.RadioButton rBEssential;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        internal System.Windows.Forms.ListView lstViewEntries;
        private System.Windows.Forms.RadioButton rBAll;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtBoxSearch;
    }
}

