///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated on: Friday, December 14, 2012 9:24:17 AM
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBL.DAL.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (3 + 2));
			InitPeopleEntityInfos();
			InitTestPeopleEntityInfos();
			InitTestPeople1EntityInfos();
			InitTestPeopleByIdResponseTypedViewInfos();
			InitTestPeopleResponseTypedViewInfos();
			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits PeopleEntity's FieldInfo objects</summary>
		private void InitPeopleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(PeopleFieldIndex), "PeopleEntity");
			this.AddElementFieldInfo("PeopleEntity", "Birthday", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)PeopleFieldIndex.Birthday, 0, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Ccexpires", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.Ccexpires, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Ccnumber", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)PeopleFieldIndex.Ccnumber, 0, 0, 18);
			this.AddElementFieldInfo("PeopleEntity", "Cctype", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.Cctype, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "City", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.City, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Country", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.Country, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Cvv2", typeof(Nullable<System.Int32>), false, false, false, true,  (int)PeopleFieldIndex.Cvv2, 0, 0, 10);
			this.AddElementFieldInfo("PeopleEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.EmailAddress, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Gender", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.Gender, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "GivenName", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.GivenName, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Id", typeof(System.Int32), true, false, true, false,  (int)PeopleFieldIndex.Id, 0, 0, 10);
			this.AddElementFieldInfo("PeopleEntity", "MiddleInitial", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.MiddleInitial, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "MothersMaiden", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.MothersMaiden, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "NationalId", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.NationalId, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Number", typeof(System.Int32), false, false, false, false,  (int)PeopleFieldIndex.Number, 0, 0, 10);
			this.AddElementFieldInfo("PeopleEntity", "State", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.State, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "StreetAddress", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.StreetAddress, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "Surname", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.Surname, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "TelephoneNumber", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.TelephoneNumber, 64, 0, 0);
			this.AddElementFieldInfo("PeopleEntity", "ZipCode", typeof(System.String), false, false, false, true,  (int)PeopleFieldIndex.ZipCode, 64, 0, 0);
		}
		/// <summary>Inits TestPeopleEntity's FieldInfo objects</summary>
		private void InitTestPeopleEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TestPeopleFieldIndex), "TestPeopleEntity");
			this.AddElementFieldInfo("TestPeopleEntity", "Birthday", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TestPeopleFieldIndex.Birthday, 0, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Ccexpires", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.Ccexpires, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Ccnumber", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)TestPeopleFieldIndex.Ccnumber, 0, 0, 18);
			this.AddElementFieldInfo("TestPeopleEntity", "Cctype", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.Cctype, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "City", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.City, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Country", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.Country, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Cvv2", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TestPeopleFieldIndex.Cvv2, 0, 0, 10);
			this.AddElementFieldInfo("TestPeopleEntity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.EmailAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Gender", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.Gender, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "GivenName", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.GivenName, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "MiddleInitial", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.MiddleInitial, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "MothersMaiden", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.MothersMaiden, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "NationalId", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.NationalId, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Number", typeof(System.Int32), true, false, false, false,  (int)TestPeopleFieldIndex.Number, 0, 0, 10);
			this.AddElementFieldInfo("TestPeopleEntity", "State", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.State, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "StreetAddress", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.StreetAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "Surname", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.Surname, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "TelephoneNumber", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.TelephoneNumber, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleEntity", "ZipCode", typeof(System.String), false, false, false, true,  (int)TestPeopleFieldIndex.ZipCode, 64, 0, 0);
		}
		/// <summary>Inits TestPeople1Entity's FieldInfo objects</summary>
		private void InitTestPeople1EntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TestPeople1FieldIndex), "TestPeople1Entity");
			this.AddElementFieldInfo("TestPeople1Entity", "Birthday", typeof(Nullable<System.DateTime>), false, false, false, true,  (int)TestPeople1FieldIndex.Birthday, 0, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Ccexpires", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.Ccexpires, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Ccnumber", typeof(Nullable<System.Decimal>), false, false, false, true,  (int)TestPeople1FieldIndex.Ccnumber, 0, 0, 18);
			this.AddElementFieldInfo("TestPeople1Entity", "Cctype", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.Cctype, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "City", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.City, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Country", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.Country, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Cvv2", typeof(Nullable<System.Int32>), false, false, false, true,  (int)TestPeople1FieldIndex.Cvv2, 0, 0, 10);
			this.AddElementFieldInfo("TestPeople1Entity", "EmailAddress", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.EmailAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Gender", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.Gender, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "GivenName", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.GivenName, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "MiddleInitial", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.MiddleInitial, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "MothersMaiden", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.MothersMaiden, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "NationalId", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.NationalId, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Number", typeof(System.Int32), true, false, false, false,  (int)TestPeople1FieldIndex.Number, 0, 0, 10);
			this.AddElementFieldInfo("TestPeople1Entity", "State", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.State, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "StreetAddress", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.StreetAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "Surname", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.Surname, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "TelephoneNumber", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.TelephoneNumber, 64, 0, 0);
			this.AddElementFieldInfo("TestPeople1Entity", "ZipCode", typeof(System.String), false, false, false, true,  (int)TestPeople1FieldIndex.ZipCode, 64, 0, 0);
		}

		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitTestPeopleByIdResponseTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TestPeopleByIdResponseFieldIndex), "TestPeopleByIdResponseTypedView");
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Number", typeof(System.Int32), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Number, 0, 0, 10);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Gender", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Gender, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "GivenName", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.GivenName, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "MiddleInitial", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.MiddleInitial, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Surname", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Surname, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "StreetAddress", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.StreetAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "City", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.City, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "State", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.State, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "ZipCode", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.ZipCode, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Country", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Country, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "EmailAddress", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.EmailAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "TelephoneNumber", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.TelephoneNumber, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "MothersMaiden", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.MothersMaiden, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Birthday", typeof(System.DateTime), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Birthday, 0, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Cctype", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Cctype, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Ccnumber", typeof(System.Decimal), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Ccnumber, 0, 0, 18);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Cvv2", typeof(System.Int32), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Cvv2, 0, 0, 10);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "Ccexpires", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.Ccexpires, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleByIdResponseTypedView", "NationalId", typeof(System.String), false, false, true, false, (int)TestPeopleByIdResponseFieldIndex.NationalId, 64, 0, 0);
		}
		/// <summary>Inits View's FieldInfo objects</summary>
		private void InitTestPeopleResponseTypedViewInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TestPeopleResponseFieldIndex), "TestPeopleResponseTypedView");
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Number", typeof(System.Int32), false, false, true, false, (int)TestPeopleResponseFieldIndex.Number, 0, 0, 10);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Gender", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.Gender, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "GivenName", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.GivenName, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "MiddleInitial", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.MiddleInitial, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Surname", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.Surname, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "StreetAddress", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.StreetAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "City", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.City, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "State", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.State, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "ZipCode", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.ZipCode, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Country", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.Country, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "EmailAddress", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.EmailAddress, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "TelephoneNumber", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.TelephoneNumber, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "MothersMaiden", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.MothersMaiden, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Birthday", typeof(System.DateTime), false, false, true, false, (int)TestPeopleResponseFieldIndex.Birthday, 0, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Cctype", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.Cctype, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Ccnumber", typeof(System.Decimal), false, false, true, false, (int)TestPeopleResponseFieldIndex.Ccnumber, 0, 0, 18);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Cvv2", typeof(System.Int32), false, false, true, false, (int)TestPeopleResponseFieldIndex.Cvv2, 0, 0, 10);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "Ccexpires", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.Ccexpires, 64, 0, 0);
			this.AddElementFieldInfo("TestPeopleResponseTypedView", "NationalId", typeof(System.String), false, false, true, false, (int)TestPeopleResponseFieldIndex.NationalId, 64, 0, 0);
		}		
	}
}




