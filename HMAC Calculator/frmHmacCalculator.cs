using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HMAC_Calculator
{
    public partial class frmHmacCalculator : Form
    {
        public frmHmacCalculator()
        {
            InitializeComponent();
        }

        private void Inputs_TextChanged(object sender, EventArgs e)
        {
            string keyString = txtSecret.Text;
            string msg = txtText1.Text +  txtText2.Text + DateTime.Now.ToString(txtTimestampFormat.Text);
            txtMessage.Text = msg;

            txtDigest.Text = hmacDigest(msg, keyString, String.Empty);
        }

        private string hmacDigest(string msg, string keyString, string algo)
        {
            String digest = String.Empty;
            try
            {
                byte[] secretKey = Encoding.UTF8.GetBytes(keyString);
                HMACSHA384 hmac = new HMACSHA384(secretKey);
                hmac.Initialize();
                byte[] bytes = Encoding.ASCII.GetBytes(msg);
                var rawData = hmac.ComputeHash(bytes);
                digest = ByteArrayToString(rawData);
            }
            catch (Exception e)
            {
                throw e;
            }
            return digest;
        }

        private string ByteArrayToString(byte[] ba)
        {
            try
            {
                StringBuilder hex = new StringBuilder(ba.Length * 2);
                foreach (byte b in ba)
                    hex.AppendFormat("{0:x2}", b);
                return hex.ToString();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
