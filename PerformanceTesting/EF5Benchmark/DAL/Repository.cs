using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            bool retValue = false;
            string peopleSheet = string.Empty;

            var excel = new ExcelQueryFactory();
            excel.FileName = fileName;
            excel.StrictMapping = true;
            var people = from c in excel.Worksheet<Person>("5010264") select c;

            try
            {
                using (PatrickTestEntities db = new PatrickTestEntities())
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

            try
            {
                using (PatrickTestEntities db = new PatrickTestEntities())
                {
                    db.ClearTestPeople();

                    var qty = (from x in db.TestPeoples select x).Count();

                    if(qty == 0)
                        retValue = true;
                }
            }
            catch (Exception)
            {
                throw;
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

            try
            {
                using (PatrickTestEntities db = new PatrickTestEntities())
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
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return retValue;
        }
    }
}
