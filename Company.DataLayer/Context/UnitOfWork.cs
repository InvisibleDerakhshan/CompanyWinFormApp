using Accounting.DataLayer.Repositories;
using Company.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.DataLayer.Context
{
    public class UnitOfWork : IDisposable
    {
        Employees_DBEntities db =new Employees_DBEntities();

        private IEmployeesRepository _employeerepository;

        public IEmployeesRepository EmployeeRepository
        {
            get
            {
                if (_employeerepository == null)
                {
                    _employeerepository = new EmployeesRepositorycs(db);
                }
                return _employeerepository;
            }
        }
        private GenericRepository<Transection> _transectionrepository;
        public GenericRepository<Transection> transectionrepository
        {
            get
            {
                if( _transectionrepository == null)
                {
                    _transectionrepository= new GenericRepository<Transection>(db);

                }
                return _transectionrepository;
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
