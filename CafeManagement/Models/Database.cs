using System.Data.SqlClient;
namespace CafeManagement.Models
{
    class Database
    {
        public Users Users { get; set; }
        public Items Items { get; set; }
        public Transections Transections { get; set; }

        public Database()
        {
            string connString = "Server=LEON;Integrated Security=true;Database=CafeManagement";
            SqlConnection conn = new SqlConnection(connString);
            Users = new Users(conn);
            Items = new Items(conn);
            Transections = new Transections(conn);

        }
    }
}
