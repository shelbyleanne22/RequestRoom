using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRoom
{
    class Rooms
    {
        //Properties
        public int RoomId { get; set; }

        public string RoomName { get; set; }

        public string RoomStatus { get; set; }

        public int RoomCapacity { get; set; }

        public string RoomDescription { get; set; }

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
                string sql = @"SELECT * FROM Room";
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
        public bool Insert(Rooms room)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create sql query to insert data
                string sql = @"INSERT INTO Room (roomName, roomStatus, roomCapacity, roomDescription ) VALUES (@RoomName, @RoomStatus, @RoomCapacity, @RoomDescription)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@roomName", room.RoomName);
                cmd.Parameters.AddWithValue(@"@roomStatus", room.RoomStatus);
                cmd.Parameters.AddWithValue(@"@roomCapacity", room.RoomCapacity);
                cmd.Parameters.AddWithValue(@"@roomDescription", room.RoomDescription);

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
        public bool Update(Rooms room)
        {
            //create default return type and set its default to false
            bool isSuccess = false;

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data in our database
                string sql = @"UPDATE Room SET roomName=@RoomName, roomStatus=@RoomStatus, roomCapacity=@RoomCapacity, roomDescription=@RoomDescription WHERE Id=@RoomId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@roomName", room.RoomName);
                cmd.Parameters.AddWithValue(@"@roomStatus", room.RoomStatus);
                cmd.Parameters.AddWithValue(@"@roomCapacity", room.RoomCapacity);
                cmd.Parameters.AddWithValue(@"@roomDescription", room.RoomDescription);
                cmd.Parameters.AddWithValue(@"@Id", room.RoomId);

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