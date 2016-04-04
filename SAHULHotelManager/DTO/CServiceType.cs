using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    class CServiceType
    {
        #region "Atris"
        private int IdServiceType;
        private string name;
        private string description;
        #endregion

        #region "Constructor"
        public CServiceType()
        {
            IdServiceType = 0;
            name = description = "";
        }
        public CServiceType(int IdServiceType, string name, string description)
        {
            this.IdServiceType = IdServiceType;
            this.name = name;
            this.description = description;
        }
        #endregion
        #region
        public string ShowInfors()
        {
            return ("\n ID Cservicetype : " + IdServiceType + "\nName Cservicetype: " + name + "\n Description Cservicetype: " + description);
        }

        #endregion
    }
}