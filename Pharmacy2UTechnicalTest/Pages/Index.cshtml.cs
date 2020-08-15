using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Pharmacy2UTechnicalTest.DAL.Interfaces;

namespace Pharmacy2UTechnicalTest.Pages
{
   public class IndexModel : PageModel
   {
      private readonly ILogger<IndexModel> _logger;

      public IndexModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

      //Can pass in the repository objects added into the services container here
      protected IUserRepository _userRepo;
      protected ICurrencyRepository _currencyRepo;          
      protected IConversionRateRepository _rateRepo;
      protected IConversionLogRepository _logRepo;
      //Use the constructorr and the objects will be passed in if they are found in the services container
      public IndexModel(IUserRepository userRepo,
         ICurrencyRepository currencyRepo,
         IConversionRateRepository rateRepo,
         IConversionLogRepository logRepo)
      {
         _userRepo = userRepo;
         _currencyRepo = currencyRepo;
         _rateRepo = rateRepo;
         _logRepo = logRepo;

      }

      public void OnGet()
      {
         //This line will get all the entries in the ConversionRates table
         //It will also attach the related ConvertFrom and ConvertTo entities from the Currency table
         var rates = _rateRepo.GetAllIncluding(r => r.ConvertFrom,
            rates => rates.ConvertTo).ToList();

         //Can get the country code without querying the Currencies table directly
         //Relationships configured in entity classes and db context object take care of the joins
         foreach(var r in rates)
         {
            //Get the rate value
var rate =             r.Rate;

            //Get the country code for the converted from value
            var currencyFrom = r.ConvertFrom.CountryCode;

            //Get the country code of the currency converted to
            var currencyTo = r.ConvertTo.CountryCode;
         }
      }
   }
}
