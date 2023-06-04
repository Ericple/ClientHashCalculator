using System.Security.Cryptography;
using System.Text;

namespace ClientHashCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Select_File_Button_Click(object sender, EventArgs e)
        {
            DialogResult dResult = openFileDialog.ShowDialog(this);
            if (dResult == DialogResult.OK)
            {
                File_Path_Box.Text = openFileDialog.FileName;
            }
        }

        private void Calculate_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using var crypto = SHA256.Create();
                using FileStream fs = File.OpenRead(File_Path_Box.Text);
                Result_Text_Box.Text = ToHex(crypto.ComputeHash(fs));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static string ToHex(byte[] bytes)
        {
            StringBuilder result = new StringBuilder(bytes.Length * 2);
            for (int i = 0; i < bytes.Length; i++)
            {
                result.Append(bytes[i].ToString("x2"));
            }
            return result.ToString();
        }
    }
}