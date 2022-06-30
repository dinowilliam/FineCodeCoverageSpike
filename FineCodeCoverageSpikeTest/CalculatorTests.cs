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
            mockResult.Setup(value => value.Result).Returns(0);
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
            mockResult.Setup(value => value.Result).Returns(3);
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
    }
}
