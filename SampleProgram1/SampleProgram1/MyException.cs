using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    public class AgeException : Exception
    {
        public AgeException() : base("Invalid Age")
        {

        }
    }


    public class DivException : Exception
    {
        public DivException(string msg) : base(msg)
        {

        }
    }

}
