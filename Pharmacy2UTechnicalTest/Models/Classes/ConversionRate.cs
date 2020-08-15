using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Pharmacy2UTechnicalTest.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy2UTechnicalTest.Models.Classes
{
   public class ConversionRate : IBaseEntity
   {
      public int Id { get; set; }

      public int ConvertFromId { get; set; }

      public virtual Currency ConvertFrom { get; set; }

      public int ConvertToId { get; set; }

      public virtual Currency ConvertTo { get; set; }
      
      [Column(TypeName = "decimal(10,4)")]
public decimal Rate { get; set; }      

      public virtual IEnumerable<ConversionLog> ConversionLogs { get; set; }
   }
}
