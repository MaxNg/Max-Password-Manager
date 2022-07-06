using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace Password_Manager
{
    public partial class Main : Form
    {
        //public static Main instance;
        public static List<EntryData> entries;

        public Main()
        {
            InitializeComponent();
            Login.varMain = this;
            entries = new List<EntryData>();

            //Open json file and add all items to the listview

            if (File.Exists(Login.userFileName))
            {
                //List<EntryData> entries = GetEntries();
                entries = GetEntries();

                foreach (EntryData entry in entries)
                {
                    lstViewEntries.Items.Add(entry.Name);
                }
            }

        }

        private void btnCreateEntry_Click(object sender, EventArgs e)
        {
            //lstViewEntries
            Entry entry = new Entry();
            entry.status = "new";
            entry.Show();
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (lstViewEntries.SelectedItems.Count > 0)
            {
                //delete entry
                string name = lstViewEntries.SelectedItems[0].SubItems[0].Text;
                //remove from list

                lstViewEntries.Items.RemoveAt(lstViewEntries.Items.IndexOf(lstViewEntries.SelectedItems[0]));
                //remove from entries
                EntryData eData = GetEntryData(name);
                entries.Remove(eData);
                lstViewEntries.Refresh();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private EntryData GetEntryData(string nameEntry)
        {
            //Search entries for nameEntry
            EntryData eData = entries.Find(e => e.Name == nameEntry);
            return eData;
        }

        private List<EntryData> GetEntries()
        {
            //read from json files
            //StreamReader reader;
            string jsonFromFile;
            byte[] decode;

            //if (File.Exists(filename))
            
            using (StreamReader reader = new StreamReader(Login.userFileName))
              /*      while ((jsonFromFile = reader.ReadLine()) != null)
                    {
                        EntryData? e = JsonSerializer.Deserialize<EntryData>(jsonFromFile);
                        entries.Add(e);
                    }
            
             */
                while ((jsonFromFile = reader.ReadLine()) != null)
                {
                    decode = Convert.FromBase64String(jsonFromFile);
                    string d = Account.DecryptStringFromBytes_Aes(decode, Account.key, Account.IV);
                    EntryData? e = JsonSerializer.Deserialize<EntryData>(Account.DecryptStringFromBytes_Aes(decode,Account.key,Account.IV));
                    entries.Add(e);
                }

            return entries;
        }

        private void lstViewEntries_DoubleClick(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            string nameEntry = lstViewEntries.FocusedItem.SubItems[0].Text;
            EntryData entryData = GetEntryData(nameEntry);
            if (entryData == null)
            {
                MessageBox.Show("Cannot find this entry", "Heads Up", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                entry.txtBoxName.Text = entryData.Name;
                entry.txtBoxWebsite.Text = entryData.Website;
                entry.txtBoxUsername.Text = entryData.Username;
                entry.txtBoxEmail.Text = entryData.Email;
                entry.txtBoxPassword.Text = entryData.Password;
                entry.rTxtBoxNotes.Text = entryData.Notes;
                entry.comboBoxCategory.Text = entryData.Category;
            }

            //entry.txtBoxName.Text = lstViewEntries.FocusedItem.SubItems[0].Text;
            entry.status = "existing";
            entry.Show();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Save all data in entries
            byte[] encrypted;
            try
            {
                //encrypt each line before saving
                /*
                using StreamWriter writer = new StreamWriter(Login.userFileName, false);
                foreach (EntryData entry in entries)
                {
                    //encrypt each line before saving
                    encrypted = Account.EncryptStringToBytes_Aes(JsonSerializer.Serialize(entry), Account.key, Account.IV);
                    //writer.WriteLine(JsonSerializer.Serialize(entry));
                    //writer.WriteLine(encrypted);

                }
                //writer.WriteLine(s);
                */

                /* using var stream = File.Open(Login.userFileName, FileMode.Append);
                using BinaryWriter writer = new BinaryWriter(stream, Encoding.UTF8, false); */
                using StreamWriter writer = new StreamWriter(Login.userFileName, false);
                foreach (EntryData entry in entries)
                {
                    encrypted = Account.EncryptStringToBytes_Aes(JsonSerializer.Serialize(entry), Account.key, Account.IV);
                    //encrypted.ToString();
                    writer.WriteLine(Convert.ToBase64String(encrypted));
                    
                }

            }
            catch (Exception ex)
            {
                //print exception ex
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Login.varLogin.Close();

        }


        private void rBEssential_CheckedChanged(object sender, EventArgs e)
        {
            lstViewEntries.Items.Clear();
            lstViewEntries.Items.AddRange(entries.Where(i => i.Category == "Essential").Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void rBCasual_CheckedChanged(object sender, EventArgs e)
        {
            lstViewEntries.Items.Clear();
            lstViewEntries.Items.AddRange(entries.Where(i => i.Category == "Casual").Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private void rBImportant_CheckedChanged(object sender, EventArgs e)
        {
            lstViewEntries.Items.Clear();
            lstViewEntries.Items.AddRange(entries.Where(i => i.Category == "Important").Select(c => new ListViewItem(c.Name)).ToArray());
        }

        private async void btnWebsite_Click(object sender, EventArgs e)
        {
            var newprocess = new System.Diagnostics.Process();

            //Entry entry = new();
            string nameEntry = lstViewEntries.FocusedItem.SubItems[0].Text;
            EntryData entryData = GetEntryData(nameEntry);
            if (entryData != null)
            {
                string urlname = @"http://" + entryData.Website;
                //System.Diagnostics.Process.Start(urlname);

                try
                {
                    //System.Diagnostics.Process.Start(urlname);
                    newprocess.StartInfo.FileName = urlname;
                    newprocess.StartInfo.UseShellExecute = true;
                    newprocess.Start();
                    IDataObject data = new DataObject();
                    Clipboard.Clear();
                    Clipboard.SetText(entryData.Password);
                    await Task.Delay(1000);
                    Clipboard.SetText(entryData.Email);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259)
                        MessageBox.Show(noBrowser.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void rBAll_CheckedChanged(object sender, EventArgs e)
        {
            lstViewEntries.Items.Clear();
            lstViewEntries.Items.AddRange(entries.Select(c => new ListViewItem(c.Name)).ToArray());

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            lstViewEntries.Items.Clear();
            lstViewEntries.Items.AddRange(entries.Where(i=>string.IsNullOrEmpty(txtBoxSearch.Text)|i.Name.StartsWith(txtBoxSearch.Text))
                .Select(c => new ListViewItem(c.Name)).ToArray());
        }
    }
}
