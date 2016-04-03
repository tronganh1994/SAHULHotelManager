using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    class CPerson
    {
        #region "Atris"
        private string Name;
        private int Age;
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
        public CPerson()
        {

        }
        public CPerson(string Name, int Age)
        {

        }
        #endregion

        #region "Method"
        public void Update(int Age)
        {

        }
        #endregion
    }
}
