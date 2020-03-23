using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Model
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual Product Product { get; set; }
        public virtual Order Order { get; set; }
    }
}
