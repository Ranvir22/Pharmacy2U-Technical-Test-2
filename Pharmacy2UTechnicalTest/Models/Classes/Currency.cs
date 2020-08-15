using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Pharmacy2UTechnicalTest.Models.Interfaces;

namespace Pharmacy2UTechnicalTest.Models.Classes
{
   public class Currency : IBaseEntity
   {
      public int Id { get; set; }

         [Required]
         [StringLength(3)]
         public string CountryCode { get; set; }

      public virtual IEnumerable<ConversionRate> ConversionRatesFrom { get; set; }

      public virtual IEnumerable<ConversionRate> ConversionRatesTo { get; set; }
   }
}