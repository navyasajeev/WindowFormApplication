using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowFormApplication
{
    public partial class Registration : Form
    {
        string emailPattern = @"^[a-z0-9]+[-_.+]?[a-z0-9]+[@][a-z0-9]+[-_]?[a-z0-9]+[.][a-z]{2,3}$";
     //   string emailPattern = @"^[a-zA-Z0-9._%±]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";
        string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        public Registration()
        {
            InitializeComponent();
        }

        private void textBoxID_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxID.Text)==true)
            {
                textBoxID.Focus();
                errorProvider1.SetError(this.textBoxID, "Please fill the id");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;
            if (char.IsDigit(character) == true)
            {
                e.Handled = false;
            }
            else if (character == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProvider2.SetError(this.textBoxName, "Please fill the name");

            }
            else
            {
                errorProvider2.Clear();
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

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxAddress.Text) == true)
            {
                textBoxAddress.Focus();
                errorProvider3.SetError(this.textBoxAddress, "Please fill the address");

            }
            else
            {
                errorProvider3.Clear();
            }
        }

        private void textBoxAddress_KeyPress(object sender, KeyPressEventArgs e)
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
                errorProvider4.SetError(this.textBoxEmailAddress, "Invalid Email");
            }
            else
            {
                errorProvider4.Clear();
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBoxPassword.Text, passwordPattern) == false)
            {
                textBoxPassword.Focus();
                errorProvider5.SetError(this.textBoxPassword, "Please enter strong password");
            }
            else
            {
                errorProvider5.Clear();
            }
        }

        private void textBoxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if(textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                textBoxConfirmPassword.Focus();
                errorProvider6.SetError(this.textBoxConfirmPassword, "Password mismatch");

            }
            else
            {
                errorProvider6.Clear();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxID.Text) == true)
            {
                textBoxID.Focus();
                errorProvider1.SetError(this.textBoxID, "Please fill the id");

            }
            else if (string.IsNullOrEmpty(textBoxName.Text) == true)
            {
                textBoxName.Focus();
                errorProvider2.SetError(this.textBoxName, "Please fill the name");

            }
            else if (string.IsNullOrEmpty(textBoxAddress.Text) == true)
            {
                textBoxAddress.Focus();
                errorProvider3.SetError(this.textBoxAddress, "Please fill the address");

            }
            else if (Regex.IsMatch(textBoxEmailAddress.Text, emailPattern) == false)
            {
                textBoxEmailAddress.Focus();
                errorProvider4.SetError(this.textBoxEmailAddress, "Invalid Email");
            }
            else if (Regex.IsMatch(textBoxPassword.Text, passwordPattern) == false)
            {
                textBoxPassword.Focus();
                errorProvider5.SetError(this.textBoxPassword, "Please enter strong password");
            }
            else if (textBoxPassword.Text != textBoxConfirmPassword.Text)
            {
                textBoxConfirmPassword.Focus();
                errorProvider6.SetError(this.textBoxConfirmPassword, "Password mismatch");

            }
            else
            {
                DialogResult result;
                result =MessageBox.Show("Registered Successfully");
                if(result==DialogResult.OK)
                {
                    textBoxID.Clear();
                    textBoxName.Clear();
                    textBoxAddress.Clear();
                    textBoxEmailAddress.Clear();
                    textBoxPassword.Clear();
                    textBoxConfirmPassword.Clear();
                    textBoxID.Focus();
                }
                else
                {
                    this.Show();
                }
            }

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxName.Clear();
            textBoxAddress.Clear();
            textBoxEmailAddress.Clear();
            textBoxPassword.Clear();
            textBoxConfirmPassword.Clear();
            textBoxID.Focus();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login form = new Login();
            form.Show();
            this.Hide();
        }
    }
}
