using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer(): this(0)
        {

        }
        //allow setting customer id with a constructor  

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
       public List<Address> AddressList{ get; set; }
        
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string  EmailAddress { get; set; }
        public string FirstName { get; set; }
        
        public static int InstanceCount { get; set; }
        public string  FullName {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ",";
                    }

                    fullName += FirstName;
                }

                return fullName;
            }
          }
        private string _lastName;
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
        //override for debugging  

        //adding logging  
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";

        public override string ToString() => FullName;
        //validates the customer data
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

      
    }
}
