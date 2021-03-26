namespace Ex1
{
    abstract class Employee
    {
        public string Name { get; set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract double GetMonthlySalary();
    }
}
