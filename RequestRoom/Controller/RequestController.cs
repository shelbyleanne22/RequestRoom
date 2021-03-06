﻿using RequestRoom.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRoom.Controller
{
    class RequestController
    {
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
        public bool Insert(Request request)
        {
            //creating a default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //create sql query to insert data
                string sql = "INSERT INTO Request (userID, roomID, requestStatus, requestDate) "
                    + "VALUES (@userID, @roomID, @requestStatus, @requestDate)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@userID", SqlDbType.Int);
                cmd.Parameters["@userID"].Value = request.RequestUserId;
                cmd.Parameters.Add("@roomID", SqlDbType.Int);
                cmd.Parameters["@roomID"].Value = request.RequestRoomId;
                cmd.Parameters.Add("@requestStatus", SqlDbType.Int);
                cmd.Parameters["@requestStatus"].Value = request.RequestStatus;
                cmd.Parameters.Add("@requestDate", SqlDbType.Int);
                cmd.Parameters["@requestDate"].Value = request.RequestDate;

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
        public bool UpdateStatus(Request request, string status)
        {
            //create default return type and set its default to false
            bool isSuccess = false;

            //sql connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                //sql to update data in our database
                string sql = @"UPDATE Request SET requestStatus=@RequestStatus WHERE Id=@RequestId";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue(@"@requestStatus", status);

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
