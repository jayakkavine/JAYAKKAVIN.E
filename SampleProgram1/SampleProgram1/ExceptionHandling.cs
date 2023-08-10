using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    internal class ExceptionHandling
    {
        private int num1, num2, ans;
        // private int[] numbers;
        private int age;

        public ExceptionHandling(int num1, int num2, int age)
        {
            this.num1 = num1;
            this.num2 = num2;
            this.Age = age;
            // this.numbers = numbers;
        }

        public int Num1 { get => num1; set => num1 = value; }
        public int Num2 { get => num2; set => num2 = value; }
        public int Ans { get => ans; set => ans = value; }
        public int Age { get => age; set => age = value; }

        // public int[] Numbers { get => numbers; set => numbers = value; }

        public int Add()
        {
            Ans = Num1 + Num2;
            return Ans;
        }
        public int Sub()
        {
            Ans = Num1 - Num2;
            return Ans;
        }
        public int Mul()
        {
            Ans = Num1 * Num2;
            return Ans;
        }

        public void CheckAge() 
        {
            if(Age < 18 )
            {
                throw new AgeException();
            }
            else
            {
                Console.WriteLine("Eligible to Vote");
            }
        }


        public int Div()
        {

            if(Num2 != 0)
            {
                Ans = Num1 / Num2;
            }
            else
            {
                Ans = 0;
                throw new DivException("Trying to Divide by 0");
            }
            

            /*
            try
            {
                Ans = Num1 / Num2;
                /*
                for(int i=0;i<5;i++)
                {
                    Console.WriteLine(Numbers[i] / Num2);
                }
                
                //return Ans;
            }
            
            catch (ArithmeticException ex)
            {
                Ans = 0;
                Console.WriteLine(ex.Message);
                Console.WriteLine("Don't Give any value as 0");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + ex.StackTrace);
                Console.WriteLine("Array Index is Out of Bound");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured");
            }
            finally
            {
                Console.WriteLine("Executed Finally");
            }
            */
            return Ans;
        }

    }
}
