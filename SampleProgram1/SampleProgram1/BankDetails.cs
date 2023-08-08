using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProgram1
{
    internal class BankDetails
    {
        private int customer_id;
        private string? customer_name;
        private long account_number;
        private string? status;
        private double balance;

        public BankDetails(int customer_id, string? customer_name, long account_number, string? status, double balance)
        {
            this.Customer_id = customer_id;
            this.Customer_name = customer_name;
            this.Account_number = account_number;
            this.Status = status;
            this.Balance = balance;
        }

        public int Customer_id { get => customer_id; set => customer_id = value; }
        public string? Customer_name { get => customer_name; set => customer_name = value; }
        public long Account_number { get => account_number; set => account_number = value; }
        public string? Status { get => status; set => status = value; }
        public double Balance { get => balance; set => balance = value; }


        public void FetchAccountDetails(int customer_id)
        {
            if(Customer_id == customer_id)
            {
                Console.WriteLine(Customer_id +" "+Customer_name+ " " + Status +" " + Balance);
            }
        }
        
        public void FetchAccountDetails(long account_number)
        {
            if(Account_number == account_number)
            {
                Console.WriteLine(Account_number + " "+Customer_name + " "+Status + " "+Balance);
            }
        }
        
        public void FetchAccountDetails(string customer_name)
        {
            if(Customer_name.Equals(customer_name))
            {
                Console.WriteLine(Customer_name + " "+Account_number + " "+Status + " "+Balance);
            }
        }
    }
}
