using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    class StaffDetails : College
    {
        private int emp_no, age;
        private string emp_name, address;// to make nullable use ? near to string 

        public StaffDetails(string college_name, string college_address, int emp_no, int age, string emp_name, string address) 
            : base(college_name, college_address)
        {
            this.emp_no = emp_no;
            this.age = age;
            this.emp_name = emp_name;
            this.address = address;
        }

        public int Emp_no { get => emp_no; set => emp_no = value; }
        public int Age { get => age; set => age = value; }
        public string Emp_name { get => emp_name; set => emp_name = value; }
        public string Address { get => address; set => address = value; }




    }
}
