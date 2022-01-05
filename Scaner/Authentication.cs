using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using Cryptography;

namespace Scanner
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
            btnAuthentication.Click += BtnAuthentication_Click;            
        }        
        public string Login
        {
            get { return lblLogin.Text; }
        }
        public string Password
        {
            get { return lblPassword.Text; }
        }
        private void BtnAuthentication_Click(object sender, EventArgs e)
        {
            //Takie rozwiązanie uwierzytelniania,
            //podjęte dlatego ze, tworzenie bazy danych użytkowników,
            //nie wchodzi w logikę tej aplikacji.
            //Login == Admin, Password == Password
            string loginProtected = Protector.Encrypt(Login, Password) + Protector.Encrypt(Password, Password);
            string pathCrypto = Path.Combine(Environment.CurrentDirectory, "Authorization.xml");
            FileStream fileLoad = File.Open(pathCrypto, FileMode.Open);
            var xsCrypto = new XmlSerializer(typeof(string));
            string loadedString = (string)xsCrypto.Deserialize(fileLoad);
            fileLoad.Close();
            if(loadedString == loginProtected)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {                
                MessageBox.Show("Invalid Password or Login", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblPassword.Clear();
                lblLogin.Clear();
                lblLogin.Focus();
                return;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Authentication_Load(object sender, EventArgs e)
        {

        }

        private void lblPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnAuthentication.PerformClick();
            }
        }
    }
}
