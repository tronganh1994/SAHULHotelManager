using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    class COrder
    {
        public class corder
        {
            private int id;
            private DateTime createTime;
            private int status;
            private String guestld;
            private String employeeld;
            public corder()
            {
                id = 0;
                DateTime createTime = DateTime.Now;
                status = 1;
                guestld = "kh12";
                employeeld = "nv1";

            }
            public corder(corder a)
            {
                this.id = a.id;
                this.createTime = a.createTime;
                this.guestld = a.guestld;
                this.employeeld = a.employeeld;
            }
            public corder(int id, DateTime createTime, int status, string guestld, string employeeld)
            {
                this.id = id;
                this.createTime = createTime;
                this.guestld = guestld;
                this.employeeld = employeeld;
            }
            public string Show()
            {
                return "\n id" + id + " \n createTime " + createTime + "\n guestld : " + guestld + "\n employeeld : " + employeeld;
            }



        }
    }
}
