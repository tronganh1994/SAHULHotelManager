using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CDepartment
    {
        #region "Attribus"
        private int _id;                               // mã bộ phận
        private string _name;                          // tên bộ phận
        private int _departmentParentid;               // mã bộ phận cha
        private CEmployee _chief;
        #endregion

        #region "Property"
        public new string ToString
        {
            get
            {
                return this.ShowInFors();
            }
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int DepartmentParentid
        {
            get
            {
                return _departmentParentid;
            }

            set
            {
                _departmentParentid = value;
            }
        }

        public CEmployee Chief
        {
            get
            {
                return _chief;
            }

            set
            {
                _chief = value;
            }
        }
        #endregion

        #region "Constructor"
        public CDepartment()
        {
            this.Id = 0;
            this.Name = String.Empty;
            this.DepartmentParentid = 0;
            this.Chief = new CEmployee();
        }
        public CDepartment(CDepartment CDepartment)
        {
            this.Id = CDepartment.Id;
            this.Name = CDepartment.Name;
            this.DepartmentParentid = CDepartment.DepartmentParentid;
            this.Chief = CDepartment.Chief;
        }
        public CDepartment(int id, string name, int departmantParentid)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentParentid = departmantParentid;
            this.Chief = null;
        }
        public CDepartment(int id, string name, int departmantParentid, CEmployee chief)
        {
            this.Id = id;
            this.Name = name;
            this.DepartmentParentid = departmantParentid;
            this.Chief = chief;
        }
        #endregion

        #region "Methods"
        public string ShowInFors()
        {
            return "ID: " + Id + '\n'
                   + "Name: " + Name + '\n'
                   + "Department Parent ID: " + DepartmentParentid + '\n'
                   + "Chief: " + Chief.ToString;
        }

        public List<CDepartment> GenerateObjects()
        {
            List<CDepartment> Departments = new List<CDepartment>();
            Departments.Add(new CDepartment(1, "bộ phận giám đốc", 0));
            Departments.Add(new CDepartment(2, "bộ phận kỹ thuật", 1));
            Departments.Add(new CDepartment(3, "bộ phận đặt phòng", 1));
            Departments.Add(new CDepartment(4, "bộ phận dọn phòng", 1));
            Departments.Add(new CDepartment(5, "bộ phận tiền sảnh", 1));
            Departments.Add(new CDepartment(6, "bộ phận nhà hàng và quầy uống", 1));
            Departments.Add(new CDepartment(7, "bộ phận nhân sự", 1));
            Departments.Add(new CDepartment(8, "bộ phận kế toán", 1));
            Departments.Add(new CDepartment(9, "bộ phận hướng dẫn khách hàng", 1));
            Departments.Add(new CDepartment(10, "bộ phận quan hệ khách hàng", 1));
            return Departments;
        }
        #endregion
    }
}