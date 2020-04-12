using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderViewer.Model
{
    class CustomerOrderDetailModel
    {
        public int CustomerOrderID { get; set; }
        public int CustomerID { get; set; }
        public int ItemID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
