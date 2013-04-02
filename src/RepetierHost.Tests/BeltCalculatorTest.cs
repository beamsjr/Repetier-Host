using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RepetierHost.model;

namespace RepetierHost.Tests
{
    [TestFixture]
    public class BeltCalculatorTest 
    {
        [Test]
        public void CanCalculateBeltStepsPerMM()
        {
            var calculator = new BeltCalculator(1.8,0.0625, 2, 36);

            var result = calculator.Calculate();

            Assert.AreEqual(44.4444, result, "Belt calculation was not as expected");
        }

        [Test]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CalculateRequriesAllParametersSupplied()
        {
            var calculator = new BeltCalculator(1.8, 0.0625, 2, 0);


            calculator.Calculate();
        }
    }
}
