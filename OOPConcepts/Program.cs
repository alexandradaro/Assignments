using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcepts
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tech Salary Range APP. What is your name?\n");
            try
            {
                string name = Console.ReadLine();

                Console.WriteLine($"{name} please kindly respond to the following questions\n");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            var app = new ApplicantInfo();
            app.SalaryRange();

        }
    }
}
