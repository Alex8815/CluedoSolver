using CardLogic.Interfaces;
using System;

namespace CardLogic.Implementation
{
    public class Calculator : ICalculator
    {
        public string Test()
        {
            return "Calculator called -- Hello, World!";
        }
    }
}
