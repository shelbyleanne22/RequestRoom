using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRoom.Classes
{
    class User
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Type { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings[@"RequestRoom.Properties.Settings.RequestRoomConnectionString"].ConnectionString;

        //selecting Data from database
        public DataTable Select()
        {
            //select database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //SQL Query
                string sql = @"SELECT * FROM User";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into Database
        public bool Insert(User user)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create sql query to insert data
                string sql = @"INSERT INTO User (userID, password, type) VALUES (@Username, @Password, @Type)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@userID", user.Username);
                cmd.Parameters.AddWithValue(@"@password", user.Password);
                cmd.Parameters.AddWithValue(@"@type", user.Type);

                //open connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if query is successful then the value of rows will be greater than zero; else 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //method to update data in database from our application
        public bool Update(User user)
        {
            //create default return type and set its default to false
            bool isSuccess = false;

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data in our database
                string sql = @"UPDATE User SET userID=@Username, password=@Password, type=@Type WHERE Id=@UserID";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@userID", user.Username);
                cmd.Parameters.AddWithValue(@"@password", user.Password);
                cmd.Parameters.AddWithValue(@"@type", user.Type);
                cmd.Parameters.AddWithValue(@"@Id", user.UserID);

                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows 
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}

