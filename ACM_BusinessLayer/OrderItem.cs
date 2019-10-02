using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int OrderItemId { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public int Quantity{ get; set; }


        //Retrieve one order item

        public OrderItem Retrieve(int orderItemId)
        {
            //code to retrieve  the defined order item

            return new OrderItem();
        }

        public bool Save()
        {
            //Code that saves the defined order

            return true;
        }

        //Validate the order
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
