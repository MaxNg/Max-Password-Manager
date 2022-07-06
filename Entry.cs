using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Password_Manager
{
    public partial class Entry : Form
    {
        public string status;
        public Entry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            Char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            Char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            Char[] symbols = new char[] { '!', '#', '$', '%', '&', '(', ')', '*', '+' };
            Random rnd = new Random();

            //validate password info
            if (!int.TryParse(txtBoxPasswordLength.Text, out int pwdLength))
            {
                MessageBox.Show("Password length requires a number between 8 to 25", "Heads Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(txtBoxDigits.Text, out int numDigits))
            {
                MessageBox.Show("The number of digits needs to be between 0 to 4", "Heads Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!int.TryParse(txtBoxSymbols.Text, out int numSymbols))
            {
                MessageBox.Show("The number of symbols needs to be between 0 to 4", "Heads Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int numLetters = pwdLength - numDigits - numSymbols;
            if (numDigits + numSymbols >= pwdLength)
            {
                MessageBox.Show("The number of digits and symbols cannot equal or exceed the password length", "Heads Up", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < numLetters; i++)
                sb.Append(letters[rnd.Next(letters.Length)]);

            for (int i = 0; i < numDigits; i++)
                sb.Append(numbers[rnd.Next(numbers.Length)]);

            for (int i = 0; i < numSymbols; i++)
                sb.Append(symbols[rnd.Next(symbols.Length)]);

            //scramble sb

            int lengthSB = sb.Length;
            Random rand = new Random();
            for (int i = 0; i < lengthSB; ++i)
            {
                int index1 = (rand.Next() % lengthSB);
                int index2 = (rand.Next() % lengthSB);

                Char temp = sb[index1];
                sb[index1] = sb[index2];
                sb[index2] = temp;
            }

            //add to the password field
            txtBoxPassword.Text = sb.ToString();

        }

        private void btnSaveNClose_Click(object sender, EventArgs e)
        {
            //If new save, check for duplicate
            //if not update the entry
            //If entry is new, add entry to entries and lstViewEntries

            var entryData = new EntryData
            {
                Name = txtBoxName.Text,
                Website = txtBoxWebsite.Text,
                Username = txtBoxUsername.Text,
                Email = txtBoxEmail.Text,
                Password = txtBoxPassword.Text,
                Category = comboBoxCategory.Text,
                Notes = rTxtBoxNotes.Text
            };

            //Check if entryData.name already exists in entries
            
            if (Main.instance.lstViewEntries.FindItemWithText(entryData.Name) != null)
            {
                //Don't update listview, just entries
                if (this.status == "new")
                {
                    MessageBox.Show("Item already exists");
                    return;
                }
                else
                {
                    //Update doc
                    //int index = Main.instance.entries.FindIndex(s => s.Name == entryData.Name);
                    //if (index >= 0)
                    //    Main.instance.entries[index] = entryData;
                    int index = Main.entries.FindIndex(s => s.Name == entryData.Name);
                    if (index >= 0)
                        Main.entries[index] = entryData;
                }

            }
            else
            {
                //Main.instance.entries.Add(entryData);
                Main.entries.Add(entryData);
                this.status = "existing";
                //Main.instance.lstViewEntries.Items.Add(entryData.Name);
                Login.varMain.lstViewEntries.Items.Add(entryData.Name);
                //Main.instance.lstViewEntries.Sort();
                Login.varMain.lstViewEntries.Sort();
                //Main.instance.lstViewEntries.Refresh();
                Login.varMain.lstViewEntries.Refresh();
            }
            
            Close();
        }
    }
}
