using CardLogic.Implementation;
using CardLogic.Interfaces;
using NUnit.Framework;
using System;

namespace UnitTests
{
    [TestFixture]
    public class Calculator_UnitTests
    {
        private ICalculator _calculator;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void Calculator_Test_IsImplemented()
        {
            //throws exception if not
            _calculator.Test();
        }


    }
}
