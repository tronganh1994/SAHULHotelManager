using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class COrderLine
    {
        #region "Attributes"
        private int _id;
        private int _orderId;
        private string _title;
        private double _price;
        #endregion

        #region"Property"
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
        public int OrderId
        {
            get
            {
                return _orderId;
            }

            set
            {
                _orderId = value;
            }
        }
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }
        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }
        public new string ToString
        {
            get { return ShowInfors(); }
        }
        #endregion

        #region"Constructor"
        public COrderLine(COrderLine orderline)
        {
            this.Id = orderline.Id;
            this.OrderId = orderline.OrderId;
            this.Title = orderline.Title;
            this.Price = orderline.Price;
        }

        public COrderLine()
        {
            this.Id = 0;
            this.OrderId = 0;
            this.Title = String.Empty;
            this.Price = 0;
        }

        public COrderLine(int id, int orderId, string title, double price)
        {
            this.Id = id;
            this.OrderId = orderId;
            this.Title = title;
            this.Price = price;
        }
        #endregion

        #region"Method"
        public string ShowInfors()
        {
            return "Id: " + Id + '\n'
                + "IdOrder: " + OrderId + '\n'
                + "Title: " + Title + '\n'
                + "Price: " + Price;
        }

        public List<COrderLine> GenerateObjects()
        {
            List<COrderLine> orderline = new List<COrderLine>();
            orderline.Add(new COrderLine(1, 1, "Đặt Phòng", 20));
            orderline.Add(new COrderLine(1, 1, "Đặt Phòng", 20));
            orderline.Add(new COrderLine(2, 1, "Trả Phòng", 256));
            orderline.Add(new COrderLine(3, 1, "Trả Phòng", 100));
            orderline.Add(new COrderLine(4, 1, "Đặt Phòng", 5962));
            orderline.Add(new COrderLine(5, 1, "Trả Phòng", 58));
            orderline.Add(new COrderLine(6, 1, "Đặt Phòng", 2533));
            orderline.Add(new COrderLine(7, 1, "Đặt Phòng", 70));
            orderline.Add(new COrderLine(8, 1, "Trả Phòng", 1000));
            orderline.Add(new COrderLine(9, 1, "Trả Phòng", 5000));
            orderline.Add(new COrderLine(10, 1, "Đặt Phòng", 50)); 
            return orderline;
        }
        #endregion

    }

}
