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
    public partial class ReviewRequests : Form
    {
        private int userID;
        private Request request = new Request();
        private RequestController reqC = new RequestController();
        private Rooms rooms = new Rooms();
        private RoomController roomC = new RoomController();

        public ReviewRequests(int user)
        {
            userID = user;
            InitializeComponent();
        }

        private void updateAvailable()
        {
            //load data in view
            DataTable dt = reqC.Select();
            DGRequests.DataSource = dt;
            checkAvailable();
        }

        private void checkAvailable()
        {
            string x = DGRequests.SelectedRows[0].Cells[3].Value.ToString();
            if (x == "Pending")
            {
                this.btnApproveRequest.Enabled = true;
                this.btnDenyRequest.Enabled = true;
            }
            else
            {
                this.btnApproveRequest.Enabled = false;
                this.btnDenyRequest.Enabled = false;
            }
        }

        private void ReviewRequests_Load(object sender, EventArgs e)
        {
            reqC.Select();
            updateAvailable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmLogout x = new ConfirmLogout(this, userID);
            x.Show();
        }

        private void DGRequests_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            checkAvailable();
        }

        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            request.RequestId = Convert.ToInt32(DGRequests.SelectedRows[0].Cells[0].Value.ToString());
            reqC.UpdateStatus(request, "Approved");
            updateAvailable();
        }

        private void btnDenyRequest_Click(object sender, EventArgs e)
        {
            request.RequestId = Convert.ToInt32(DGRequests.SelectedRows[0].Cells[0].Value.ToString());
            reqC.UpdateStatus(request, "Denied");
            updateAvailable();
        }
    }
}
