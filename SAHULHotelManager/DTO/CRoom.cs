using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    class CRoom
    {
        #region "Atris"
        private int Id;
        private string roomTypeid;
        private int floor;
        private int status;
        #endregion

        #region "Constructor"
        public CRoom()
        {
            Id = floor = status = 0;
            roomTypeid = "";
        }
        public CRoom(int ID, string RoomTypeID, int Floor, int Status)
        {
            Id = ID;
            roomTypeid = RoomTypeID;
            floor = Floor;
            status = Status;
        }
        #endregion

        #region "Method"
        public string ShowInfors()
        {
            return ("\n ID: " + Id + "\n roomTypeid: " + roomTypeid + "\n floor: " + floor + "\n stutus: " + status);
        }

        #endregion
    }
}
