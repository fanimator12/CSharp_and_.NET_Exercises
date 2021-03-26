using System.Collections.Generic;

namespace Ex1
{
    class Company
    {
        List<Employee> employees = new List<Employee>();

        public double GetMonthlySalaryTotal()
        {
            double total = 0.0;
            foreach (Employee e in employees)
            {
                total += e.GetMonthlySalary();
            }
            return total;
        }

        public void HireNewEmployee(Employee emp)
        {
            employees.Add(emp);
        }
    }
}
