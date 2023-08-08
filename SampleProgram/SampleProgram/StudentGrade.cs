using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    class StudentGrade : StudentMarks
    {
        
        public StudentGrade(string college_name, string college_address, int roll_no, int age, string student_name, string address, int m1, int m2, int m3)
            : base(college_name, college_address, roll_no, age, student_name, address, m1, m2, m3)
        {

        }

        public char CalculateGrade()
        {
            double avg = calculateAverage();
            if(avg >= 90)
            {
                return 'A';
            }
            else if(avg>=80 && avg<90)
            {
                return 'B';
            }
            else
                return 'U';
        }

    }
}
