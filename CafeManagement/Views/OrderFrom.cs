using CafeManagement.Controllers;
using CafeManagement.Models;
using System;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class OrderFrom : Form
    {
        private string order_details = "Item name --> Quantity --> Unit Price --> Total\n\n";
        private int grandTotal = 0;
        private User user;

        public OrderFrom(User user)
        {
            InitializeComponent();
            this.user = user;
            AllItemdataGridView.DataSource = ItemController.GetAllItems();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(numericUpDown_order_id.Value);
            int quantity = Convert.ToInt32(numericUpDown_quantity.Value);
            Item item = ItemController.GetItemDetails(id);
            if(item.ItemName == "NO ITEM WITH THIS ID")
            {
                MessageBox.Show("Item does not exist. Please enter a valid Id");
            }
            else if(quantity == 0)
            {
                MessageBox.Show("Quantity can not be Zero(0).");
            }
            else
            {
                grandTotal += item.Price * quantity;
                order_details += item.ItemName.Trim() + " --> " + quantity + "(Pcs) --> " + item.Price + "(taka) --> " + item.Price * quantity + "(taka)\n";
                richTextBox_OrderDetails.Text = order_details+"\n Grand Total : "+grandTotal+" Taka";
            }
            
            if(grandTotal != 0)
            {
                buttonOrder.Text = "Order Another";
            }
        }

        private void buttonConfirmOrder_Click(object sender, EventArgs e)
        {
           if(grandTotal == 0)
            {
                MessageBox.Show("Order Something First");
            }
           else
                new ConfirmOrderFrom(user, grandTotal, this).Show();
        }
    }
}
