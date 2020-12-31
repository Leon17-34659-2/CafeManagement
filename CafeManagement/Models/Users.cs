using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace CafeManagement.Models
{
    public class Users
    {
        SqlConnection conn;
        public Users(SqlConnection conn)
        {
            this.conn = conn;
        }
        public bool AddUser(User user)
        {
            conn.Open();
            string query = String.Format("SELECT Id FROM Users WHERE Username='{0}'", user.Username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            
            if (reader.Read())
            {
                conn.Close();
                MessageBox.Show("Username already exist");
                return false;
            }
            else
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                conn.Open();
                query = String.Format("INSERT INTO Users (Name, Username,Password,Category) VALUES ('{0}','{1}','{2}','{3}')", user.Name, user.Username, user.Password, user.Category);
                cmd = new SqlCommand(query, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                    return true;
                return false;
            }
        }

        public User AuthenticateUser(string username, string password)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Users WHERE Username='{0}' and Password='{1}'", username, password);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Category = reader.GetInt32(reader.GetOrdinal("Category"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;

        }
        public ArrayList GetAllUsers()
        {
            ArrayList users = new ArrayList();
            conn.Open();
            string query = "SELECT Name,userName FROM Users";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                User user = new User();
                user = new User();
                ////user.Id = null;
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                users.Add(user);
            }
            conn.Close();
            return users;
        }
        public User GetUser(string username)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Users WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = null;
            while (reader.Read())
            {
                user = new User();
                user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                user.Name = reader.GetString(reader.GetOrdinal("Name"));
                user.Username = reader.GetString(reader.GetOrdinal("Username"));
                user.Password = reader.GetString(reader.GetOrdinal("Password"));
            }
            conn.Close();
            return user;
        }

        public bool UpdateUser(User user)
        {
            conn.Open();
            string query = String.Format("UPDATE Users SET Name='{0}'  WHERE Id='{1}'", user.Name, user.Id);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
        public bool DeleteUser(string username)
        {
            conn.Open();
            string query = String.Format("DELETE FROM Users WHERE Username='{0}'", username);
            SqlCommand cmd = new SqlCommand(query, conn);
            int r = cmd.ExecuteNonQuery();
            conn.Close();
            if (r > 0) return true;
            return false;
        }
    }
}
