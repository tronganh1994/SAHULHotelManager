using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CRoomtype
    {
        #region "thuoc tinh"
        private string name;
        private float area;
        private string description;
        private int id;
        private double price;
        #endregion
        #region "khoi tao"
        public CRoomtype()
        {
            this.name = "";
            this.area = 0;
            this.description = "";
            this.id = 0;
            this.price = 0;
        }
        public CRoomtype(int id1, string name1, float area1, string description1, double price1)
        {
            this.id = id1;
            this.name = name1;
            this.area = area1;
            this.description = description1;
            this.price = price1;
        }
        #endregion
        #region "phuong thuc"
        public string showroomtype()
        {
            return "\n                       chi tiet Roomtype              " + "\nid: " + id + "\nname: " + name + "\narea: " + area + "\ndescription: " + description + "\nprice: {0}" + price;
        }
        #endregion
    }
}
