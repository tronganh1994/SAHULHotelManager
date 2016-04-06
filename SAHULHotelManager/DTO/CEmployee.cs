using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CEmployee : CPerson
    {
        #region "Attributes"
        private int _id;
        private DateTime _hireDate;
        private int _positionId;
        private int _departmentId;
        private double _basicSalary;
        private float _ratio;
        private int _status;
        #endregion

        #region "Constructor"
        public CEmployee() : base()
        {
            this._id = 0;
            this._hireDate = new DateTime(0000, 0, 0);
            this._positionId = 0;
            this._departmentId = 0;
            this._basicSalary = 0;
            this._ratio = 0;
            this._status = 0;
        }
        /// <summary>
        /// Name, Age, dob, idcard, address, phone, folk

        public CEmployee(string name, int sex, DateTime doB, string idCard, string address, string phone, string folk, 
                         int id, DateTime hireDate, int positionId, int departmentId, double basicSalary, float ratio, int status) 
                         : base(name, sex, doB, idCard, address, phone, folk)
        {
            this._id = id;
            this._hireDate = hireDate;
            this._positionId = positionId;
            this._departmentId = departmentId;
            this._basicSalary = basicSalary;
            this._ratio = ratio;
            this._status = status;
        }
        #endregion

        #region "Methods"
        public new string ShowInfors()
        {
            return ""
                + "Id: " + this._id + '\n'
                + "Hire date: " + this._hireDate + '\n'
                + "Position Id: " + this._positionId + '\n'
                + "Department Id: " + this._departmentId + '\n'
                + "Basic salary: " + this._basicSalary + '\n'
                + "Ratio: " + this._ratio + '\n'
                + "Status: " + this._status + '\n'
                + base.ShowInfors();
        }
        #endregion
    }
}
