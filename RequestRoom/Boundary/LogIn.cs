using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace RequestRoom.Boundary
{
    public partial class LogIn : Form
    {
        static string connstring = ConfigurationManager.ConnectionStrings[@"RequestRoom.Properties.Settings.RequestRoomConnectionString"].ConnectionString;
        private Controller.LogAttemptController attC = new Controller.LogAttemptController();

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        SqlConnection con = new SqlConnection();
        public LogIn()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogInInfo_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {
              
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connstring;
            con.Open();
            string userID = txtUsername.Text;
            string password = txtPassword.Text;
            string passwordHash = ComputeSha256Hash(password);

            SqlCommand cmd = new SqlCommand(@"select Id, userID, password, type from [User] where userID='" + txtUsername.Text + @"'and password='" + ComputeSha256Hash(txtPassword.Text) + @"'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                //MessageBox.Show("Login Successful");
                SqlDataReader loginType = cmd.ExecuteReader();
                while (loginType.Read())
                {
                    int id = loginType.GetInt32(0);
                    string column = loginType.GetString(3);
                    attC.Insert("Login", id, userID, passwordHash);

                    if (column == "Requestor")
                    {
                        BookRoom bookroom = new BookRoom(id);
                        con.Close();
                        bookroom.Show();
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        this.Hide();
                        break;
                    }
                    else if (column == "Approver")
                    {
                        ReviewRequests reviewRequest = new ReviewRequests(id);
                        con.Close();
                        reviewRequest.Show();
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        this.Hide();
                        break;
                    }
                }
            }
            else
            {
                attC.Insert("LoginFail", -1, userID, passwordHash);
                MessageBox.Show("Invalid Login please check username and password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
