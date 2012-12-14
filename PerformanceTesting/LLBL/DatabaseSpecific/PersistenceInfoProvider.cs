///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: Friday, December 14, 2012 9:24:18 AM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBL.DAL.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((3 + 2));
			InitPeopleEntityMappings();
			InitTestPeopleEntityMappings();
			InitTestPeople1EntityMappings();
			InitTestPeopleByIdResponseTypedViewMappings();
			InitTestPeopleResponseTypedViewMappings();
		}


		/// <summary>Inits PeopleEntity's mappings</summary>
		private void InitPeopleEntityMappings()
		{
			this.AddElementMapping( "PeopleEntity", @"PatrickTest", @"dbo", "People", 20 );
			this.AddElementFieldMapping( "PeopleEntity", "Birthday", "Birthday", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "PeopleEntity", "Ccexpires", "CCExpires", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "PeopleEntity", "Ccnumber", "CCNumber", true, "Decimal", 0, 0, 18, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "PeopleEntity", "Cctype", "CCType", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "PeopleEntity", "City", "City", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "PeopleEntity", "Country", "Country", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "PeopleEntity", "Cvv2", "CVV2", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "PeopleEntity", "EmailAddress", "EmailAddress", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "PeopleEntity", "Gender", "Gender", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "PeopleEntity", "GivenName", "GivenName", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "PeopleEntity", "Id", "Id", false, "Int", 0, 0, 10, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 10 );
			this.AddElementFieldMapping( "PeopleEntity", "MiddleInitial", "MiddleInitial", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "PeopleEntity", "MothersMaiden", "MothersMaiden", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "PeopleEntity", "NationalId", "NationalID", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 13 );
			this.AddElementFieldMapping( "PeopleEntity", "Number", "Number", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 14 );
			this.AddElementFieldMapping( "PeopleEntity", "State", "State", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "PeopleEntity", "StreetAddress", "StreetAddress", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "PeopleEntity", "Surname", "Surname", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "PeopleEntity", "TelephoneNumber", "TelephoneNumber", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 18 );
			this.AddElementFieldMapping( "PeopleEntity", "ZipCode", "ZipCode", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 19 );
		}
		/// <summary>Inits TestPeopleEntity's mappings</summary>
		private void InitTestPeopleEntityMappings()
		{
			this.AddElementMapping( "TestPeopleEntity", @"PatrickTest", @"dbo", "TestPeople", 19 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Birthday", "Birthday", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Ccexpires", "CCExpires", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Ccnumber", "CCNumber", true, "Decimal", 0, 0, 18, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Cctype", "CCType", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "TestPeopleEntity", "City", "City", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Country", "Country", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Cvv2", "CVV2", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "TestPeopleEntity", "EmailAddress", "EmailAddress", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Gender", "Gender", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "TestPeopleEntity", "GivenName", "GivenName", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "TestPeopleEntity", "MiddleInitial", "MiddleInitial", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "TestPeopleEntity", "MothersMaiden", "MothersMaiden", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "TestPeopleEntity", "NationalId", "NationalID", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Number", "Number", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			this.AddElementFieldMapping( "TestPeopleEntity", "State", "State", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "TestPeopleEntity", "StreetAddress", "StreetAddress", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "TestPeopleEntity", "Surname", "Surname", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "TestPeopleEntity", "TelephoneNumber", "TelephoneNumber", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "TestPeopleEntity", "ZipCode", "ZipCode", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 18 );
		}
		/// <summary>Inits TestPeople1Entity's mappings</summary>
		private void InitTestPeople1EntityMappings()
		{
			this.AddElementMapping( "TestPeople1Entity", @"PatrickTest", @"dbo", "TestPeople1", 19 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Birthday", "Birthday", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Ccexpires", "CCExpires", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Ccnumber", "CCNumber", true, "Decimal", 0, 0, 18, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Cctype", "CCType", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "TestPeople1Entity", "City", "City", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Country", "Country", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Cvv2", "CVV2", true, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 6 );
			this.AddElementFieldMapping( "TestPeople1Entity", "EmailAddress", "EmailAddress", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Gender", "Gender", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "TestPeople1Entity", "GivenName", "GivenName", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "TestPeople1Entity", "MiddleInitial", "MiddleInitial", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "TestPeople1Entity", "MothersMaiden", "MothersMaiden", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "TestPeople1Entity", "NationalId", "NationalID", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Number", "Number", false, "Int", 0, 0, 10, false, "", null, typeof(System.Int32), 13 );
			this.AddElementFieldMapping( "TestPeople1Entity", "State", "State", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "TestPeople1Entity", "StreetAddress", "StreetAddress", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 15 );
			this.AddElementFieldMapping( "TestPeople1Entity", "Surname", "Surname", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 16 );
			this.AddElementFieldMapping( "TestPeople1Entity", "TelephoneNumber", "TelephoneNumber", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "TestPeople1Entity", "ZipCode", "ZipCode", true, "NVarChar", 64, 0, 0, false, "", null, typeof(System.String), 18 );
		}

		/// <summary>Inits View's mappings</summary>
		private void InitTestPeopleByIdResponseTypedViewMappings()
		{
			this.AddElementMapping( "TestPeopleByIdResponseTypedView", @"PatrickTest", @"dbo", "Resultset1", 19 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Number", "Number", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Gender", "Gender", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "GivenName", "GivenName", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "MiddleInitial", "MiddleInitial", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Surname", "Surname", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "StreetAddress", "StreetAddress", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "City", "City", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "State", "State", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "ZipCode", "ZipCode", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Country", "Country", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "EmailAddress", "EmailAddress", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "TelephoneNumber", "TelephoneNumber", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "MothersMaiden", "MothersMaiden", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Birthday", "Birthday", false, "DateTime", 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 13 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Cctype", "CCType", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Ccnumber", "CCNumber", false, "Decimal", 0, 0, 18,false, string.Empty, null, typeof(System.Decimal), 15 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Cvv2", "CVV2", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 16 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "Ccexpires", "CCExpires", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "TestPeopleByIdResponseTypedView", "NationalId", "NationalID", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 18 );
		}
		/// <summary>Inits View's mappings</summary>
		private void InitTestPeopleResponseTypedViewMappings()
		{
			this.AddElementMapping( "TestPeopleResponseTypedView", @"PatrickTest", @"dbo", "Resultset1", 19 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Number", "Number", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 0 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Gender", "Gender", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "GivenName", "GivenName", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "MiddleInitial", "MiddleInitial", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Surname", "Surname", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 4 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "StreetAddress", "StreetAddress", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "City", "City", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 6 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "State", "State", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 7 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "ZipCode", "ZipCode", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 8 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Country", "Country", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 9 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "EmailAddress", "EmailAddress", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 10 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "TelephoneNumber", "TelephoneNumber", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 11 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "MothersMaiden", "MothersMaiden", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 12 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Birthday", "Birthday", false, "DateTime", 0, 0, 0,false, string.Empty, null, typeof(System.DateTime), 13 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Cctype", "CCType", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 14 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Ccnumber", "CCNumber", false, "Decimal", 0, 0, 18,false, string.Empty, null, typeof(System.Decimal), 15 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Cvv2", "CVV2", false, "Int", 0, 0, 10,false, string.Empty, null, typeof(System.Int32), 16 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "Ccexpires", "CCExpires", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 17 );
			this.AddElementFieldMapping( "TestPeopleResponseTypedView", "NationalId", "NationalID", false, "NVarChar", 64, 0, 0,false, string.Empty, null, typeof(System.String), 18 );
		}
	}
}