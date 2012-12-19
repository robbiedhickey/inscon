using System;
using System.Collections.Generic;
using System.Linq;
using LinqToExcel;

namespace MSI.EF5Benchmark.DAL
{
    public class Repository
    {
        public Repository()
        {

        }

        public bool LoadUsingSproc(string fileName)
        {
            bool retValue;

            var excel = new ExcelQueryFactory();
            excel.FileName = fileName;
            excel.StrictMapping = true;
            var people = from c in excel.Worksheet<Person>("5010264") select c;

            try
            {
                using (var db = new PatrickTestEntities())
                {
                    foreach (Person item in people)
                    {
                        db.Insert_TestPeople(item.Number, item.Gender, item.GivenName, item.MiddleInitial, item.Surname,
                                             item.StreetAddress, item.City, item.State, item.ZipCode, item.Country,
                                             item.EmailAddress, item.TelephoneNumber, item.MothersMaiden, item.Birthday,
                                             item.CCType, item.CCNumber, item.CVV2, item.CCExpires, item.NationalID);
                    }

                    retValue = true;

                }
            }
            catch
            {
                retValue = false;
            }

            return retValue;
        }

        public bool ClearTable()
        {
            bool retValue = false;

            using (var db = new PatrickTestEntities())
            {
                db.ClearTestPeople();

                var qty = (from x in db.TestPeoples select x).Count();

                if(qty == 0)
                    retValue = true;
            }

            return retValue;
        }

        public bool LoadUsingLinq(string fileName)
        {
            bool retValue = false;

            var excel = new ExcelQueryFactory();
            excel.FileName = fileName;
            excel.StrictMapping = true;
            var people = from c in excel.Worksheet<Person>("5010264") select c;

            using (var db = new PatrickTestEntities())
            {
                foreach (Person item in people)
                {
                    db.TestPeoples.Add(new TestPeople()
                        {
                            Number = item.Number,
                            Gender = item.Gender,
                            GivenName = item.GivenName,
                            MiddleInitial = item.MiddleInitial,
                            Surname = item.Surname,
                            StreetAddress = item.StreetAddress,
                            City = item.City,
                            State = item.State,
                            ZipCode = item.ZipCode,
                            Country = item.Country,
                            EmailAddress = item.EmailAddress,
                            TelephoneNumber = item.TelephoneNumber,
                            MothersMaiden = item.MothersMaiden,
                            Birthday = item.Birthday,
                            CCType = item.CCType,
                            CCNumber = item.CCNumber,
                            CVV2 = item.CVV2,
                            CCExpires = item.CCExpires,
                            NationalID = item.NationalID
                        });
                }

                retValue = db.SaveChanges() == 10000;

            }

            return retValue;
        }

        public bool LoadUsingDAB(string fileName)
        {
            bool retValue = false;

            var excel = new ExcelQueryFactory();
            excel.FileName = fileName;
            excel.StrictMapping = true;
            var people = from c in excel.Worksheet<Person>("5010264") select c;
            
            return retValue;
        }

        public bool GetUsingEFStoredProc()
        {
            var retValue = new List<Person>();

            using (var db = new PatrickTestEntities())
            {
                var results = db.Select_TestPeople().ToList();

                retValue.AddRange(results.Select(result => new Person
                    {
                        Number = result.Number,
                        Gender = result.Gender,
                        GivenName = result.GivenName,
                        MiddleInitial = result.MiddleInitial,
                        Surname = result.Surname,
                        StreetAddress = result.StreetAddress,
                        City = result.City,
                        State = result.State,
                        ZipCode = result.ZipCode,
                        Country = result.Country,
                        EmailAddress = result.EmailAddress,
                        TelephoneNumber = result.TelephoneNumber,
                        MothersMaiden = result.MothersMaiden,
                        Birthday = Convert.ToDateTime(result.Birthday),
                        CCType = result.CCType,
                        CCNumber = Convert.ToDecimal(result.CCNumber),
                        CVV2 = Convert.ToInt32(result.CVV2),
                        CCExpires = result.CCExpires,
                        NationalID = result.NationalID
                    }));
            }

            return retValue.Count.Equals(1000);
        }

        public bool GetOneUsingEFStoredProc()
        {
            var retValue = new Person();

            using (var db = new PatrickTestEntities())
            {
                var result = db.Select_TestPeopleByID(1).FirstOrDefault();

                if (result != null)
                {
                    retValue = new Person
                        {
                            Number = result.Number,
                            Gender = result.Gender,
                            GivenName = result.GivenName,
                            MiddleInitial = result.MiddleInitial,
                            Surname = result.Surname,
                            StreetAddress = result.StreetAddress,
                            City = result.City,
                            State = result.State,
                            ZipCode = result.ZipCode,
                            Country = result.Country,
                            EmailAddress = result.EmailAddress,
                            TelephoneNumber = result.TelephoneNumber,
                            MothersMaiden = result.MothersMaiden,
                            Birthday = Convert.ToDateTime(result.Birthday),
                            CCType = result.CCType,
                            CCNumber = Convert.ToDecimal(result.CCNumber),
                            CVV2 = Convert.ToInt32(result.CVV2),
                            CCExpires = result.CCExpires,
                            NationalID = result.NationalID
                        };
                }
            }

            return retValue.Number.Equals(1);
        }
    }
}
