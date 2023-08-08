using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    internal class CollectionExamples
    {
        List<int> number = new List<int>();
        
        public void AddNewElement()
        {
            number.Add(10);
            number.Add(20);
            number.Add(30);
            number.Add(40);
            
        }

        public int FindAnElement()
        {
            return number.ElementAt(1);
        }

    }
}
