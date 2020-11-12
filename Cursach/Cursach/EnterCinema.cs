using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cursach.Patterns;

namespace Cursach
{
    public partial class EnterCinema : Form
    {
        private bool _isRegister;
        public EnterCinema(bool isRegister)
        {
            InitializeComponent();
            _isRegister = isRegister;
            if (isRegister) enableCardNumber();
        }

        public void enableCardNumber()
        {
            enterButton.Text = "Register";
            cardLabel.Visible = true;
            cardNumber.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(login.Text) && !String.IsNullOrEmpty(password.Text))
            {
                if (_isRegister)
                {
                    if (String.IsNullOrEmpty(cardNumber.Text))
                    {
                        enterButton.Enabled = false;
                        return;
                    }
                }
                enterButton.Enabled = true;
            }
            else enterButton.Enabled = false;

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (_isRegister)
            {
                User newUser = new User(cardNumber.Text, login.Text, password.Text);
                Cinema.AddUser(newUser);
                Close();
            }
            else
            {
                if (!Cinema.EnterCinema(login.Text, password.Text))
                {
                    MessageBox.Show("Incorrect login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(login.Text) && !String.IsNullOrEmpty(password.Text))
            {
                if (_isRegister)
                {
                    if (String.IsNullOrEmpty(cardNumber.Text))
                    {
                        enterButton.Enabled = false;
                        return;
                    }
                }
                enterButton.Enabled = true;
            }
            else enterButton.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(login.Text) && !String.IsNullOrEmpty(password.Text))
            {
                if (_isRegister)
                {
                    if (String.IsNullOrEmpty(cardNumber.Text))
                    {
                        enterButton.Enabled = false;
                        return;
                    }
                }
                enterButton.Enabled = true;
            }
            else enterButton.Enabled = false;
        }
    }
}
