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
    public partial class ReviewRequests : Form
    {
        public ReviewRequests()
        {
            InitializeComponent();
        }

        private void ReviewRequests_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfirmLogout confirm = new ConfirmLogout(this);
            confirm.Show();
        }
    }
}
