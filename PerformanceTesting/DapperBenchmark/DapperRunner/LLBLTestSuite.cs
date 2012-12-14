using System;
using System.Collections.Generic;
using DapperRunner.Model;
using LLBL.DAL.DatabaseSpecific;
using LLBL.DAL.EntityClasses;
using LLBL.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace DapperRunner
{
    public class LLBLTestSuite : TestSuiteBase
    {
        //5.8 minutes to execute
        public override bool ExecuteWriteTest<T>(string connectionStringName, string filePath)
        {
            var people = QueryExcelFile<People>(filePath);

            var adapter = new DataAccessAdapter(ConfigurationHelper.GetConnectionString(connectionStringName));

            IEntityCollection2 collection = new EntityCollection();

            foreach (var person in people)
            {
                collection.Add(ToTestPeopleEntity(person));
            }

            adapter.SaveEntityCollection(collection);
            
            return true;
        }

        public override IEnumerable<T> ExecuteReadTest<T>(string connectionStringName)
        {
            throw new NotImplementedException();
        }

        private TestPeople1Entity ToTestPeopleEntity(People person)
        {
            var entity = new TestPeople1Entity();
            entity.Birthday = person.Birthday;
            entity.Ccexpires = person.CCExpires;
            entity.Ccnumber = person.CCNumber;
            entity.Cctype = person.CCType;
            entity.City = person.City;
            entity.Country = person.Country;
            entity.Cvv2 = person.CVV2;
            entity.EmailAddress = person.EmailAddress;
            entity.Gender = person.Gender;
            entity.GivenName = person.GivenName;
            entity.MiddleInitial = person.MiddleInitial;
            entity.MothersMaiden = person.MothersMaiden;
            entity.NationalId = person.NationalID;
            entity.Number = person.Number;
            entity.State = person.State;
            entity.StreetAddress = person.StreetAddress;
            entity.Surname = person.Surname;
            entity.TelephoneNumber = person.Surname;
            entity.ZipCode = person.ZipCode;
            return entity;
        }
    }
}