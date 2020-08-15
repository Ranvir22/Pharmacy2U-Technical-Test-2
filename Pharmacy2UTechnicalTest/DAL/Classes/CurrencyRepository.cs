using Pharmacy2UTechnicalTest.Contexts;
using Pharmacy2UTechnicalTest.DAL.Interfaces;
using Pharmacy2UTechnicalTest.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Classes
{
   public class CurrencyRepository : ReadRepository<Currency>, ICurrencyRepository
   {
      public CurrencyRepository(P2UTechTestDbContext context) : base(context)
      {

      }
   }
}
