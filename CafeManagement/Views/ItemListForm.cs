using CafeManagement.Controllers;
using System;
using System.Windows.Forms;

namespace CafeManagement.Views
{
    public partial class ItemListForm : Form
    {
        public ItemListForm()
        {
            InitializeComponent();
        }

        private void ItemAddBtn_Click(object sender, EventArgs e)
        {
            bool i = true;
            while (i)
            {
                try
                {
                    Int32.Parse(textBoxPrice.Text);
                    i = false;
                    var item = new
                    {


                        ItemName = textBoxItemName.Text,
                        Price = textBoxPrice.Text,

                    };

                    if (item.ItemName != "" || item.Price != "")
                    {

                        bool r = ItemController.AddItem(item);
                        if (r)
                        {
                            MessageBox.Show("Item Added");
                        }
                        else
                        {
                            MessageBox.Show("Item not Added");

                        }

                    }
                    else
                    {
                        MessageBox.Show("Insert Values in all Required Fields");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Enter Integer at Price field");
                    break;


                }
            }

           
        }
    }
}
