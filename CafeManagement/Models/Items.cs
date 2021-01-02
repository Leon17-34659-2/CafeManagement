using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeManagement.Models
{
    public class Items
    {
        SqlConnection conn;
        public Items(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddItem(Item item)
        {
            conn.Open();
            string query = String.Format("SELECT Id FROM Items WHERE ItemName='{0}'", item.ItemName);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                conn.Close();
                MessageBox.Show("Item already exist");
                return false;
            }
            else
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                query = String.Format("INSERT INTO Items (ItemName, Price) VALUES ('{0}','{1}')", item.ItemName, item.Price);
                cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                    return true;
                return false;
            }
        }
        public ArrayList GetAllItems()
        {
            ArrayList items = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Items";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Item item = new Item();
                
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
                item.Price = reader.GetInt32(reader.GetOrdinal("Price"));
                items.Add(item);
            }
            conn.Close();
            return items;
        }
        public Item GetItemDetails(int id)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Items WHERE Id='{0}'", id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Item item = new Item();
            if (reader.Read())
            {
                item.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                item.ItemName = reader.GetString(reader.GetOrdinal("ItemName"));
                item.Price = reader.GetInt32(reader.GetOrdinal("Price"));
            }
            else
            {
                item.ItemName = "NO ITEM WITH THIS ID";
            }
            conn.Close();
            return item;
        }
    }
}
