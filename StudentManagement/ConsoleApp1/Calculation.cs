using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculation
    {
        public int num1 { get; set; }
        public int num2 { get; set; }

        public int add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }

        public int div(int num1, int num2)
        {
            return num1 / num2;
        }

    }
}
