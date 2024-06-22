using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowFormApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=LAPTOP-ISJ78FR1\SQLEXPRESS;Initial Catalog=FirstApplication;Integrated Security=True;Encrypt=False");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;
            try
            {
                String query = "SELECT * FROM login WHERE username = '"+txt_username.Text+"'AND PASSWORD = '"+txt_password.Text+"'";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                DataTable dtable = new DataTable();
                sqlDataAdapter.Fill(dtable);

                if(dtable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    user_password = txt_password.Text;
                    //Page that needed to be load next
                    Home form2 = new Home();
                    form2.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_username.Clear();
                    txt_password.Clear();

                    //To focus username
                    txt_username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();

            txt_username.Focus();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result== DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_Leave(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_username.Text) == true)
            {
                txt_username.Focus();
                errorProvider1.SetError(this.txt_username, "Please fill the username");

            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_password.Text) == true)
            {
                txt_password.Focus();
                errorProvider2.SetError(this.txt_password, "Please fill the password");

            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            form.Show();
            this.Hide();
        }
    }
}
