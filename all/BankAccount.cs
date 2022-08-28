using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.NewFolder
{
    public class BankAccount
    {
        public int id;
        public decimal balance;
        public int Id { get; set; }
        public decimal Balance { get; set; }
        public BankAccount(int id, decimal balance)
        {
            Id = id;
            Balance = balance;     
        }
        public BankAccount() { }

        public static void Create(Dictionary<int,BankAccount> accounts)
        {
            Console.WriteLine("Nhap id tao tk");
            int id = int.Parse(Console.ReadLine());
            if (accounts.ContainsKey(id))
            {
                Console.WriteLine(accounts.ContainsKey(id));
                Console.WriteLine("Account already exists");
            }
            else
            {
                BankAccount acc = new BankAccount();
                acc.Id = id;
                acc.balance = 0;
                accounts.Add(id,acc);
            }
        }
        public static void Deposit(Dictionary<int, BankAccount> accounts)
        {
            Console.WriteLine("Nhap id tai khoan");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien can gui");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                accounts[id].Balance += amount;
            }
        }
       
            public static void Withdraw(Dictionary<int,BankAccount> accounts)
        {
            Console.WriteLine("Nhap id tai khoan");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so tien can rut ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].Balance -= amount;
            }
        }
        public static void Print(Dictionary<int,BankAccount> accounts)
        {
            Console.WriteLine("Tra cuu tai khoan : id = ? ");
            int id = int.Parse(Console.ReadLine());
            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exits");
            }
            else
            {
                Console.WriteLine($"Account ID{accounts[id].Id}, balance{accounts[id].Balance}");
            }
        }

       
    }
}
