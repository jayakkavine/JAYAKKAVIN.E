using System;
using System.Collections.Generic;
using System.Text;

namespace SampleProgram
{
    public static class StaticDemo
    {
        static int customer_number = 123, previous_reading = 1000, current_reading = 800;
        static double amount;
        static int consumption;

        static StaticDemo()
        {
            if((Previous_reading - Current_reading)<=100)
            {
                Amount = 0;
            }
        }

        public static int Customer_number { get => customer_number; set => customer_number = value; }
        public static int Previous_reading { get => previous_reading; set => previous_reading = value; }
        public static int Current_reading { get => current_reading; set => current_reading = value; }
        public static double Amount { get => amount; set => amount = value; }
        public static int Consumption { get => consumption; set => consumption = value; }

        public static void calc()
        {
            Consumption = (Previous_reading - Current_reading);
            if (Consumption <= 100)
            {
                Amount = 0;
            }
            else if (Consumption > 100 && Consumption <= 200)
            {
                Amount = (Consumption - 100) * 2;
            }
            else if (Consumption > 200 && Consumption <= 500)
            {
                Amount = (Consumption - 100) * 5;
            }
            else if (Consumption > 500)
            {
                Amount = (Consumption - 100) * 10;
            }
        }

    }
}
