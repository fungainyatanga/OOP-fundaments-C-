
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
   public class OrderRepository
    {
        //retrieve oder  
        public Order Retrieve(int orderId)
        {
            //create instance of the order class 
            //pass in the requested id  

            Order order = new Order(orderId);

            //code that retrieves the defined order  

            //temp hard-coded values to return  

            if (orderId == 10)
            {
                //use the current year 
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }
            return order;
        }

        //Saves the current order  
        public bool Save(Order order)
        {
            var success = true;

            if (order.HasChanges)
            {
                if (order.isValid)
                {
                    if (order.IsNew)
                    {
                        //call a insert stored procedure  
                    }
                    else
                    {
                        //call an update stored procedure
                    }
                }
                else
                {
                    success = false;
                }
            }

            return success;
        }
       
    }
}
