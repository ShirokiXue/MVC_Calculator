using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Calculator
{
    internal class CalculatorModel
    {
        public double Operand1 { get; set; }
        public double Operand2 { get; set; }
        public char Operator { get; set; }

        public double PerformOperation()
        {
            switch (Operator)
            {
                case '+':
                    return Operand1 + Operand2;
                case '-':
                    return Operand1 - Operand2;
                case '*':
                    return Operand1 * Operand2;
                case '/':
                    if (Operand2 == 0)
                        throw new DivideByZeroException("Cannot divide by zero.");
                    return Operand1 / Operand2;
                default:
                    throw new ArgumentException("Invalid operator.");
            }
        }
    }
}
