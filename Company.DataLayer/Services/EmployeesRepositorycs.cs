using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataLayer.Services
{
    public class EmployeesRepositorycs : IEmployeesRepository
    {
        private Employees_DBEntities dBEntities;

        public EmployeesRepositorycs(Employees_DBEntities context)
        {
            dBEntities = context;
        }
        public bool DeleteEmployees(Employees employees)
        {
            try
            {
                dBEntities.Entry(employees).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteEmployees(int ID)
        {
            try
            {
                var employee = GetById(ID);
                DeleteEmployees(employee);
                return true;
            }
            catch
            {
                return false;
            }
            
        }

        public List<Employees> GetAll()
        {
           return dBEntities.Employees.ToList();
        }

        public Employees GetById(int id)
        {
            return dBEntities.Employees.Find(id);
        }

        public IEnumerable<Employees> GetEmployeesByFilter(string parameter)
        {
            return dBEntities.Employees.Where(e => e.NationalID.Contains(parameter) || e.FullName.Contains(parameter) || e.Phone.Contains(parameter)).ToList();
        }

        public bool InsertEmployees(Employees employees)
        {
            try
            {
                dBEntities.Employees.Add(employees);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateEmployees(Employees employees)
        {
            try
            {
                dBEntities.Entry(employees).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
