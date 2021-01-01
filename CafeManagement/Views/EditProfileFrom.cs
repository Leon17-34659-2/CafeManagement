using CafeManagement.Controllers;
using CafeManagement.Models;
using System;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class EditProfileFrom : Form
    {
        User user;
        CustomerForm parent;
        public EditProfileFrom(User user, CustomerForm parent)
        {
            InitializeComponent();
            this.user = user;
            this.parent = parent;
            textBoxNewName.Text = user.Name.Trim();
            buttonSaveName.Visible = false;
            //textBoxNewName.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBoxNewPass.Visible = false;
            textBoxOldPass.Visible = false;
            buttonSavePass.Visible = false;
            this.Show();

           
        }

        

        private void ChngBtn_Click(object sender, EventArgs e)
        {
            textBoxNewName.Enabled = true;
            buttonSaveName.Visible = true;
        }

        private void buttonSaveName_Click(object sender, EventArgs e)
        {
            if (textBoxNewName.Text.Trim() == "")
            {
                MessageBox.Show("Name can not be enmpty!");
            }
            else
            {
                user.Name = textBoxNewName.Text.Trim();
                if (UserController.UpdateUser(user))
                {
                    MessageBox.Show("Name Updated");
                    textBoxNewName.Text = textBoxNewName.Text.Trim();
                    textBoxNewName.Enabled = false;
                    buttonSaveName.Visible = false;

                }
                else
                {
                    MessageBox.Show("There was an unknown error!!");
                }
            }
        }

        

        private void buttonChngPass_Click(object sender, EventArgs e)
        {
            textBoxOldPass.Visible = true;
            textBoxNewPass.Visible = true;
            buttonSavePass.Visible = true;
            label1.Visible = true;
            label2.Visible = true;


        }

        private void buttonSavePass_Click(object sender, EventArgs e)
        {
            if (user.Password.Trim() == textBoxOldPass.Text.Trim())
            {   
                if (textBoxNewPass.Text.Trim() != "")
                {
                    user.Password = textBoxNewPass.Text.Trim();
                    if (UserController.UpdatePassword(user))
                    {
                        MessageBox.Show("Password updaed");
                        textBoxOldPass.Visible = false;
                        textBoxNewPass.Visible = false;
                        buttonSavePass.Visible = false;
                        label1.Visible = false;
                        label2.Visible = false;
                        textBoxOldPass.Text = "";
                        textBoxNewPass.Text = "";
                    }
                    else
                    {
                        user.Password = textBoxOldPass.Text.Trim();
                    }
                }
                else
                {
                    MessageBox.Show("Enter a new password to update");
                }
            }
            else
            {
                MessageBox.Show("Incorrect Old Password!!");
            }
        }
        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (UserController.DeleteUser(user.Id))
            {
                MessageBox.Show("Your Account has been deleted!!");
                parent.Terminate();
                this.Close();
            }
            else
            {
                MessageBox.Show("Go fuck yourself!!");
            }
        }
    }
}
