using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
