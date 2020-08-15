using Pharmacy2UTechnicalTest.Contexts;
using Pharmacy2UTechnicalTest.DAL.Interfaces;
using Pharmacy2UTechnicalTest.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Classes
{
   public class ConversionLogRepository : WriteRepository<ConversionLog>, IConversionLogRepository
   {
      public ConversionLogRepository(P2UTechTestDbContext context) : base(context)
      {

      }

      public virtual  IQueryable<ConversionLog> GetAllWithinDateRange(DateTime dateFrom, DateTime dateTo)
      {
         return this.GetAll().Where(l => l.ConversionDate >= dateFrom && l.ConversionDate <= dateTo);
      }
   }
}
