using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Controle_Hotel
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            

        }
        
        public int logar()
        {
            String Md5Password = getMD5(txtPassword.ToString());
            Usuario log = new Usuario(txtUser.ToString(), Md5Password);

            return 1;
        }

        public String getMD5(String password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(password));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for(int i=1; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }

            return str.ToString();
        }
private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

