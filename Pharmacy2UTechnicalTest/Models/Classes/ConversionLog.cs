using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Pharmacy2UTechnicalTest.Models.Interfaces;
using System.Net;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pharmacy2UTechnicalTest.Models.Classes
{
   public class ConversionLog : IBaseEntity
   {      
      public int Id { get; set; }

      public int ConversionRateId { get; set; }

      public virtual ConversionRate ConversionRate { get; set; }

      [Column(TypeName = "decimal(10,4)")]
      public decimal Rate { get; set; }

      [Column(TypeName = "decimal(18,2)")]
      public decimal ValueFrom { get; set; }

      [Column(TypeName = "decimal(18,2)")]
      public decimal ValueTo { get; set; }

      public DateTime ConversionDate { get; set; }

      public int UserId { get; set; }

      public virtual User User {get;set;}
   }
}