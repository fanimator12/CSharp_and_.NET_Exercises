using System;

namespace Ex1
{
    class Program
    {
        /*
          A part time employee is paid for each hour he/she is working 
          and is hired for a number of hours per month. 
          A full-time employee is paid a fixed salary per month.
          
          Note: GetMonthlySalary in Employee is supposed to be abstract. 
          Diagram will be updated shortly.

          Implement the classes shown in the class diagram, 
          including attributes and methods, empty for now. 
          You may use an interface instead of an abstract class.

          Implement constructors in the classes: Employee, 
          PartTimeEmployee and FullTimeEmployee. The constructors 
          should take the necessary arguments to initialize all 
          the attributes in the classes.

          Implement the necessary functionality in the GetMonthlySalary 
          methods. The GetMonthlySalary method must return the monthly 
          salary for an employee.

          Implement the operation GetMonthlySalaryTotal in the class Company. 
          The operation must calculate the total salary which the company 
          must pay each month. The calculation should be done by calling 
          GetMonthlySalary on each of the employees and then returning the sum.

          Implement the operation EmployNewEmployee. The operation should 
          add a new PartTimeEmployee or FullTimeEmployee object to the 
          company’s list of employees.

          Implement the necessary test in a Main method.
         */
        static void Main(string[] args)
        {
            Company company = new Company();

            company.HireNewEmployee(new FullTimeEmployee("Jakob", 44000));
            company.HireNewEmployee(new FullTimeEmployee("Troels", 33000));

            company.HireNewEmployee(new PartTimeEmployee("Ole", 200, 120));
            company.HireNewEmployee(new PartTimeEmployee("Jan", 250, 100));

            Console.WriteLine("Total monthly salary: " + company.GetMonthlySalaryTotal());
        }
    }
}
