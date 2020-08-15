using Microsoft.EntityFrameworkCore;
using Pharmacy2UTechnicalTest.Contexts;
using Pharmacy2UTechnicalTest.DAL.Interfaces;
using Pharmacy2UTechnicalTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Classes
{
   public abstract class ReadRepository<T> : IReadRepository<T> where T :class,  IBaseEntity
   {
      protected P2UTechTestDbContext _context;

      public ReadRepository(P2UTechTestDbContext context)
      {
         _context = context;
      }
      public virtual T Get(int id)
      {
         return _context.Set<T>().Where(t => t.Id == id).FirstOrDefault();
      }

      public virtual IQueryable<T> GetAll()
      {
         return _context.Set<T>();
      }

      public virtual IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties)
      {
         IQueryable<T> queryable = GetAll();
         foreach (Expression<Func<T, object>> includeProperty in includeProperties)
         {
            queryable = queryable.Include<T, object>(includeProperty);
         }

         return queryable;
      }
   }
}
