using CafeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement.Controllers
{
    public class ItemController
    {
        static Database db = new Database();
        public static bool AddItem(dynamic i)
        {
            Item item = new Item();
            item.ItemName = i.ItemName;
            item.Price = Int32.Parse(i.Price); ;

            return db.Items.AddItem(item);

        }
    }
}
