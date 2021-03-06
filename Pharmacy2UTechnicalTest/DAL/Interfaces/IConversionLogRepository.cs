﻿using Pharmacy2UTechnicalTest.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pharmacy2UTechnicalTest.DAL.Interfaces
{
   public interface IConversionLogRepository : IReadRepository<ConversionLog>, IWriteRepository<ConversionLog>
   {
      IQueryable<ConversionLog> GetAllWithinDateRange(DateTime dateFrom, DateTime dateTo);
   }
}
