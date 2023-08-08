using System.Xml.Serialization;
using SampleProgram1;
using Tasks;

namespace SampleProgram1
{
    internal class Program
    { 

        static void Main(string[] args)
        {
            /*
            MyPet ps = new MyPet(2,2,4,"dog");

            ps.AboutMe();
            ps.Sound();
  
            Animal.Sleep();
            Animal.Eat();

            Animal animal = new MyPet(2,2,4,"cat");
            animal.AboutMe();
            animal.Sound();
            */
            /*
            BankDetails bank = new BankDetails(123456, "JK" ,123456789012, "Inactive" ,100000);

            int choice = 0;

            do
            {
                Console.WriteLine("1. Customer ID \n 2. Account Number \n 3. Customer Name \n 4. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: int customer_id = Convert.ToInt32(Console.ReadLine());
                            bank.FetchAccountDetails(customer_id);
                            break;
                    case 2: long account_number = Convert.ToInt64(Console.ReadLine());
                            bank.FetchAccountDetails(account_number);
                            break;
                    case 3: string? name = Console.ReadLine();
                            bank.FetchAccountDetails(name);
                            break;
                }
            } while (choice != 4);
            */


            //Book book = new Book(123, "Java", "some person", true);

            //book.DisplayDetails();

            Book book1 = new(101, "Java", " JK", true);
            Book book2 = new(102, "C#", "Sanjay", true);
            Book book3 = new(103, "Angular", "Harsha", false);
            Book book4 = new(104, ".Net", "Yogesh", true);

            Library.book.Add(book1);
            Library.book.Add(book2);
            Library.book.Add(book3);
            Library.book.Add(book4);

            Library library = new Library();
            int choice = 0;
            while (choice != 4)
            {
                Console.WriteLine("Choose the option\n1.Borrow Book\n2.Return Book\n3.Display Books\n4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine("Enter the title of the book to borrow");
                    string title = Console.ReadLine();
                    Console.WriteLine(title);
                    library.BorrowBook(title);
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the title of the book to return");
                    string title = Console.ReadLine();
                    library.ReturnBook(title);
                }
                else if (choice == 3)
                {
                    library.DisplayBookDetails();
                }
                else if (choice == 4)
                {
                    break;
                }
            }





            }
        }
}