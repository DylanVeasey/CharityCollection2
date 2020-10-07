using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            int TotalAmountCollected;

            UserInput User1 = new UserInput();
            UserInput User2 = new UserInput();
            UserInput User3 = new UserInput();

            User1.GetAmount(1);
            User2.GetAmount(2);
            User3.GetAmount(3);

            TotalAmountCollected = User1.AmountCollected + User2.AmountCollected + User3.AmountCollected;

            if (TotalAmountCollected < 100)
            {
                Console.WriteLine("A total of {0} was raised.", TotalAmountCollected);
                TotalAmountCollected = TotalAmountCollected + 100;
                Console.WriteLine("With the company bonus, this is {0}" ,TotalAmountCollected);
            }
            else if( TotalAmountCollected >= 1000 && TotalAmountCollected <= 2000)
            {
                Console.WriteLine("A total of {0} was raised.", TotalAmountCollected);
                TotalAmountCollected = TotalAmountCollected * 2;
                Console.WriteLine("With the company bonus, this is {0}", TotalAmountCollected);
            }
            else
            {
                Console.WriteLine("A total of {0} was raised.", TotalAmountCollected);
                TotalAmountCollected = (TotalAmountCollected - 2000) + 4000;
                Console.WriteLine("With the company bonus, this is {0}", TotalAmountCollected);
            }
            Console.ReadLine();
        }
    }
}
