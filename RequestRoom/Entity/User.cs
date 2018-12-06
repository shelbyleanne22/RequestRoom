using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestRoom.Entity
{
    class User
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Type { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings[@"RequestRoom.Properties.Settings.RequestRoomConnectionString"].ConnectionString;

    }
}

