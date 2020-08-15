using Pharmacy2UTechnicalTest.Contexts;
using Pharmacy2UTechnicalTest.DAL.Interfaces;
using Pharmacy2UTechnicalTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Classes
{
   //Inheritis read repository so it has read and write functionality
   public abstract class WriteRepository<T> :ReadRepository<T>,  IConversionLogRepository<T> where T : class, IBaseEntity
   {
      protected P2UTechTestDbContext _context;

      public WriteRepository(P2UTechTestDbContext context) : base(context)
      {
         _context = context;
      }

      public virtual int Add(T entity)
      {
         _context.Add(entity);
         _context.SaveChanges();
         return entity.Id;
      }

      public virtual void Delete(T entity)
      {
         _context.Remove(entity);
         _context.SaveChanges();
      }

      public virtual void Update(T entity)
      {
         _context.Update(entity);
         _context.SaveChanges();
      }
   }
}
