using System;
using ACM_BusinessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM_BusinessLayerTests
{
    [TestClass]
    public class CustomerTest
    {
        //class properties tests 
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Balboa"
            };

            string expected = "Balboa,Bilbo";

            //Act 

            string actual = customer.FullName;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FirstNameValid()
        {
            //Arrange 
            Customer customer = new Customer();
            customer.FirstName = "Bilbo";
            string expected = "Bilbo";

            //Act 
            string actual = customer.FirstName;

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void LastNameValid()
        {
            //Arrange 
            Customer customer = new Customer();
            customer.LastName = "Bilbo";
            string expected = "Bilbo";

            //Act 
            string actual = customer.LastName;

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //Arrange 
            Customer customer = new Customer
            {
                LastName = "Bilbo"
            };
            string expected = "Bilbo";

            //Act 
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange 
            Customer customer = new Customer
            {
                FirstName = "Bilbo"
            };
            string expected = "Bilbo";

            //Act 
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);

           }

        [TestMethod]
        public void StaticTest()
        {
            //Arrange 
            var c1 = new Customer
            {
                FirstName = "Bilbo"
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Bob"
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "John"
            };
            Customer.InstanceCount += 1;

            //Act 


            //Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        //class method tests  

        [TestMethod]
        public void ValidateValid()
        {
            //Arrange  
            var customer = new Customer
            {
                LastName = "Baggins",
                EmailAddress = "fbaggins@gamil.com"
            };

            var expected = true;

            //Act  
            var actual = customer.Validate();

            //Assert

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //Arrange  
            var customer = new Customer
            {
                
                EmailAddress = "fbaggins@gamil.com"
            };

            var expected = false;

            //Act  
            var actual = customer.Validate();

            //Assert

            Assert.AreEqual(expected, actual);

        }
    }
}
