using System;
using ACM_BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM_BusinessLayerTests
{
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void ValidateOrderItemIsValid()
        {
            //Arrange 
            var orderItem = new OrderItem
            {
                Quantity = 5,
                ProductId = 1,
                PurchasePrice = 10.99m
            };

            var expected = true;

            //act  
            var actual = orderItem.Validate();

            //Assert 

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateOrderItemIsNotValid()
        {
            //Arrange 
            var orderItem = new OrderItem
            {
                Quantity = -5,
                ProductId = 1,
                PurchasePrice = -10.99m
            };

            var expected = false;

            //act  
            var actual = orderItem.Validate();

            //Assert 

            Assert.AreEqual(expected, actual);

        }
    }
}
