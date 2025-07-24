using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace SecureCrypt
{
    public partial class mainForm : Form
    {
        short defaultKey = 2;
        // Encrypt
        string Encrypt(string text, short key = 2)
        {
            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char c = (char)(text[i] + key);
                encrypted.Append(c);
            }
            return encrypted.ToString();
        }

        // Decrypt
        string Decrypt(string text, short key = 2)
        {
            StringBuilder encrypted = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                char c = (char)(text[i] - key);
                encrypted.Append(c);
            }
            return encrypted.ToString();
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            for (int i = 1; i <= 10; i++)
            {
                if (progressBarEncrypt.Value < progressBarEncrypt.Maximum)
                {
                    Thread.Sleep(200);
                    progressBarEncrypt.Value += 10;
                }
            }
            InputKeyDecrypt.Text = InputKeyEncrypt.Text;

            if (InputKeyEncrypt.Text == "")
            {
                ResultEncrypt.Text = Encrypt(InputTextToEncrypt.Text, defaultKey);
                return;
            }
            ResultEncrypt.Text = Encrypt(InputTextToEncrypt.Text, short.Parse(InputKeyEncrypt.Text));
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                if (progressBarDecrypt.Value < progressBarDecrypt.Maximum)
                {
                    Thread.Sleep(200);
                    progressBarDecrypt.Value += 10;
                }
            }

            if (InputKeyDecrypt.Text == "")
            {
                ResultDecrypt.Text = Decrypt(InputTextToDecrypt.Text, defaultKey);
                return;
            }

            ResultDecrypt.Text = Decrypt(InputTextToDecrypt.Text, short.Parse(InputKeyDecrypt.Text));
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            progressBarEncrypt.Value = 0;
            progressBarDecrypt.Value = 0;

            InputTextToEncrypt.Text = "";
            InputTextToDecrypt.Text = "";

            InputKeyEncrypt.Text = "";
            InputKeyDecrypt.Text = "";

            ResultDecrypt.Text = "";
            ResultEncrypt.Text = "";
        }
    }
}
