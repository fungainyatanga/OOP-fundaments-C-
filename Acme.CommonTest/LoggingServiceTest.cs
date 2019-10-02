using System;
using System.Collections.Generic;
using ACM_BusinessLayer;
using Acme.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {

        [TestMethod]
        public void WriteToFileTest()
        {
            //arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaa@gmail.com",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            //Act
            LoggingService.WriteToFile(changedItems);

            //Assert
            //Nothing here to assert, however the test outputs the  logs

        }
    }
}
