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
        private int ID;
        private string name;
        private string departmentid;
        #endregion
        #region "construction"
        //khoi tao khong tham so
        public CPosition()
        {
            this.ID = 0;
            this.name = string.Copy("");
            this.departmentid = string.Copy("");
        }
        //khoi tao co tham so
        public CPosition(int ID1, string name1, string department1)
        {
            this.ID = ID1;
            this.name = string.Copy(name1);
            this.departmentid = string.Copy(department1);
        }
        #endregion
        #region "method"
        //show doi tuong
        public string ShowInfors()
        {
            return "\n\tID:" + ID + "\n\tNAME: " + name + "\n\tDEPARTMENT ID:" + departmentid;
        }
        #endregion
    }
}