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
<<<<<<< HEAD

=======
      
>>>>>>> 78ff00f2610cece504c36f6cc313f5697d464b6e
        public COrderLine()
        {
            this.id = 0;
            this.orderId = 0;
            this.title = "Unknown";
            this.price = 0;
        }
<<<<<<< HEAD
        public COrderLine(int id, int orderId, string title, double price)
=======
        public COrderLine(int id,int orderId,string title,double price)
>>>>>>> 78ff00f2610cece504c36f6cc313f5697d464b6e
        {
            this.id = id;
            this.orderId = orderId;
            this.title = title;
            this.price = price;
        }
        public string ShowInfors()
        {
<<<<<<< HEAD
            return id + "\t" + orderId + "\t" + title + "\t" + price;
        }
=======
           
            return id+"\t" + orderId + "\t" + title + "\t" + price;
        } 
       

>>>>>>> 78ff00f2610cece504c36f6cc313f5697d464b6e
    }
    
}
