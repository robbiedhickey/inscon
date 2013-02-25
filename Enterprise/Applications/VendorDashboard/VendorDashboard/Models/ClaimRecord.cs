using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Models
{
    public class ClaimRecord
    {
        public int Id { get; set; }
        [Required]
        public string CarrierName { get; set; }

        [DataType(DataType.Url)]
        public string CarrierSite { get; set; }

        [DataType(DataType.Date)]
        public DateTime ClaimStartDate { get; set; }

        [DataType(DataType.Currency)]
        public Decimal ClaimAmount { get; set; }
    }

    public static class ModelIntializer
    {
        public static List<ClaimRecord> CreateHomeInputModels()
        {
            return new List<ClaimRecord>
                       {
                           new ClaimRecord
                               {
                                   Id = 1,
                                   CarrierSite = "http://foobar.com",
                                   CarrierName = "asdf",
                                   ClaimAmount = 100,
                                   ClaimStartDate = DateTime.Now.AddYears(-1)
                               },
                           new ClaimRecord
                               {
                                   Id = 2,
                                   CarrierSite = "http://foobar.com",
                                   CarrierName = "fffff",
                                   ClaimAmount = 200,
                                   ClaimStartDate = DateTime.Now.AddYears(-2)
                               },
                       };
        }
    }

    public static class ModelExtention
    {
        public static ClaimRecord Get(this List<ClaimRecord> models, int id)
        {
            return models.First(x => x.Id == id);
        }
    }
}