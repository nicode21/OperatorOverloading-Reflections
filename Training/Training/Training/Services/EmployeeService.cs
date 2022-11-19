using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;
using Training.Services.Interfaces;

namespace Training.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double GetAllByAvarageSalary(Predicate<Employee> predicate)
        {
            var employee = GetAll();

            var result = employee.FindAll(predicate);

            return CalculateAvarage(result);
        }

        private double CalculateAvarage(List<Employee> employees) => employees.Average(m=>m.Salary);

        private List<Employee> GetAll()
        {

            List<Employee> employees = new();

            employees.Add(new Employee() { Age = 16, Salary = 2000 });
            employees.Add(new Employee() { Age = 22, Salary = 100 });
            employees.Add(new Employee() { Age = 33, Salary = 900 });
            employees.Add(new Employee() { Age = 50, Salary = 200 });

            return employees;

        }

    }
}
