using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CEmployee : CPerson
    {
        private int id;
        private DateTime hireDate;
        private int positionid;
        private int departmentid;
        private double basicsalary;


        public CEmployee() : base()
        {
            this.id = 0;
            this.hireDate = new DateTime(0000, 0, 0);
            this.positionid = 0;
            this.departmentid = 0;
            this.basicsalary = 0;
        }
        public CEmployee(string Name, int Age, int idcard, string address, int phone, string folk, DateTime dob, int id, DateTime hireDate, int positionid, int departmentid, double basicsalary) //:base(Name, Age, idcard, address, phone, folk, dob)
        {
            this.id = id;
            this.hireDate = hireDate;
            this.positionid = positionid;
            this.departmentid = departmentid;
            this.basicsalary = basicsalary;
        }


        public string ShowInfors()
        {
            base.ShowInfors();
            return id + "\t" + hireDate + "\t" + positionid + "\t" + departmentid + "\t" + basicsalary;
        }
    }
}
