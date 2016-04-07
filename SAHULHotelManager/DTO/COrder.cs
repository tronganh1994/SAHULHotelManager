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
 public List<corder> GenerateObjects()
        {
            List<corder> order = new List<corder>();
            order.Add(new corder(1,new DateTime(1995,2,20),1,"KH1","NV1"));
            order.Add(new corder(2, new DateTime(2016, 2, 12), 2, "KH2", "NV1"));
            order.Add(new corder(3, new DateTime(2016, 3, 12), 3, "KH3", "NV2"));
            order.Add(new corder(4, new DateTime(1995, 2, 20), 4, "KH4", "NV3"));
            order.Add(new corder(5, new DateTime(1995, 2, 20), 5, "KH5", "NV4"));
            order.Add(new corder(6, new DateTime(1995, 2, 20), 6, "KH6", "NV5"));
            order.Add(new corder(7, new DateTime(1995, 2, 20), 7, "KH7", "NV6"));
            order.Add(new corder(8, new DateTime(1995, 2, 20), 8, "KH8", "NV7"));
            order.Add(new corder(9, new DateTime(1995, 2, 20), 9, "KH9", "NV8"));
            order.Add(new corder(10, new DateTime(1995, 2, 20), 10, "KH10", "NV9"));
            return order;
          
        }
    
}
