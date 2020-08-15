using Pharmacy2UTechnicalTest.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy2UTechnicalTest.Models.Classes
{
   public class User : IBaseEntity
   {
      public int Id { get; set; }

      [Required]
      [StringLength(50)]
      public string UserName { get; set; }

      public virtual IEnumerable<ConversionLog> ConversionLogs { get; set; }
   }
}
