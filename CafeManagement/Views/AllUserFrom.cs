using CafeManagement.Controllers;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class AllUserFrom : Form
    {
        public AllUserFrom()
        {
            InitializeComponent();
            AllUsersGridView.DataSource = UserController.GetAllUsers();
            AllUsersGridView.Columns["Id"].Visible = false;
            AllUsersGridView.Columns["Password"].Visible = false;
            AllUsersGridView.Columns["Category"].Visible = false;
        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }
    }
}
