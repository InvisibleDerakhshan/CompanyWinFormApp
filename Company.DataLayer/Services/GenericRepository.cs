using Company.DataLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public class GenericRepository<TEntity> where TEntity : class
    {
        private Employees_DBEntities _db;//new context
        
       private DbSet <TEntity> _dbSet; //kadval ke bayad vasl beshe repository

        public GenericRepository (Employees_DBEntities db)//constractor ke be onvan vurudy db migire
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where=null)
        {
            IQueryable<TEntity> query = _dbSet;//lazy hast 

            if(where != null)
            {
                query = query.Where(where);
            }
            return query.ToList();//ghesmat lazy ta inja ejra nashide bood va be mahz residan be in ja ejra shod
        }
        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        } 

        public virtual TEntity GetById(object Id)
        {
            return _dbSet.Find(Id);
        }

        public virtual void Update (TEntity entity)
        {

           
            _db.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete (TEntity entity)
        {
            if (_db.Entry(entity).State != EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }
        public virtual void Delete (object Id)
        {
            var entity= GetById(Id);
            Delete(entity);

        }
    }
}
