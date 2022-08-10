namespace OOPConcepts
{
    public abstract class Recruitment
    {
        public abstract string DomainDept();
        public abstract string Experience();
    }
    public class ApplicantInfo : Recruitment
    {
        public string? Skills { get; private set; }
        public override string DomainDept()
        {
            try
            {
                Console.WriteLine("Are you a Data Analyst, backend developer or frontend developer?");
                Console.WriteLine("Enter 1 if you are a Data Analyst?");
                Console.WriteLine("Enter 2 if you are a backend developer?");
                Console.WriteLine("Enter 3 if you are a frontend developer?\n");
                string domain = Console.ReadLine();

                switch (domain)
                {
                    case "1":
                        Skills = "Data Analyst";
                        break;
                    case "2":
                        Skills = "Backend Developer";
                        break;
                    case "3":
                        Skills = "Frontend Developer";
                        break;

                    default:
                        Console.WriteLine("Invalid Input, pick from the available domains");
                        Skills = null;
                        break;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return Skills;



        }
        public override string Experience()
        {
            Console.WriteLine("How many years of experience do you have?");
            int exYears = Convert.ToInt32(Console.ReadLine());


            {
                if (exYears < 3)
                {
                    return "Junior";
                }
                else
                    return "Senior";
            }
        }

        public void SalaryRange()
        {
            var skills = DomainDept();
            var experience = Experience();


            if (experience == "Junior" && skills != null)
            {
                Console.WriteLine($"Junior {skills} earn between 100-150k");
            }
            else if (skills == null)
            {
                Console.WriteLine("Error detected, rerun application to try again");
            }
            else
            {
                Console.WriteLine($"Senior {skills} earn between 500 - 1500k");
            }
        }



    }
}