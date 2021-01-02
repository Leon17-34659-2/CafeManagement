using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement.Models
{
    public class Orders
    {
        SqlConnection conn;
        public Orders (SqlConnection conn)
        {
            this.conn = conn;
        }

    }
}
