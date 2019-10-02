using System;
using ACM_BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM_BusinessLayerTests
{
    [TestClass]
    public class ProductRespositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {

                ProductName = "Sunflowers",
                ProductDescription = "assosrted size set of 4 bright yellow sunflowers",
                CurrentPrice = 153.96m
            };
            //Act
            var actual = productRepository.Retrieve(2);

            //Assert
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }


        [TestMethod]
        public void SaveTestValid()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {

                ProductName = "Sunflowers",
                ProductDescription = "assosrted size set of 4 bright yellow sunflowers",
                CurrentPrice = 153.96m,
                HasChanges = true
            };
            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var updatedProduct = new Product(2)
            {

                ProductName = "Sunflowers",
                ProductDescription = "assosrted size set of 4 bright yellow sunflowers",
                HasChanges = true
            };
            //Act
            var actual = productRepository.Save(updatedProduct);

            //Assert
            Assert.AreEqual(false, actual);
        }

    }
    }
