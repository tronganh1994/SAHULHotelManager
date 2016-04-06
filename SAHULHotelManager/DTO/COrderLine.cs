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
            this._id = 0;
            this._orderId = 0;
            this._title = String.Empty;
            this._price = 0;
        }
        public COrderLine(int id, int orderId, string title, double price)
        {
            this._id = id;
            this._orderId = orderId;
            this._title = title;
            this._price = price;
        }
        #endregion
        #region"Method"
        public string ShowInfors()
        {
            return "Id: " + _id+'\n'
                + "IdOrder: " + _orderId+'\n'
                + "Title: " + _title+'\n'
                + "Price: " + _price;
        }
        public List<COrderLine> GenerateObjects()
        {
            List<COrderLine> orderline = new List<COrderLine>(); 
            COrderLine orderline1 = new COrderLine(1, 1, "Title 1", 20);orderline.Add(orderline1);
            COrderLine orderline2 = new COrderLine(2, 2, "Title 2", 20); orderline.Add(orderline2);
            COrderLine orderline3 = new COrderLine(3, 3, "Title 3", 30); orderline.Add(orderline3);
            COrderLine orderline4 = new COrderLine(4, 4, "Title 4", 40); orderline.Add(orderline4);
            COrderLine orderline5 = new COrderLine(5, 5, "Title 5", 50); orderline.Add(orderline5);
            COrderLine orderline6 = new COrderLine(6, 6, "Title 6", 60); orderline.Add(orderline6);
            COrderLine orderline7 = new COrderLine(7, 7, "Title 7", 70); orderline.Add(orderline7);
            COrderLine orderline8 = new COrderLine(8, 8, "Title 8", 80); orderline.Add(orderline8);
            COrderLine orderline9 = new COrderLine(9, 9, "Title 9", 90); orderline.Add(orderline9);
            COrderLine orderline10 = new COrderLine(10,10, "Title 10", 10); orderline.Add(orderline10);
            return orderline;
        }
        #endregion

    }

}
