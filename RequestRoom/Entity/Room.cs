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
    class Rooms
    {
        //Properties
        public int RoomId { get; set; }

        public string RoomName { get; set; }

        public string RoomStatus { get; set; }

        public int RoomCapacity { get; set; }

        public string RoomDescription { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings[@"RequestRoom.Properties.Settings.RequestRoomConnectionString"].ConnectionString;

       
    }
}