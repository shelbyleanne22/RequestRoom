using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestRoom
{
    class Request
    {
        public int RequestId { get; set; }

        public int RequestUserId { get; set; }

        public int RequestRoomId { get; set; }

        public string RequestStatus { get; set; }

        public string RequestDate { get; set; }

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
                string sql = @"SELECT * FROM Request";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch(Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Inserting Data into Database
        public bool Insert(Request request)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create sql query to insert data
                string sql = @"INSERT INTO [Request] (userID, roomID, requestStatus, requestDate) "
                    + "VALUES (@userID, " + "@roomID, " + "@requestStatus, " + "@requestDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@userID", request.RequestUserId);
                cmd.Parameters.AddWithValue(@"@roomID", request.RequestRoomId);
                cmd.Parameters.AddWithValue(@"@requestStatus", request.RequestStatus);
                cmd.Parameters.AddWithValue(@"@requestDate", request.RequestDate);

                //open connection
                cmd.Connection.Open();
                int rows = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                //if query is successful then the value of rows will be greater than zero; else 0
                if(rows > 0)
                {
                    isSuccess = true;
                }
            }
            catch
            {
                
            }
            return isSuccess;
        }

        //method to update data in database from our application
        public bool Update(Request request)
        {
            //create default return type and set its default to false
            bool isSuccess = false;

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data in our database
                string sql = @"UPDATE Request SET userID=@RequestUserId, roomID=@RequestRoomId, requestStatus=@RequestStatus, requestDate=@RequestDate WHERE Id=@RequestId" ;

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@userID", request.RequestUserId);
                cmd.Parameters.AddWithValue(@"@roomID", request.RequestRoomId);
                cmd.Parameters.AddWithValue(@"@requestStatus", request.RequestStatus);
                cmd.Parameters.AddWithValue(@"@requestDate", request.RequestDate);
                cmd.Parameters.AddWithValue(@"@Id", request.RequestId);

                //open database connection
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //if the query runs successfully then the value of rows 
                if(rows>0)
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
