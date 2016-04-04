using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CPerson
    {
        #region "Atris"
        private string Name;
        private int Age;
        private int idcard;
        private string address;
        private int phone;
        private string folk;
        private DateTime dob;

        #endregion

        #region "Property"
        public new string ToString
        {
            get
            {
                return Name + " " + Age;
            }
        }
        #endregion

        #region "Constructor"

        ~CPerson() { }


        public CPerson()

        {
            this.Name = String.Empty;
            this.Age = 0;
            this.idcard = 0;
            this.address = String.Empty;
            this.phone = 0;
            this.folk = String.Empty;
            this.dob = new DateTime(0000, 0, 0);
        }
        public CPerson(string Name, int Age, int idcard, string address, int phone, string folk, DateTime dob)
        {
            this.Name = Name;
            this.Age = Age;
            this.idcard = idcard;
            this.address = address;
            this.phone = phone;
            this.folk = folk;
            this.dob = dob;
        }
        #endregion
        public string ShowInfors()
        {

            return Name + "\t" + Age + "\t" + idcard + "\t" + address + "\t" + phone + "\t" + folk + "\t" + dob;
        }
        #region "Method"
        public void Update(int Age)
        {

        }
        #endregion
    }
}
