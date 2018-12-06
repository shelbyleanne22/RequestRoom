﻿using System;
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
    public partial class ConfirmLogout : Form
    {
        private Controller.LogAttemptController attC = new Controller.LogAttemptController();
        private Form form = new Form();
        private int userID;
        public ConfirmLogout(Form f, int identifier)
        {
            userID = identifier;
            form = f;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOutConfirm_Click(object sender, EventArgs e)
        {
            attC.Insert("Logout", userID);
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "LogIn")
                    f.Show();
            }
            
            form.Close();
            this.Close();
        }

        private void btnLogoutCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmLogout_Load(object sender, EventArgs e)
        {

        }
    }
}
