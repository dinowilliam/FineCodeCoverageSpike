using System;
using NUnit;
using NUnit.Framework;
using Moq;
using FineCodeCoverageSpikeLibrary.Contracts;
using FineCodeCoverageSpikeLibrary;

namespace FineCodeCoverageSpikeTest {

    [TestFixture]
    public class CalculatorTests {
        
        Mock<IResult> mockResult;

        [SetUp]
        public void SetUp() {
            mockResult = new Mock<IResult>();            
        }

        [Test]
        public void Calculator_WhenAddZero_IsSucceed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 0);
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act
            calculator.Add(0);

            //Assert
            Assert.AreEqual(mockResultObject.Result, 0);
        }

        [Test]
        public void Calculator_WhenAddZero_IsFailed() {

            //Arange
            mockResult.Setup(value => value.Result).Throws(new NullReferenceException());
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            //Assert
            Assert.Throws<NullReferenceException>(() => calculator.Add(0));
        }

        [Test]
        public void Calculator_WhenAddAValue_IsSucceed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 0);
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act
            calculator.Add(3);

            //Assert
            Assert.AreEqual(mockResultObject.Result, 3);
        }

        [Test]
        public void Calculator_WhenAddAValue_IsFailed() {

            //Arange
            mockResult.Setup(value => value.Result).Throws(new NullReferenceException());
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            //Assert
            Assert.Throws<NullReferenceException>(() => calculator.Add(3));
        }

        [Test]
        public void Calculator_WhenSubtractZero_IsSucceed() {

            //Arange            
            mockResult.SetupProperty(result => result.Result, 1);
            var mockResultObject = mockResult.Object;            
            var calculator = new Calculator(mockResultObject);

            //Act
            calculator.Sub(1);

            //Assert
            Assert.AreEqual(mockResultObject.Result, 0);
        }

        [Test]
        public void Calculator_WhenSubtractZero_IsFailed() {

            //Arange
            mockResult.Setup(value => value.Result).Throws(new NullReferenceException());
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            //Assert
            Assert.Throws<NullReferenceException>(() => calculator.Sub(0));
        }

        [Test]
        public void Calculator_WhenSubtractAValue_IsSucceed() {

            //Arange            
            mockResult.SetupProperty(result => result.Result, 10);
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act
            calculator.Sub(5);

            //Assert
            Assert.AreEqual(mockResultObject.Result, 5);
        }

        [Test]
        public void Calculator_WhenSubtractAValueFromZero_IsFailed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 0);
            mockResult.Setup(value => value.Result).Throws(new NullReferenceException());
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            //Assert
            Assert.Throws<NullReferenceException>(() => calculator.Sub(5));
        }

        [Test]
        public void Calculator_WhenSubtractAValueFromZero_IsSucceed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 0);
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act
            calculator.Sub(5);

            //Assert
            Assert.AreEqual(mockResultObject.Result, -5);
        }

        [Test]
        public void Calculator_WhenDivideAValueForZero_IsFailed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 1);
            mockResult.Setup(value => value.Result).Throws(new NullReferenceException());
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            //Assert
            Assert.Throws<NullReferenceException>(() => calculator.Div(0));
        }

        [Test]
        public void Calculator_WhenDivideAValueForZero_IsSucceed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 1);
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);            
            
            //Act            
            //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(0));
        }

        [Test]
        public void Calculator_WhenDivideAValue_IsFailed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 2);
            mockResult.Setup(value => value.Result).Throws(new NullReferenceException());
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            //Assert
            Assert.Throws<NullReferenceException>(() => calculator.Div(2));
        }

        [Test]
        public void Calculator_WhenDivideAValue_IsSucceed() {

            //Arange
            mockResult.SetupProperty(result => result.Result, 2);
            var mockResultObject = mockResult.Object;
            var calculator = new Calculator(mockResultObject);

            //Act            
            calculator.Div(2);

            //Assert
            Assert.AreEqual(mockResultObject.Result, 1);
        }
    }
}
