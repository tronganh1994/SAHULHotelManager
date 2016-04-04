using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    class CDepartment
    {
        #region "Attribus"
        private string ID;                      // mã bộ phận
        private string Name;                    // tên bộ phận
        private string DepartmentParentID;      // mã bộ phận cha
        private int Number;                     // số nhân viên của bộ phận
        #endregion

        #region "Property"
        public new string ToString
        {
            get
            {
                return ID + "\t" + Name + "\t" + DepartmentParentID + "\t" + Number;
            }
        }
        #endregion

        #region "Constructor"
        public CDepartment()
        {
            this.ID = "Unknow";
            this.Name = "Unknow";
            this.DepartmentParentID = "Unknow";
            this.Number = 0;
        }
        public CDepartment(string ID, string Name, string DepartmantParentID, int Number)
        {
            this.ID = ID;
            this.Name = Name;
            this.DepartmentParentID = DepartmantParentID;
            this.Number = Number;
        }
        #endregion

        #region "Method"
        public string ShowInFors()
        {
            return ID + "\t" + Name + "\t" + DepartmentParentID + "\t" + Number;
        }
        #endregion
    }
}
