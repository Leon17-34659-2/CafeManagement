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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            new ItemListForm().Show();
        }

        private void AllUserBtn_click(object sender, EventArgs e)
        {
            new AllUserFrom().Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        new  SearchUserFrom().Show();
        }
    }
}
