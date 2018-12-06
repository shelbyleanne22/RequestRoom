using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestRoom
{
    public partial class ConfirmLogout : Form
    {
        Form form;
        public ConfirmLogout(Form f)
        {
            form = f;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOutConfirm_Click(object sender, EventArgs e)
        {
            //Add code that saves logout info here.

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
    }
}
