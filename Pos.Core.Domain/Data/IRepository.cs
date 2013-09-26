using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pos.Core.Data
{
    public interface IRepository<TType>
    {
        TType Add(TType entity);

        bool Update(TType entity);

        bool Delete(TType entity);

        TType Get(Expression<Func<TType, bool>> filter);

        IQueryable<TType> FindBy(System.Linq.Expressions.Expression<Func<TType, bool>> predicate);

        ICollection<TType> GetAll();
    }
}
