using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataLayer
{
    public class Unitofworkcus : IDisposable
    {

        Employees_DBEntities db = new Employees_DBEntities();

        private ICustomerRepository _customerRepository;

        public ICustomerRepository customerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new CustomerRepository(db);
                }
                return _customerRepository;
            }
        }
        private GenericRepository<Transection> _TransectionRepository;

        public GenericRepository<Transection> TransectionRepository
        {
            get
            {
                if (_TransectionRepository == null)
                {
                    _TransectionRepository = new GenericRepository<Transection>(db);

                }
                return _TransectionRepository;
            }
        }
        private GenericRepository<Login> _loginRepository;
        public GenericRepository<Login> LoginRepository
        {
            get
            {
                if(_loginRepository == null)
                {
                    _loginRepository = new GenericRepository<Login>(db);
                }
                return _loginRepository;
            }
        }


        public void Dispose()
        {
            db.Dispose();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
   
    
}
