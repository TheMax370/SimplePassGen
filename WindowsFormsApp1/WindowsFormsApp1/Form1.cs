using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextPass_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
           string[] chars = new string[] { "q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$", "%", "^", "&", "*", "-", "_", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "A", "S", "D", "F", "G", "H", "J", "K", "L", "Z", "X", "C", "V", "B", "N", "M" };
            Random random = new Random();
            StringBuilder str = new StringBuilder();

            for (int i = 0; i < 12; i++)
            {
                string password = chars[random.Next(i, chars.Length)];
                TextPass.Text = str.Append(password).ToString();
            }

        }

        private void Btn_ClipBoard_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(TextPass.Text);
        }
    }
}
