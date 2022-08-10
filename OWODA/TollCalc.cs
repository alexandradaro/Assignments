using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OWODA
{
    internal class TollCalc
    {
        public int Vehicle_Type()
        {
            Console.WriteLine("Welcome to Owo Da Toll Calculator!");
            Console.WriteLine("Enter 1 if vehicle type is motor cycle");
            Console.WriteLine("Enter 2 if vehicle type is tricycle");
            Console.WriteLine("Enter 3 if vehicle type is minibus");
            Console.WriteLine("Enter 4 if vehicle type is bus");

            int vehicleType = Convert.ToInt32(Console.ReadLine());
            {
                if (vehicleType == 1)
                {
                    return 100;
                }
                else if (vehicleType == 2)
                {
                    return 150;
                }
                else if (vehicleType == 3)
                {
                    return 200;
                }
                else if (vehicleType == 4)
                {
                    return 250;
                }
                else { return 0; }

            }
        }
        public double MembershipDiscount()
        {
            Console.WriteLine("Are you a union member? Enter yes or no");
            string isMember = Console.ReadLine().ToLower();
            if (isMember == "yes")
            {
                double MembershipDiscount = 0.7d;
                return MembershipDiscount;
            }
            else if (isMember == "no")
            {
                double MembershipDiscount = 1d;
                return MembershipDiscount;
            }
            else
            {
                return 0;
            }
        }
        public int TripNum()
        {
            Console.WriteLine("What is the total number of trips taken?");
            int tripNum = Convert.ToInt32(Console.ReadLine());
            return tripNum;
        }
    }

}
