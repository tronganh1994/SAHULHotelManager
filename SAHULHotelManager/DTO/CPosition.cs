using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CPosition
    {
        #region "attribus"
        private int id;
        private string name;
        private string departmentid;
        #endregion
        #region "construction"
        //khoi tao khong tham so
        public CPosition()
        {
            this.id = 0;
            this.name = "";
            this.departmentid = "";
        }
        //khoi tao co tham so
        public CPosition(int id1, string name1, string department1)
        {
            this.id = id1;
            this.name = name1;
            this.departmentid = department1;
        }
        #endregion
        #region "method"
        //show doi tuong
        public string ShowInfors()
        {
            return "\n\tID:" + id + "\n\tNAME: " + name + "\n\tDEPARTMENT ID:" + departmentid;
        }
        #endregion
    }
}