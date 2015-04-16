using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Something
{
    class Customer
    {
        public Account[] Accounts { get; set; }

        public Customer(params Account[] accounts)
        {
            this.Accounts = accounts;
        }
        public bool Transfer(Account send, Account receive, decimal transferAmt)
        {
            send.Amount -= transferAmt;
            receive.Amount += transferAmt;
            return true;
        }

        public override string ToString()
        {
            var str = "";
            foreach (var i in Accounts)
	{
		 str += i;
	}
            return str;
        }
    }
}
