using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace BMS
    {
        abstract class Account
        {
            public readonly string name;
            public readonly string ID;
            public double ammount;
            

            

            public double getBalance()
            {
                return balance;
            }
            public string getAccType()
            {
                string actype;
                actype = Convert.ToString(Console.ReadLine());
                return actype;
            }
            public void printAccount()
            {

                Console.WriteLine("Name : " + name);
                Console.WriteLine("Date of Birth :" + DOB);
                Console.WriteLine("Nominee : " + nominee);
                Console.WriteLine("Balance :" + balance);
            }
            public Account()
            {

            }
            public Account(string name, DOB DOB, string nominee, double balance)
            {
                this.name = name;
                this.DOB = DOB;
                this.nominee = nominee;
                this.balance = balance;
            }
        }
    }

}
