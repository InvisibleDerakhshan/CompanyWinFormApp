using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private Employees_DBEntities dBEntities;
        public CustomerRepository(Employees_DBEntities context)
        {
            dBEntities = context;
        }

        public bool AddUser(Login user)
        {
            try
            {
                dBEntities.Login.Add(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomers(Customers employees)
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

        public bool DeleteCustomers(int ID)
        {
            try
            {
                var employee = GetById(ID);
                DeleteCustomers(employee);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Customers> GetAll()
        {
            return dBEntities.Customers.ToList();
        }

        public Customers GetById(int id)
        {
            return dBEntities.Customers.Find(id);
        }

        public int GetCustomerIdByNAme(string name)
        {
            return dBEntities.Customers.First(c => c.Namee == name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return dBEntities.Customers.Find(customerId).Namee;
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return dBEntities.Customers.Where(e => e.Namee.Contains(parameter) || e.Email.Contains(parameter) || e.Phone.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetNAmeCustomers(string filter = "")
        {
            if (filter == "")
            {
                return dBEntities.Customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.Namee
                }).ToList();
            }

            return dBEntities.Customers.Where(c => c.Namee.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.Namee
            }).ToList();
        }

        public bool InsertCustomers(Customers employees)
        {
            try
            {
                dBEntities.Customers.Add(employees);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateCustomers(Customers employees)
        {
            var local = dBEntities.Set<Customers>()
                .Local
                .FirstOrDefault(f => f.CustomerID == employees.CustomerID);
            if (local != null)
            {
                dBEntities.Entry(local).State = EntityState.Detached;
            }
            dBEntities.Entry(employees).State = EntityState.Modified;
            return true;
        }
    }
}

