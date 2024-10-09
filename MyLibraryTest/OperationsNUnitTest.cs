using NUnit.Framework;
using System;
using System.Collections;
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
        [Test]
      
        public void GetEventNumbersInputRangeReturnsEvenNumbers()
        {
            //Arrange
            Operations operations = new Operations();
            int start = 1;
            int end = 10;
           
            //Act
            var result = operations.GetEvenNumbers(start, end);

            //Assert
            Assert.That(end - start>=2, Is.True);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result[0],Is.TypeOf<int>());
            Assert.That(result, Does.Not.Contain(-1));
            Assert.That(result.Count, Is.EqualTo(5));
            Assert.That(result, Has.Exactly(5).Items);
            Assert.That(result, Is.Ordered);
            Assert.That(result, Has.Member(2));
            Assert.That(result, Has.Member(6));
            Assert.That(result, Has.Member(10));
            Assert.That(result, Has.No.Member(12));
            Assert.That(result, Has.All.GreaterThanOrEqualTo(0));
            Assert.That(result, Is.EquivalentTo(new[] { 2, 4, 6, 8, 10}));
            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result, Is.Unique);


        }
        [TestCase(1, 20)]
        [TestCase(1, 1000)]
        public void GetEventNumbers_InputRange_ReturnsEvenNumbers(int start, int end)
        {
            //Arrange
            Operations operations = new();
            int startNumber = start % 2 == 0 ? start : start + 1;
            //si el elemento start es par (?)entonces start (:)sino start+1 para que sea par
            int endNumber = end % 2 == 0 ? end : end - 1;
            int middleNumber = (startNumber + endNumber) / 2;
            middleNumber= middleNumber %2 ==0 ? middleNumber : middleNumber + 1;
            //Act
            var result = operations.GetEvenNumbers(start, end);

            //Assert
           
            Assert.That(end - start >= 2, Is.True);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.TypeOf<List<int>>());
            Assert.That(result[0], Is.TypeOf<int>());
            Assert.That(result, Is.Ordered);
            Assert.That(result, Has.No.All.LessThan(startNumber));
            Assert.That(result, Does.Not.Contain(-1));
            Assert.That(result, Has.Member(middleNumber));
            Assert.That(result, Has.Member(endNumber));
            Assert.That(result, Has.Member(startNumber));
            Assert.That(result, Has.No.All.GreaterThan(endNumber));
            Assert.That(result[0], Is.EqualTo(2));
            Assert.That(result, Is.Unique);


        }
    }
}


