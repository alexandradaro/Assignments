using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWODA
{
    internal class OWODA
    {
        static void Main(string[] args)
        {
            TollCalc Toll = new TollCalc();
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                int vehicleFee = Toll.Vehicle_Type();
                int trip = Toll.TripNum();
                double membershipRate = Toll.MembershipDiscount();

                double amount = vehicleFee * trip * membershipRate;
                total +=  amount;
                Console.WriteLine("Your Toll Amount is " + Math.Round(amount, 2));
            }
            Console.WriteLine("Total Amount Collected for 5 random drivers is " + Math.Round(total));

        }
    }
}

