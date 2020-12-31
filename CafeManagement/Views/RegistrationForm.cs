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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var user = new
            {   
                Category=1,
                Name = textBoxName.Text,
                Username = textBoxUsername.Text,
                Password = textBoxPassword.Text
            };
          
            if(user.Name!="" || user.Username!=""||user.Password!="")
            {

                bool r = UserController.AddUser(user);
                if (r)
                {
                    new RegConfirmFrom().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("User not Added");

                }
               
             

                }
            else
            {
                MessageBox.Show("Insert Values in all Required Fields");
            }

            }


        }
    }

