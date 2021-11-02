using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculation.Tests
{
    [TestClass()]
    public class CalculationInfoTests
    {
        [TestMethod()]
        public void SellArticleTest1()
        {
            //arrange
            int expected = 1;

            //act
            var result = CalculationInfo.SellArticle(9);

            //assert
            Assert.AreEqual(expected, result.currentStock);
            Assert.AreEqual(result.transactionOk, true);
        }

        [TestMethod()]
        public void SellArticleTest2()
        {
            //arrange
            int expected = 1;

            //act
            var result = CalculationInfo.SellArticle(11);

            //assert
            Assert.AreEqual(expected, result.currentStock);
            Assert.AreEqual(result.transactionOk, true);
        }
    }
}