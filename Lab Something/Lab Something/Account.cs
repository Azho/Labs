using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Something
{
    class Account
    {
        public Account(int id, string type, decimal amount, bool isOpen)
        {
            this.ID = id;
            this.Type = type;
            this.Amount = amount;
            this.IsOpen = isOpen;
        }
        public int ID { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public bool IsOpen { get; set; }

        public override string ToString()
        {
            return (String.Format("{0} {1} {2} {3}\n", ID, Type, Amount, IsOpen));

        }
    }

}
