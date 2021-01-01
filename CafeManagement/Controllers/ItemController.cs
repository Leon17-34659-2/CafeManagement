using CafeManagement.Models;
using System;
using System.Collections;

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
        public static ArrayList GetAllItems()
        {
            return db.Items.GetAllItems();
        }
        public static Item GetItemDetails(int id)
        {
            return db.Items.GetItemDetails(id);
        }
    }
}
