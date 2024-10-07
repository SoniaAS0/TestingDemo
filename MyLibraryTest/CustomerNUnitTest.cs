using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class CustomerNUnitTest
    {
        [Test]
        public void FullName_ReturnEmpty()
        {
            //1. Arrange
            Customer customer = new Customer();
            // 2. Act
            string result = customer.FullName;
            //3. Assert
            Assert.That(result, Is.WhiteSpace);
        }
        [Test]
        public void FullName_ReturnFullName()
        {
            //1. Arrange
            Customer customer = new Customer
            {
                FirstName = "John",
                LastName = "Doe"
            };
            //2. Act
            string result = customer.FullName;
            //3.Assert
            //Ejemplos de pruebas que se pueden hacer con respecto al metodo
            Assert.That(result, Is.Not.WhiteSpace);
            Assert.That(result, Does.Contain(""));
            Assert.That(result, Does.Contain("John"));
            Assert.That(result, Does.Contain("Doe"));
            Assert.That(result, Does.StartWith("John"));
            Assert.That(result, Does.EndWith("Doe"));
            Assert.That(result, Is.EqualTo("John Doe"));
            Assert.That(result, Is.EqualTo("john doe").IgnoreCase);


        }
    }
}
