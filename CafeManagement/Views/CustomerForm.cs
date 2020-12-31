using CafeManagement.Models;
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
            new OrderFrom();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            new EditProfileFrom(user);
        }
    }
}
