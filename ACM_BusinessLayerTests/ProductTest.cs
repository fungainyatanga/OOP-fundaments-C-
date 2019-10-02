using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ACM_BusinessLayer;
namespace ACM_BusinessLayerTests
{
    [TestClass]
    public class ProductTest
    {

        [TestMethod]
        public void ValidateValidProduct()
        {
            
            //Arrange
            var product = new Product
            {
                ProductName = "soap",
               CurrentPrice = 10.99m
            };
                      
            var expected = true;

            //Act 
            var actual = product.Validate();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateMissingPrice()
        {

            //Arrange 
            var product = new Product
            {
                ProductName = "soap"
                
            };
            var expected = false;

            //act  
            var actual = product.Validate();

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
