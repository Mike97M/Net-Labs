using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
      
    }
}
