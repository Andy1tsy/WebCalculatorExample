using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebCalculatorExample.Tests
{
    using CalculatorManager;
    using DBManager;
    [TestClass]
    public class CalcMethodsUnitTest
    {
        [TestMethod]
        public void AdditionTestCorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 56;
            var secondValue = 75;

            //Act
            manager.Addition(firstValue, secondValue);

            //Assert
            Assert.AreEqual(manager.Expression.ResultValue, 131);
        }
   

        [TestMethod]
        public void AdditionTestIncorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 43;
            var secondValue = 87;

            //Act
            manager.Addition(firstValue, secondValue);

            //Assert
            Assert.AreNotEqual(manager.Expression.ResultValue, 131);
        }

        [TestMethod]
        public void SubstractionTestCorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 97;
            var secondValue = 32;

            //Act
            manager.Substraction(firstValue, secondValue);

            //Assert
            Assert.AreEqual(manager.Expression.ResultValue, 65);
        }

        [TestMethod]
        public void SubstractionTestIncorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 54;
            var secondValue = 32;

            //Act
            manager.Substraction(firstValue, secondValue);

            //Assert
            Assert.AreNotEqual(manager.Expression.ResultValue, 45);
        }

        [TestMethod]
        public void MultiplyingTestCorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 12;
            var secondValue = 14;

            //Act
            manager.Multiplying(firstValue, secondValue);

            //Assert
            Assert.AreEqual(manager.Expression.ResultValue, 168);
        }

        [TestMethod]
        public void MultiplyingTestIncorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 34;
            var secondValue = 27;

            //Act
            manager.Multiplying(firstValue, secondValue);

            //Assert
            Assert.AreNotEqual(manager.Expression.ResultValue, 536);
        }

        [TestMethod]
        public void DividingTestCorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 96;
            var secondValue = 8;

            //Act
            manager.Dividing(firstValue, secondValue);

            //Assert
            Assert.AreEqual(manager.Expression.ResultValue, 12);
        }

        [TestMethod]
        public void DividingTestIncorrect()
        {
            //arrange
            var manager = new CalcManager(new DbManager());
            var firstValue = 738;
            var secondValue = 45;

            //Act
            manager.Dividing(firstValue, secondValue);

            //Assert
            Assert.AreNotEqual(manager.Expression.ResultValue, 32);
        }

}
}
