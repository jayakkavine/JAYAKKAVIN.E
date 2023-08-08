using System;
using SampleProgram;

namespace SampleProgram
{
    class Program
    {

      
        static void Main(string[] args)
        {
            /*
                Console.WriteLine("Enter the Consumer Number :");
                int consumer_number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Consumer Name :");
                string consumer_name = Console.ReadLine();//string? consumer_name = console.ReadLine(); - To accept null value
                Console.WriteLine("Enter the Consumer Previous Reading :");
                int previous_reading = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Consumer Current Reading :");
                int current_reading = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Consumer Type :");
                string consumer_type = Console.ReadLine();
            
                ElectricReading ec = new ElectricReading(consumer_name, consumer_number, previous_reading, current_reading, consumer_type);
            
                int bill_amount = ec.caluculateBill();

                Console.WriteLine("The Consumer " + consumer_name + " need to pay the amount of :" + bill_amount);

                Console.WriteLine($"Bill: {consumer_name} {consumer_type} {bill_amount}");
            */
            /*
            ElectricReading ec = new ElectricReading("JK",12345,1000,800,"Domestic");

            int bill_amount = ec.caluculateBill();

            Console.WriteLine("The Consumer " + ec.Consumer_name + " need to pay the amount of :" + bill_amount);

            Console.WriteLine($"Bill: {ec.Consumer_name} {ec.Consumer_type} {bill_amount}");
            */

            /*
            Console.WriteLine("Account Number :"+StaticDemo.Customer_number);
            Console.WriteLine("Previous Reading :" + StaticDemo.Previous_reading);
            Console.WriteLine("Current Reading :" + StaticDemo.Current_reading);

            StaticDemo.calc();

            Console.WriteLine("Amount :" + StaticDemo.Amount);

            */




            
            StudentGrade studentmarks = new StudentGrade("KEC","Perundurai", 100, 23, "JK", "Erode", 80, 81, 82);
            Console.WriteLine("Student Name :" + studentmarks.Student_name);
            Console.WriteLine("Student Roll Number :" + studentmarks.Roll_no);
            Console.WriteLine("Student Age :" + studentmarks.Age);
            Console.WriteLine("Student Address :" + studentmarks.Address);
            Console.WriteLine("Student Address :" + studentmarks.College_name);
            Console.WriteLine("Student Address :" + studentmarks.College_address);
            Console.WriteLine("Student Address :" + studentmarks.Address);
            Console.WriteLine("Average of the Student :"+studentmarks.calculateAverage());
            Console.WriteLine("Total of the Student :" + studentmarks.calculateTotal());
            Console.WriteLine("Student Grade :" + studentmarks.CalculateGrade());
            



            TeachingStaff teachingStaff = new TeachingStaff("KEC","Perundurai",101, 50, "JK", "Erode", "M.Sc", 100000, 40, 25, 10, 5);

            NonTeachingStaff nonteachingStaff = new NonTeachingStaff("KEC", "Perundurai", 102, 50, "Sanjay", "Polachi", 150000, 35, 20, 5, 3);

            Console.WriteLine("Teaching Staff Name :"+teachingStaff.Emp_name);
            Console.WriteLine("Teaching Staff ID :"+teachingStaff.Emp_no);
            Console.WriteLine("Teaching Staff Age :" + teachingStaff.Age);
            Console.WriteLine("Teaching Staff Address :" + teachingStaff.Address);
            Console.WriteLine("Teaching Staff College name :" + teachingStaff.College_name);
            Console.WriteLine("Teaching Staff College Address :" + teachingStaff.College_address);
            Console.WriteLine("Non Teaching Staff Net Salary :" + teachingStaff.CalculateSalary());


            teachingStaff.DisplayCollegeDetails();

            Console.WriteLine("Non Teaching Staff Name :" + nonteachingStaff.Emp_name);
            Console.WriteLine("Non Teaching Staff ID :" + nonteachingStaff.Emp_no);
            Console.WriteLine("Non Teaching Staff Age :" + nonteachingStaff.Age);
            Console.WriteLine("Non Teaching Staff Address :" + nonteachingStaff.Address);
            Console.WriteLine("Non Teaching Staff College name :" + nonteachingStaff.College_name);
            Console.WriteLine("Non Teaching Staff College Address :" + nonteachingStaff.College_address);
            Console.WriteLine("Non Teaching Staff Net Salary :" + nonteachingStaff.CalculateSalary());



            /*
            double num1, num2;
            int result;
            num1 = Convert.ToDouble(Console.ReadLine());
            num2 = Convert.ToDouble(Console.ReadLine());

            result = (int)(num1 + num2);
            Console.WriteLine(result);
            */

            /*
            int num1, sum = 0, temp;

            num1 = Convert.ToInt32(Console.ReadLine());
            temp = num1;

            while(num1!=0)
            {
                int rem = num1 % 10;
                sum = sum + (rem*rem*rem);
                num1 = num1 / 10;
            }

            if(sum == temp)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not Armstrong Number");
            }
           
            */

            // Perfect Number
            // Prime Number
            // factors 

            /*
            int num1, sum=0;
            Console.WriteLine("Enter the value: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=(num1/2);i++)
            {
                if(num1%i==0)
                {
                    sum = sum + i;
                }
                //Console.WriteLine(i);
            }

            if(sum == num1)
            {
                Console.WriteLine("Given Number is Perfect number");
            }
            else
            {
                Console.WriteLine("Given numer is not a Perfect Number");
            }
            */
            /*
            int num1, num2;
            Console.WriteLine("Enter the Start value: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the End value: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers are: ");
            for (int i=num1;i<=num2;i++)
            {
                int point=0;
                for(int j=2;j<=(i/2);j++)
                {
                    if(i%j == 0)
                    {
                        point = 1;
                    }
                }
                if(point==0)
                {
                    Console.WriteLine(i);
                }
            }
            */







            
        }
    }




}
