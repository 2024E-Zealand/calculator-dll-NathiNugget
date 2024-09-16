using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorClassLibrary
{
    /// <summary>
    /// Class defining a calculator
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Constructor for the class to call Calculate
        /// </summary>
        public Calculator() { }

        /// <summary>
        /// Method to make a calculation based on an operation and two operands
        /// </summary>
        /// <param name="operation">A character for the operation</param>
        /// <param name="x">First number</param>
        /// <param name="y">Second number</param>
        /// <returns>A double containing the result of the operation</returns>
        /// <exception cref="NotImplementedException">Thrown if the user tries to do an operation not yet supported by the calculator</exception>

        public double Calculate(char operation, int x, int y)
        {
            return operation switch
            {
                '+' => x + y,
                '-' => x - y,
                '*' => x * y,
                '/' => x / y,
                _ => throw new NotImplementedException()
            };   


        }
    }
}
