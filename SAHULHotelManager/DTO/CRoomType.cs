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
        private string area;
        private string description;
        private int id;
        private int price;
        #endregion
        #region "khoi tao"
        public CRoomtype()
        {
            this.name = string.Copy("");
            this.area = string.Copy("");
            this.description = string.Copy("");
            this.id = 0;
            this.price = 0;
        }
        public CRoomtype(int id1, string name1, string area1, string description1, int price1)
        {
            this.id = id1;
            this.name = string.Copy(name1);
            this.area = string.Copy(area1);
            this.description = string.Copy(description1);
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
