using System;
using System.Collections.Generic;
using System.Data.Common;
using Dapper;
using DapperRunner.Model;

namespace DapperRunner
{
    public class DapperRainbowTestSuite: TestSuiteBase
    {
        //5.9 minutes
        public override bool ExecuteWriteTest<T>(string connectionStringName, string filePath)
        {
            var people = QueryExcelFile<People>(filePath);

            var connection = SqlConnectionFactory.CreateOpenConnection(connectionStringName);

            var db = TestDb.Init(connection, 2);

            people.ForEach(p => db.People.Insert(p));

            return true;
        }

        public override IEnumerable<T> ExecuteReadTest<T>(string connectionStringName)
        {
            throw new NotImplementedException();
        }
    }

    public class TestDb : Database<TestDb>
    {
        public Table<People> People { get; set; } 
    }
}