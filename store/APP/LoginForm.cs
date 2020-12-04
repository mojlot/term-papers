using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            textBoxAdminPassword.PasswordChar = '*';



        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string AdminName = textBoxAdminName.Text;
            string AdminPassword = textBoxAdminPassword.Text;
            string a = "admin";
            string b = "pass";
            if (string.IsNullOrWhiteSpace(AdminName) || string.IsNullOrEmpty(AdminPassword))
            {
                MessageBox.Show("Введите логин и пароль!");
                return;
            }
            else if (AdminName == a && AdminPassword == b)
            {

                AdminForm forma = new AdminForm();
                forma.Show();
                this.Hide();
            }
            else if (AdminName != a) MessageBox.Show("Неверный логин");
            else if (AdminPassword != b) MessageBox.Show("Неверный пароль");
        }

        private void textBoxAdminPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) { buttonLogin_Click(sender,e); }
        }
    }
}
