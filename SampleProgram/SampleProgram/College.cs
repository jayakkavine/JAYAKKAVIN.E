using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    class College
    {
        private string college_name, college_address;

        public College(string college_name, string college_address)
        {
            this.College_name = college_name;
            this.College_address = college_address;
        }

        public string College_name { get => college_name; set => college_name = value; }
        public string College_address { get => college_address; set => college_address = value; }

        public void DisplayCollegeDetails()
        {
            Console.WriteLine(College_name+" "+College_address);
        }

    }
}
