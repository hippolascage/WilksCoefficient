using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WilksCoefficient.Tests
{
    [TestClass]
    public class TestCoefficientInit
    {
        [TestMethod]
        public void TestCoefficientInitMale()
        {
            double expected_male_a = -216.0475144;

            var maleCoefficients = new Coefficients(true);
            double actual_male_a = maleCoefficients.a;

            Assert.AreEqual(expected_male_a, actual_male_a);

        }
        [TestMethod]
        public void TestCoefficientInitFemale()
        {
            double expected_female_a = 594.31747775582;

            var femaleCoefficients = new Coefficients(false);
            double actual_female_a = femaleCoefficients.a;

            Assert.AreEqual(expected_female_a, actual_female_a);
        }
    }
}
