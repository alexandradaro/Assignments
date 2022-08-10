namespace Abstraction
{
    public abstract class Department
    {
        //abstract methods
        public abstract int Unit { get; set; }
        public abstract string Courses(string CoursesName);
        public Department()
        {

        }
    }
    // inheriting from abstract class
    public class Engineering : Department
    {
        public override int Unit { get; set; }
        public override string Courses(string CoursesName)
        {
            return CoursesName;
        }
    }
    class Abstraction
    {
        static void Main(string[] args)
        {
            // create an object of Engineering class
            Engineering Maths = new Engineering();
            Maths.Unit = 3;
            Console.WriteLine("Engineering Maths Course Unit is: " + Maths.Unit);

            Console.ReadLine();
        }
    }
}