using CafeManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            var r = UserController.AuthenticateUser(username, password);

            if (username != "" || password != "")
            {


                if (r != null)

                {
                    if (r.Category == 0)
                    {
                        new AdminForm().Show();
                    }
                    if (r.Category == 1)
                    {
                        new CustomerForm(r);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Insert Values in all Required Fields");
            }
        }
        
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            
            new RegistrationForm().Show();
            this.Hide();
            
           
            
        }
    }
}

