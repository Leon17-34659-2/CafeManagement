using CafeManagement.Models;
using System;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class CustomerForm : Form
    {
        private User user;
        public CustomerForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.Show();

        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            new OrderFrom(user).Show();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            new EditProfileFrom(user, this);
        }
        public void Terminate()
        {
            this.Close();
        }
    }
}
