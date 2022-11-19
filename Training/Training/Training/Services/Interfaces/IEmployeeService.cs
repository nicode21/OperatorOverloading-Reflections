using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Training.Models;

namespace Training.Services.Interfaces
{
    public interface IEmployeeService
    {
        double GetAllByAvarageSalary(Predicate<Employee> predicate);
    }
}
