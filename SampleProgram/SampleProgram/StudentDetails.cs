using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    class StudentDetails : College
    {
        private int roll_no, age;
        private string student_name, address;// to make nullable use ? near to string 

        public StudentDetails(string college_name, string college_address, int roll_no, int age, string student_name, string address)
            :base(college_name, college_address)
        {
            this.roll_no = roll_no;
            this.age = age;
            this.student_name = student_name;
            this.address = address;
        }

        public int Roll_no { get => roll_no; set => roll_no = value; }
        public int Age { get => age; set => age = value; }
        public string Student_name { get => student_name; set => student_name = value; }
        public string Address { get => address; set => address = value; }




    }
}
