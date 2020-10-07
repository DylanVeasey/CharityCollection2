using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCollection2
{
    class UserInput
    {
        private int _amountCollected;

        public int AmountCollected
        {
            get { return _amountCollected; }
            set { _amountCollected = value; }
        }

        public void GetAmount(int IndexOfPerson)
        {
            Console.WriteLine("How much did person {0} collect?", IndexOfPerson);
            AmountCollected = Int32.Parse(Console.ReadLine());
        }

    }
}
