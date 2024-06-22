using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowFormApplication
{
    public partial class Contactus : Form
    {
        string emailPattern = @"^[a-z0-9]+[-_.+]?[a-z0-9]+[@][a-z0-9]+[-_]?[a-z0-9]+[.][a-z]{2,3}$";

        public Contactus()
        {
            InitializeComponent();
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProvider1.SetError(this.textBoxName, "Please fill the name");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (char.IsLetter(character) == true)
            {
                e.Handled = false;
            }
            else if (character == 8)
            {
                e.Handled = false;
            }
            else if (character == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxEmailAddress_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxEmailAddress.Text, emailPattern) == false)
            {
                textBoxEmailAddress.Focus();
                errorProvider2.SetError(this.textBoxEmailAddress, "Invalid Email");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void richTextBoxMessage_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBoxMessage.Text) == true)
            {
                richTextBoxMessage.Focus();
                errorProvider3.SetError(this.richTextBoxMessage, "Message length should be greater than 10");
            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProvider1.SetError(this.textBoxName, "Please fill the name");
            }
            else if (Regex.IsMatch(textBoxEmailAddress.Text, emailPattern) == false)
            {
                textBoxEmailAddress.Focus();
                errorProvider2.SetError(this.textBoxEmailAddress, "Invalid Email");
            }
            else if (String.IsNullOrEmpty(richTextBoxMessage.Text) == true)
            {
                richTextBoxMessage.Focus();
                errorProvider3.SetError(this.richTextBoxMessage, "Message length should be greater than 10");
            }
            else
            {
                MessageBox.Show("Message send successfully!!!");
                Application.Exit();
            }
        }
    }
}
