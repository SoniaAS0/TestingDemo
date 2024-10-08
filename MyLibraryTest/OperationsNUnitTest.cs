using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    [TestFixture]
    public class OperationsNUnitTest
    {
        [Test]
        public void Add_InputNumbers_ReturnNumber()
        {
            //1. Arrange
         Operations operations = new Operations();
            int number1 = 2;
            int number2 = 5;
            int expectedResult = 7;
            //2. Act
            int result= operations.Add(number1, number2);

            //3. Assert
            Assert.That(result, Is.EqualTo(expectedResult)); //en vez de expected result podriamos poner 7 y quitar de Arrange el int de expected
            Assert.That(result, Is.Not.EqualTo(8));
            Assert.That(result, Is.Not.EqualTo(6));
        }
        [Test]
        [TestCase(10)] //si en el test case añadimos , ExpectedResult= true o false  
        [TestCase(12)]//cambiariamos el void por bool y quitariamos el assert y solo pondríamos return result;
        [TestCase(14)]
        public void IsEven_InputNumber_ReturnTrue(int number) 
        {
            //1. Arrange
            Operations operations=new Operations();
            //2. Act
            var result = operations.IsEven(number);
            //3. Assert
            Assert.That(result, Is.True);
        }
        [Test]
        [TestCase(2.2, 1.2)]
        [TestCase(2.23,1.24)]
        public void AddDecimal_inputDoubleNumbers_ReturnsDoubleNumber(double number1, double number2) 
        {
            //1. Arrange
            Operations operations=new ();

            double result = operations.AddDecimal(number1, number2);

            Assert.That(result, Is.EqualTo(3.4).Within(0.1));


        }
        public void GetEventNumbers_ReturnsEvenNumbers()
        {
            //Arrange
            int start = 1;
            int end = 20;
            List<int> expectedNumbers = new List<int>(2, 4, 6, 8, 10, 12, 14, 16, 18, 20);
            //Act
            List<int> result = Operations.GetEvenNumbers(start, end);

            //Assert
            Assert.That(expectedNumbers == result);
        }
    }
}
