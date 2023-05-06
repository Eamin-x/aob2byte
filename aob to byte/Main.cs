using System;
using System.Windows.Forms;
using System.IO;
namespace aob2byte
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string x = main.Text;
            string y = main.Text.Replace(" ", ", 0x");
            string z = "0x"+y;
            result.Text = z;
            Clipboard.SetText(result.Text);
            label3.Text = "Converted and Copied";
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            label5.Text = "Welcome Back " + Environment.UserName +" !";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string x = main.Text;
            string y = main.Text.Replace(", 0x", " ").Replace("0x","");
            result.Text = y;
            Clipboard.SetText(result.Text);
            label3.Text = "Converted and Copied";
        }
    }
}
