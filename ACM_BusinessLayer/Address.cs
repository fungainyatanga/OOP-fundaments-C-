﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM_BusinessLayer
{
public class Address : EntityBase
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = AddressId;
        }

        public int AddressId { get;private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        


        //Validates the address data  
        public override bool Validate()
        {
            var isValid = true;

            if (PostalCode == null) isValid = false;

            return isValid;
        }

        
    }
}
