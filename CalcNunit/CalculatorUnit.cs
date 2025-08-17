using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTesting;

namespace CalcNunit
{
    [TestFixture]
    public class CalculatorUnit
    {
        
        Calculator calculator;

        [SetUp]
        public void Setup()
        {
            // This method will run before each test
            calculator = new Calculator();
        }
        [Test]
        public void AddTest()
        {
            //3A
            //Arrange
           // Calculator calculator = new Calculator();       
            //Act
            int result = calculator.Add(1,4);
            //Assert
            Assert.That(result, Is.EqualTo(5));
           
           
            

        }
        [Test]
        public void AddTestReference()
        {
            //3A
            //Arrange
            Calculator calculator1 = new Calculator();
            Calculator calculator2 = new Calculator();
            //Act
            
            //Assert
            Assert.That(calculator1, Is.SameAs(calculator2));




        }
        [Test]
        public void DivideTest()
        {
            //3A
            //Arrange
           // Calculator calculator = new Calculator();
            //Act
            double result = calculator.Divide(10, 2);
            //Assert
            Assert.That(result, Is.EqualTo(5).Within(0.2));
        }
        [Test]
        public void DivideByZeroTest()
        {
            //3A
            //Arrange
           // Calculator calculator = new Calculator();
            //Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0), "0");
        }


    }
}
