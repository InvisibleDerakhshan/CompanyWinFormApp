using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataLayer
{
   public interface IEmployeesRepository
    {
        List<Employees> GetAll();
        IEnumerable<Employees> GetEmployeesByFilter(string parameter);
        Employees GetById(int id);
        bool InsertEmployees(Employees employees);
        bool UpdateEmployees(Employees employees);
        bool DeleteEmployees(Employees employees);
        bool DeleteEmployees(int ID);
    }
}
