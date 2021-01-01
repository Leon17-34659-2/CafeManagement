using CafeManagement.Controllers;
using CafeManagement.Models;
using System;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    

    public partial class ConfirmOrderFrom : Form
    {
        private User user;
        private int ammount;
        private OrderFrom parent;
        public ConfirmOrderFrom(User user, int ammount, OrderFrom parent)
        {
            InitializeComponent();
            this.user = user;
            this.ammount = ammount;
            this.parent = parent;
        }

        private void buttonFinishOrder_Click(object sender, EventArgs e)
        {
            Transection transection = new Transection();
            transection.User_Id = user.Id;
            transection.User_Name = user.Username;
            transection.Amount = ammount;
            transection.Date_Time = DateTime.Now;
            if (TransectionController.InsertTransaction(transection))
            {
                this.Close();
                parent.Close();
            }
            else
                MessageBox.Show("There was an unknown error!!");
            
        }
    }
}
