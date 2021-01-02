using System;
using System.Collections;
using System.Data.SqlClient;


namespace CafeManagement.Models
{
    public class Transections
    {
        
            SqlConnection conn;
            public Transections(SqlConnection conn)
            {
                this.conn = conn;
            }

            public bool InsertTransaction(Transection transection)
             {


                conn.Open();
                string query = String.Format("INSERT INTO Transection (User_Id, User_Name,Amount,Date_Time) VALUES " +
                  "('{0}','{1}','{2}','{3}')", transection.User_Id, transection.User_Name, transection.Amount, transection.Date_Time);
                SqlCommand cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                    return true;
                return false;
            }
        public ArrayList ViewTransection()
        {
            ArrayList transections = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Transection";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
               Transection transection = new Transection();

                transection.Transection_Id = reader.GetInt32(reader.GetOrdinal("Transection_Id"));
                transection.User_Id = reader.GetInt32(reader.GetOrdinal("User_Id"));
                transection.User_Name = reader.GetString(reader.GetOrdinal("User_Name"));
                transection.Amount = reader.GetInt32(reader.GetOrdinal("Amount"));
                transection.Date_Time = reader.GetDateTime(reader.GetOrdinal("Date_Time"));
                transections.Add(transection);
            }
            conn.Close();
            return transections;
        }
    }
}
