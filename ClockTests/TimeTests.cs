using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Clock.Tests
{
    [TestClass()]
    public class TimeTests
    {
        [TestMethod()]
        public void GetCornerTest0H5Min()
        {
            //Arrange
            var time = new Time()
            {
                Hour = 0,
                Minute = 5
            };
            var expextedReturn = 27.5;

            //Actual
            var actualReturn = time.GetCorner();

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void GetCornerTest12H5Min()
        {
            //Arrange
            var time = new Time()
            {
                Hour = 12,
                Minute = 5
            };
            var expextedReturn = 27.5;

            //Actual
            var actualReturn = time.GetCorner();

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void GetCornerTest24H5Min()
        {
            //Arrange
            var time = new Time()
            {
                Hour = 24,
                Minute = 5
            };
            var expextedReturn = 27.5;

            //Actual
            var actualReturn = time.GetCorner();

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        
        [TestMethod()]
        public void GetCornerTest8H22Min()
        {
            //Arrange
            var time = new Time()
            {
                Hour = 8,
                Minute = 22
            };
            var expextedReturn = 119;

            //Actual
            var actualReturn = time.GetCorner();

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void GetCornerTest20H22Min()
        {
            //Arrange
            var time = new Time()
            {
                Hour = 8,
                Minute = 22
            };
            var expextedReturn = 119;

            //Actual
            var actualReturn = time.GetCorner();

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void ValidateHoursInputLessThanZero()
        {
            //Arrange
            var time = new Time();
            var expextedReturn = "";

            //Actual
            var actualReturn = time.ValidateHoursInput("-1");

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void ValidateHoursInputMoreThan24()
        {
            //Arrange
            var time = new Time();
            var expextedReturn = "";

            //Actual
            var actualReturn = time.ValidateHoursInput("25");

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void ValidateHoursInputCorect()
        {
            //Arrange
            var time = new Time();
            var expextedReturn = "24";

            //Actual
            var actualReturn = time.ValidateHoursInput("24");

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void ValidateMinutesInputLessThanZero()
        {
            //Arrange
            var time = new Time();
            var expextedReturn = "";

            //Actual
            var actualReturn = time.ValidateMinutesInput("-1");

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void ValidateMinutesInputMoreThan59()
        {
            //Arrange
            var time = new Time();
            var expextedReturn = "";

            //Actual
            var actualReturn = time.ValidateMinutesInput("60");

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }

        [TestMethod()]
        public void ValidateMinutesInputCorect()
        {
            //Arrange
            var time = new Time();
            var expextedReturn = "59";

            //Actual
            var actualReturn = time.ValidateMinutesInput("59");

            //Assert
            Assert.AreEqual(actualReturn, expextedReturn);
        }
                
    }
}