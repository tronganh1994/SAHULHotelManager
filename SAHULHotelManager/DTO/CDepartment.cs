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
        private int id;                               // mã bộ phận
        private string name;                          // tên bộ phận
        private int departmentParentid;               // mã bộ phận cha
        private int number;                           // số nhân viên
        #endregion

        #region "Constructor"
        public CDepartment()
        {
            this.id = 0;
            this.name = "Unknow";
            this.departmentParentid = 0;
            this.number = 0;
        }
        public CDepartment(int id, string name, int departmantParentid, int number)
        {
            this.id = id;
            this.name = name;
            this.departmentParentid = departmantParentid;
            this.number = number;
        }
        #endregion

        #region "Method"
        public string ShowInFors()
        {
            return "\n ID: " + id + "\n Name: " + name + "\n Department Parent ID: " + departmentParentid + "\n Number: " + number;
        }
        #endregion
    }
}