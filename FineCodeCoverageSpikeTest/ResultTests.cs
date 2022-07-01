using System;
using NUnit;
using NUnit.Framework;
using Moq;
using FineCodeCoverageSpikeLibrary.Contracts;
using FineCodeCoverageSpikeLibrary;

namespace FineCodeCoverageSpikeTest {

    [TestFixture]
    public class ResultTests {
        
        IResult result;

        [SetUp]
        public void SetUp() {
            
        }

        [Test]
        public void Result_WhenResultReceiveAValue_IsSucceed() {

            //Arange
            result = new Result();

            //Act
            result.Result = 1;

            //Assert
            Assert.AreEqual(result.Result, 1);
        }

        [Test]
        public void Result_WhenResultReceiveAValue_IsFailed() {

            //Arange
            var mockResult = new Mock<IResult>();
            mockResult.SetupSet(x => x.Result = 1).Throws(new NullReferenceException());
            result = mockResult.Object;

            //Act
            //Assert
            Assert.Throws<NullReferenceException>(() => result.Result = 1);

        }
        
    }
}
