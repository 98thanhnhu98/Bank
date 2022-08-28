using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.NewFolder
{
    internal class Program
    {
        // Dữ Liệu lưu từ hai phía Customer va BankAccount (chỉ lưu key) 
        public static Dictionary<int, int> accountMain = new Dictionary<int, int>();
        // Dữ Liệu các tài khoán
        public static Dictionary<int, Customer> check = new Dictionary<int, Customer>();
        // Dữ Liệu trong tài khoản sẽ là dưới đây
        public static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
        public static void menu()
        {
            Console.WriteLine("1. Chuyen tien vào ngân hàng \n2.Rút Tiền \n3. Tra cứu tài khoản");
        }   
        public static void Main(string[] args)
        {
            check.Add(123, new Customer("thanh",18));
            accounts.Add(123, new BankAccount(1, 22000));
            accountMain.Add(123, 123);

            Console.WriteLine("Nhap lenh : ");
            Console.WriteLine("Ban co tai khoan chưa ? yes/no ?");

            string[] commands = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.ToLower())
                .ToArray();
          
            while (commands[0] != "end")
            {            
                if (commands[0] == "no")
                {
                    BankAccount.Create(accounts);
                    Console.WriteLine("-------------------- ");
                }
                else if (commands[0] == "yes")
                {
                    Console.Write("Nhap id");
                    int nhap = int.Parse(Console.ReadLine());
                    
                    foreach(var kvp in check) { 
                        if (kvp.Key==nhap)
                        {
                            Console.WriteLine("Xin Chao " + kvp.Value);
                            menu();
                            int chon = int.Parse(Console.ReadLine());
                            switch (chon)
                            {
                                case 1:
                                    BankAccount.Deposit(accounts);
                                    Console.WriteLine("-------------------- ");
                                    break;
                                case 2:
                                    BankAccount.Withdraw(accounts);
                                    Console.WriteLine("-------------------- ");
                                    break;
                                case 3:
                                    BankAccount.Print(accounts);
                                    Console.WriteLine("-------------------- ");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Tai Khoan khong chinh xác");
                        }
                        Console.Write("Nhap Lai :");
                        Console.WriteLine("Ban co tai khoan chưa ? yes/no ?");
                    }
                }
                commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(e => e.ToLower())
                    .ToArray();

            }

        }
    }
   
}
