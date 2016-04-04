using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class COrderLine
    {
        private int id;
        private int orderId;
        private string title;
        private double price;

        public COrderLine()
        {
            this.id = 0;
            this.orderId = 0;
            this.title = "Unknown";
            this.price = 0;
        }
        public COrderLine(int id, int orderId, string title, double price)
        {
            this.id = id;
            this.orderId = orderId;
            this.title = title;
            this.price = price;
        }
        public string ShowInfors()
        {
            return id + "\t" + orderId + "\t" + title + "\t" + price;
        }
    }
}
