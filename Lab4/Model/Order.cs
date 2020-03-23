using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}
