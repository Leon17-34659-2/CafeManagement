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
    public partial class SearchUserFrom : Form
    {
        public SearchUserFrom()
        {
            InitializeComponent();
        }

        private void SearchBtn_click(object sender, EventArgs e)
        {
            dynamic user = UserController.GetUser(textBoxSearch.Text);
            if (user != null)
            {
                textBoxName.Text = user.Name;
               textBoxUsername.Text = user.Username;
            }
            else
            {
                textBoxName.Text = "";
                textBoxUsername.Text = "";
                MessageBox.Show("Can not find user");
            }
        }

        private void BlockBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
