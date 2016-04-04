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
        private int IdRoom;
        private string roomTypeid;
        private int number;
        private double area;
        private string status;
        #endregion

        #region "Constructor"
        public CRoom()
        {
            IdRoom = number = 0;
            roomTypeid = status = "";
            area = 0;
        }
        public CRoom(int IDroom, string RoomTypeID, int Number, double Area, string Status)
        {
            IdRoom = IDroom;
            roomTypeid = RoomTypeID;
            number = Number;
            area = Area;
            status = Status;
        }
        #endregion

        #region "Method"
        public string ShowInfors()
        {
            return ("\n ID: " + IdRoom + "\n type: " + roomTypeid + "\n number: " + number + "\n area : " + area + "\n stutus: " + area);
        }

        #endregion
    }
}
