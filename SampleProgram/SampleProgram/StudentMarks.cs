using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    class StudentMarks : StudentDetails
    {
        private int m1, m2, m3;

        public StudentMarks(string college_name, string college_address, int roll_no, int age, string student_name, string address, int m1, int m2, int m3) 
            : base( college_name, college_address, roll_no, age, student_name, address)
        {
            this.m1 = m1;
            this.m2 = m2;
            this.m3 = m3;
        }

        public int M1 { get => m1; set => m1 = value; }
        public int M2 { get => m2; set => m2 = value; }
        public int M3 { get => m3; set => m3 = value; }

        public int calculateTotal()
        {

            return M1+M2+M3;
        }

        public double calculateAverage()
        {
            return (M1 + M2 + M3 )/ 3;
        }

    }
}
