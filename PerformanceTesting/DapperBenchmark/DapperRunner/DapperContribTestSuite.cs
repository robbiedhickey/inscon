using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using DapperRunner.Model;

namespace DapperRunner
{
    public class DapperContribTestSuite : TestSuiteBase
    {
        public override bool ExecuteWriteTest<T>(string connectionStringName, string filePath)
        {
            bool retVal = true;

            var people = QueryExcelFile<People>(filePath);

            try
            {
                var connection = SqlConnectionFactory.CreateConnection(connectionStringName);
                connection.Open();

                foreach (var person in people)
                {
                    connection.Insert(person);
                }
            }
            catch (Exception e)
            {
                retVal = false;
            }

            return retVal;
        }

        public override IEnumerable<T> ExecuteReadTest<T>(string connectionStringName)
        {
            throw new NotImplementedException();
        }
    }
}