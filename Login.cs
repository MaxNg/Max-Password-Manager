using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using static Password_Manager.Account;
using System.Linq;

namespace Password_Manager
{
    public partial class Login : Form
    {
        public static string userFileName;
        public static Login varLogin = null;
        public static Main varMain;
        
        public Login()
        {
            InitializeComponent();
            varLogin = this;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Look for user account in the accounts.json file and match password
            Account.AccountEntry user = GetUser(txtBoxUsername.Text);
            if (user != null)
            {
                //Decrypt and Check password
                string decrypted = DecryptStringFromBytes_Aes(user.password, Account.key, Account.IV);
                if(decrypted == txtBoxPassword.Text)
                {
                    //ok you can proceed
                    userFileName = user.username.Replace(" ", "_");
                }
                else
                {
                    MessageBox.Show("Wrong password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Username not found","Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.Hide();
            Main main = new Main();
            main.Show();
        }

        private AccountEntry GetUser(string username)
        {
            //Account.AccountEntry user = new Account.AccountEntry();
            string jsonFromFile;
            if (File.Exists(Account.acctfilename))
            {
                using (StreamReader reader = new StreamReader(Account.acctfilename))
                    while ((!string.IsNullOrEmpty(jsonFromFile = reader.ReadLine())))
                    {
                        AccountEntry user = JsonSerializer.Deserialize<AccountEntry>(jsonFromFile);
                        if (user.username == username)
                        {
                            return user;
                        }
                    }
            }
            return null;
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            Account acct = new Account();
            acct.Show();
        }
    }
}
