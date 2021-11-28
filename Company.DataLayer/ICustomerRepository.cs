using Accounting.ViewModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataLayer
{
  public  interface ICustomerRepository
    {
        List<Customers> GetAll();
        IEnumerable<Customers> GetCustomersByFilter(string parameter);
        List<ListCustomerViewModel> GetNAmeCustomers(string filter = "");
        Customers GetById(int id);
        bool InsertCustomers(Customers employees);
        bool UpdateCustomers(Customers employees);
        bool DeleteCustomers(Customers employees);
        bool DeleteCustomers(int ID);
        string GetCustomerNameById(int customerId);
        int GetCustomerIdByNAme(string name);
        bool AddUser(Login user);
    }
}
