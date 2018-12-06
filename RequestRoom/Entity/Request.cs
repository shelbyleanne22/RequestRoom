using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestRoom.Entity
{
    class Request
    {
        public int RequestId { get; set; }

        public int RequestUserId { get; set; }

        public int RequestRoomId { get; set; }

        public string RequestStatus { get; set; }

        public string RequestDate { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings[@"RequestRoom.Properties.Settings.RequestRoomConnectionString"].ConnectionString;

    }
}
