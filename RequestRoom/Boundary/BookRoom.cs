using RequestRoom.Controller;
using RequestRoom.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestRoom.Boundary
{
    public partial class BookRoom : Form
    {
        private int userID;
        private Request request = new Request();
        private Rooms rooms = new Rooms();
        private RequestController requestC = new RequestController();
        private RoomController roomsC = new RoomController();

        public BookRoom(int user)
        {
            userID = user;
            InitializeComponent();
        }

        private void calBookRoom_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.updateAvailable();
        }

        private void updateAvailable()
        {
            //load data in view
            DataTable dt = roomsC.Select();
            DGAvailableRooms.DataSource = dt;
        }

        private void btnLogOutBookARoom_Click(object sender, EventArgs e)
        {
            ConfirmLogout x = new ConfirmLogout(this);
            x.Show();
        }

        private void DGAvailableRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string x = DGAvailableRooms.SelectedRows[0].Cells[2].Value.ToString();
            if (x == "Available")
                this.btnBookRoom.Enabled = true;
            else
                this.btnBookRoom.Enabled = false;
        }


        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(DGAvailableRooms.SelectedRows[0].Cells[0].Value.ToString());
            string day = calBookRoom.SelectionStart.Day.ToString();
            string month = calBookRoom.SelectionStart.Month.ToString();
            string year = calBookRoom.SelectionStart.Year.ToString();
            string sqldate = year + '-' + month + '-' + day;
            request.RequestUserId = userID;
            request.RequestRoomId = x;
            request.RequestStatus = "Pending";
            request.RequestDate = sqldate;
            requestC.Insert(request);
        }

        private void DGAvailableRooms_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
