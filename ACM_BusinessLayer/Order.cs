using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
   public class Order : EntityBase, ILoggable
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        //to create the relationship between customer and order  
        public int CustomerId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        ////to create the relationship between orderitems  and order
        public List<OrderItem> OrderItems { get; set; }
        //to create the relationship between address and order
        public int ShippingAddressId { get; set; }

        public string Log() =>
            $"{OrderId}; Date: {this.OrderDate.Value.Date} Status: {this.EntityState.ToString()}";

        //override for debugging  
        public override string ToString() => $"{OrderDate.Value.Date} ({OrderId})";


        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
