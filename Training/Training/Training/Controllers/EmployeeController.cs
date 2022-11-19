using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Services;
using Training.Services.Interfaces;

namespace Training.Controllers
{
    public class EmployeeController
    {
        public static void GetEmployeeSalaryAvarage()
        {
            IEmployeeService employeeService = new EmployeeService();

            Console.WriteLine(employeeService.GetAllByAvarageSalary ( m=>m.Age > 20 && m.Age < 40 ));
             
        }
    }
}
