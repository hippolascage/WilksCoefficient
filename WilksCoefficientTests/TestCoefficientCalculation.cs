using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WilksCoefficient.Tests
{
    [TestClass]
    public class TestCoefficientCalculation
    {
        [TestMethod]
        public void TestCalc_100_100_M()
        {
            double expectedScore = 60.86;
            var wilksCoefficient = new WilksCoefficient(100, 100, true);
            var actualScore = wilksCoefficient.GetScore();
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void TestCalc_100_101_M()
        {
            double expectedScore = 61.47;
            var wilksCoefficient = new WilksCoefficient(101, 100, true);
            var actualScore = wilksCoefficient.GetScore();
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void TestCalc_100_100_F()
        {
            double expectedScore = 83.26;
            var wilksCoefficient = new WilksCoefficient(100, 100, false);
            var actualScore = wilksCoefficient.GetScore();
            Assert.AreEqual(expectedScore, actualScore);
        }

        [TestMethod]
        public void TestCalc_100_101_F()
        {
            double expectedScore = 84.09;
            var wilksCoefficient = new WilksCoefficient(101, 100, false);
            var actualScore = wilksCoefficient.GetScore();
            Assert.AreEqual(expectedScore, actualScore);
        }

        /* - this test will fail - see what teamcity does
        [TestMethod]
        public void TestCalc_YngvarChristensen()
        {
            double expectedScore = 669.3;
            var wilksCoefficient = new WilksCoefficient(1230, 168.02, false);
            var actualScore = wilksCoefficient.GetScore();
            Assert.AreEqual(expectedScore, actualScore);
        }
        */
    }
}
