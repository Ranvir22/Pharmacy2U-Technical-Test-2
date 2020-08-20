using Pharmacy2UTechnicalTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Interfaces
{
   //Write repository will have read functionality
   public interface IWriteRepository<T> : IReadRepository<T> where T : IBaseEntity
   {
      int Add(T entity);

      void Update(T entity);

      void Delete(T entity);
   }
}
