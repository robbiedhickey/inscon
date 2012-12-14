using System;
using System.ComponentModel.DataAnnotations;
using Dapper.Contrib.Extensions;

namespace DapperRunner.Model
{
    [Table("TestPeople1")]
    public class People
    {
        public int Number { get; set; }
        public string Gender { get; set; }
        public string GivenName { get; set; }
        public string MiddleInitial { get; set; }
        public string Surname { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string EmailAddress { get; set; }
        public string TelephoneNumber { get; set; }
        public string MothersMaiden { get; set; }
        public DateTime Birthday { get; set; }
        public string CCType { get; set; }
        public decimal CCNumber { get; set; }
        public int CVV2 { get; set; }
        public string CCExpires { get; set; }
        public string NationalID { get; set; }
    }
}