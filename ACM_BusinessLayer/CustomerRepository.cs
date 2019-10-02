using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
   public class CustomerRepository
    {

        //to use the address in customer repo we need a private prop for the  address and a new instance of the  address repo  created in the contactor  
        //this estblishes a collaborative relationship between the customerRepo and AddressRepo 

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        //Retrieve one customer  
       public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            //Code that retrieves the defined customer  
            //temporary hard coded values to return  this is inmemory dat 

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@gmail.com";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();  //populates the customer  address
            }

            return customer;
        }

        //Saves the current customer  

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges)
            {
                if (customer.isValid)
                {
                    if (customer.IsNew)
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
