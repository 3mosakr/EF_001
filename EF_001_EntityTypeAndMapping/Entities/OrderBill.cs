﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_001_EntityTypeAndMapping.Entities
{
    public class OrderBill
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal SubTotal { get; set; }

        public override string ToString()
        {
            return
                $"#{OrderId}: {OrderDate}, " +
                $"{ProductName} X {Quantity} @ {UnitPrice.ToString("C")} " +
                $"..... {SubTotal.ToString("C")}";
        }
    }
}
