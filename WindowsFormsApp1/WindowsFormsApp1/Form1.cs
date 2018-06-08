using System;

using System.Text;

using System.Windows.Forms;
using System.IO;

using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        UnicodeEncoding byteConverter = new UnicodeEncoding();
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        FileStream originalFile = null;
        FileStream encFile = null;
        FileStream decFile = null;
        byte[] encryptedText;

        byte[] buffer = null;
        string shtesa;
        string directory;
        public Form1()
        {
            InitializeComponent();
        }

        private void zgjedhFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //file stream eshte klas qe mundeson me shkru, me lexu ose me shkru/lexu n'file
                //filestream objekti i ka tri parametra
                originalFile = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                //shtesa ruan llojin e file, pra merr prapashtesen e file-it
                shtesa = Path.GetExtension(openFileDialog.FileName);
                //directory ruan pathin ku do te ruhet file
                directory = Path.GetDirectoryName(openFileDialog.FileName);
                //e shkruan pathin 
                txtShteguFile.Text = openFileDialog.FileName;

            }
            try
            {
                if (originalFile.CanRead)
                {
                    buffer = new byte[originalFile.Length];
                    int bytesRead = originalFile.Read(buffer, 0, buffer.Length);
                    originalFile.Close();

                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Asnje file nuk eshte zgjedhur ose nuk mund te hapet file");

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnZgjedhFile_Click(object sender, EventArgs e)
        {

        }

        private void btnZgjedhCertifikaten_Click(object sender, EventArgs e)
        {

        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {

        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {

        }

        private void txtShteguFile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
