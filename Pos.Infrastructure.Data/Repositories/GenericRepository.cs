using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Metadata.Edm;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Pos.Core.Data;

namespace Pos.Infrastructure.Data.Repositories
{
    public class GenericRepository<TType> : IRepository<TType>
        where TType : class
    {

        private readonly IDataContext _dataContext;

        protected IDataContext Context
        {
            get { return this._dataContext; }
        }

        public GenericRepository(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public TType Add(TType entity)
        {
            _dataContext.Set<TType>().Add(entity);
            this._dataContext.SaveChanges();
            return entity;
        }

        public virtual bool Update(TType entity)
        {
            _dataContext.Set<TType>().Attach(entity);
            this._dataContext.SaveChanges();
            return true;
        }

        public virtual bool Delete(TType entity)
        {
            _dataContext.Set<TType>().Remove(entity);
            this._dataContext.SaveChanges();
            return true;
        }

        public TType Get(Expression<Func<TType, bool>> filter)
        {
            return this._dataContext.Set<TType>().SingleOrDefault(filter);
        }

        public IQueryable<TType> FindBy(Expression<Func<TType, bool>> predicate)
        {
            return _dataContext.Set<TType>().Where(predicate);
        }

        public ICollection<TType> GetAll()
        {
            return this._dataContext.Set<TType>().ToList();
        }
    }
}
