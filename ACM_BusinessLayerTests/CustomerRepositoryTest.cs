using System;
using System.Collections.Generic;
using ACM_BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM_BusinessLayerTests
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {

            //arrange  
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
               EmailAddress = "fbaggins@gmail.com",
               FirstName = "Frodo",
               LastName = "Baggins"
               };

            //act
            var actual = customerRepository.Retrieve(1);

            //assert 
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]

        public void RetrieveExistingWithAddress()
        {
            //Arrange 
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "fbaggins@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",

                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "bag end",
                        StreetLine2 = "bagshot row",
                        City = "Hobbit",
                        State = "Shire",
                        Country = "Middle Earth",
                        PostalCode = "144"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "Green dragon",
                        City = "Plano",
                        State = "shire",
                        Country = "Pluto",
                        PostalCode = "145"
                    }
                }
            };

            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i<1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);

                
            }

        }
    }

    }
