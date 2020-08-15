using Pharmacy2UTechnicalTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Interfaces
{
   public interface IReadRepository<T>  where T : IBaseEntity
   {
      T Get(int id);

      IQueryable<T> GetAll();

      IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);
   }
}
