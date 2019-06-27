using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAppPractice2
{
    class Calculator
    {
        public decimal firstNumber;
        public decimal secondNumber;

        public decimal Addition()
        {
            return firstNumber + secondNumber;
        }
        public decimal Subtracton()
        {
            return firstNumber - secondNumber;
        }
        public decimal Multiply()
        {
            return firstNumber * secondNumber;
        }
        public decimal Divide()
        {
            return firstNumber / secondNumber;
        }
    }
}
