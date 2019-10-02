using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
public class AddressRepository
    {
        //Retrieve one address

        public Address Retrieve(int addressId)
        {
            //create the instance of the address class  
            //pass the address id  
            Address address = new Address(addressId);

            //temp data to return  

            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "bag end";
                address.StreetLine2 = "bagshot row";
                address.City = "Hobbit";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "bag end",
                StreetLine2 = "bagshot row",
                City = "Hobbit",
                State = "Shire",
                Country = "Middle Earth",
                PostalCode = "144"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "Green dragon",
                City = "Plano",
                State = "shire",
                Country = "Pluto",
                PostalCode = "145"
            };

            addressList.Add(address);


            return addressList;
        }
        //save  address

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges)
            {
                if (address.isValid)
                {
                    if (address.IsNew)
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
