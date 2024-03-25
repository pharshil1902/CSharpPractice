namespace InheritancePractice
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string Emaill;

        public void PrintFullName()
        {
            Console.WriteLine("Full Name: {0} {1}", this.FirstName, this.LastName);
        }
    }


    public class FullTimeEmployee : Employee
    {
        public float YearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float HourlyRate;
    }




}
