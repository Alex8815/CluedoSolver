using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Implementation
{
    public class Calculator : ICalculator
    {
        public string Test()
        {
            return "Calculator called -- Hello, World!";
        }
    }
}
