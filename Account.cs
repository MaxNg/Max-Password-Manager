using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using System.Security.Cryptography;

namespace Password_Manager
{
    public partial class Account : Form
    {
        public static string acctfilename = "Accounts.json";
        public static Aes myAes = Aes.Create();
        internal static string myKey = "!@**I#remember))999you@2";
        public static byte[] IV = { 1, 2, 8, 9, 1, 2, 4, 4, 4, 4, 2, 1, 9, 8, 2, 1 };
        public static byte[] key = Encoding.UTF8.GetBytes(myKey);
        public Account()
        {
            InitializeComponent();
        }


        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            byte[] encrypted = EncryptStringToBytes_Aes(txtBoxPassword.Text, key, IV);
            AccountEntry newuser = new AccountEntry(txtBoxUsername.Text, encrypted);
            using StreamWriter writer = new StreamWriter(acctfilename, true);
            writer.WriteLine(JsonSerializer.Serialize(newuser));
            writer.Close();
            Close();
        }

        public class AccountEntry
        {
            public string username { get; set; }
            //public string password { get; set; }
            public byte[] password { get; set; }

            public AccountEntry()
            {

            }

            public AccountEntry(string user, byte[] pwd)
            {
                username = user;
                password = pwd;
            }

        }

        //AES methods
        internal static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");
            byte[] encrypted;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        internal static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plaintext;
        }

    }
}
