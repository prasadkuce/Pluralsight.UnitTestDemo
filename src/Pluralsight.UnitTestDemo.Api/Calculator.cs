using System;

namespace Pluralsight.UnitTestDemo.Api
{
    public class Calculator
    {
        public int Add(int val1, int val2)
        {
            return val1 + val2;
        }
        public int Subtract(int val1, int val2)
        {
            return val1 - val2;
        }
        public int Multiply(int val1, int val2)
        {
            return val1 * val2;
        }
        public int Divide(int val1, int val2)
        {
            if(val2 == 0)
                throw new DivideByZeroException();
            return val1 / val2;
        }
    }
}
