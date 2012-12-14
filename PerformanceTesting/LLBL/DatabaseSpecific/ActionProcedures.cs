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
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBL.DAL.DatabaseSpecific
{
	/// <summary>Class which contains the static logic to execute action stored procedures in the database.</summary>
	public static partial class ActionProcedures
	{

		/// <summary>Delegate definition for stored procedure 'ClearTestPeople' to be used in combination of a UnitOfWork2 object.</summary>
		public delegate int ClearTestPeopleCallBack(IDataAccessCore dataAccessProvider);
		/// <summary>Delegate definition for stored procedure 'Delete_TestPeopleByID' to be used in combination of a UnitOfWork2 object.</summary>
		public delegate int DeleteTestPeopleByIdCallBack(System.Int32 prmNumber, IDataAccessCore dataAccessProvider);
		/// <summary>Delegate definition for stored procedure 'Insert_TestPeople' to be used in combination of a UnitOfWork2 object.</summary>
		public delegate int InsertTestPeopleCallBack(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId, IDataAccessCore dataAccessProvider);
		/// <summary>Delegate definition for stored procedure 'Insert_TestPeople1' to be used in combination of a UnitOfWork2 object.</summary>
		public delegate int InsertTestPeople1CallBack(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId, IDataAccessCore dataAccessProvider);
		/// <summary>Delegate definition for stored procedure 'Update_TestPeople' to be used in combination of a UnitOfWork2 object.</summary>
		public delegate int UpdateTestPeopleCallBack(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId, IDataAccessCore dataAccessProvider);


		/// <summary>Calls stored procedure 'ClearTestPeople'.<br/><br/></summary>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int ClearTestPeople()
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return ClearTestPeople(dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'ClearTestPeople'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int ClearTestPeople(IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateClearTestPeopleCall(dataAccessProvider))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}

		/// <summary>Calls stored procedure 'Delete_TestPeopleByID'.<br/><br/></summary>
		/// <param name="prmNumber">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int DeleteTestPeopleById(System.Int32 prmNumber)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return DeleteTestPeopleById(prmNumber, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'Delete_TestPeopleByID'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int DeleteTestPeopleById(System.Int32 prmNumber, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateDeleteTestPeopleByIdCall(dataAccessProvider, prmNumber))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}

		/// <summary>Calls stored procedure 'Insert_TestPeople'.<br/><br/></summary>
		/// <param name="prmNumber">Input parameter. </param>
		/// <param name="prmGender">Input parameter. </param>
		/// <param name="prmGivenName">Input parameter. </param>
		/// <param name="prmMiddleInitial">Input parameter. </param>
		/// <param name="prmSurname">Input parameter. </param>
		/// <param name="prmStreetAddress">Input parameter. </param>
		/// <param name="prmCity">Input parameter. </param>
		/// <param name="prmState">Input parameter. </param>
		/// <param name="prmZipCode">Input parameter. </param>
		/// <param name="prmCountry">Input parameter. </param>
		/// <param name="prmEmailAddress">Input parameter. </param>
		/// <param name="prmTelephoneNumber">Input parameter. </param>
		/// <param name="prmMothersMaiden">Input parameter. </param>
		/// <param name="prmBirthday">Input parameter. </param>
		/// <param name="prmCctype">Input parameter. </param>
		/// <param name="prmCcnumber">Input parameter. </param>
		/// <param name="prmCvv2">Input parameter. </param>
		/// <param name="prmCcexpires">Input parameter. </param>
		/// <param name="prmNationalId">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int InsertTestPeople(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return InsertTestPeople(prmNumber, prmGender, prmGivenName, prmMiddleInitial, prmSurname, prmStreetAddress, prmCity, prmState, prmZipCode, prmCountry, prmEmailAddress,  
prmTelephoneNumber, prmMothersMaiden, prmBirthday, prmCctype, prmCcnumber, prmCvv2, prmCcexpires, prmNationalId, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'Insert_TestPeople'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter. </param>
		/// <param name="prmGender">Input parameter. </param>
		/// <param name="prmGivenName">Input parameter. </param>
		/// <param name="prmMiddleInitial">Input parameter. </param>
		/// <param name="prmSurname">Input parameter. </param>
		/// <param name="prmStreetAddress">Input parameter. </param>
		/// <param name="prmCity">Input parameter. </param>
		/// <param name="prmState">Input parameter. </param>
		/// <param name="prmZipCode">Input parameter. </param>
		/// <param name="prmCountry">Input parameter. </param>
		/// <param name="prmEmailAddress">Input parameter. </param>
		/// <param name="prmTelephoneNumber">Input parameter. </param>
		/// <param name="prmMothersMaiden">Input parameter. </param>
		/// <param name="prmBirthday">Input parameter. </param>
		/// <param name="prmCctype">Input parameter. </param>
		/// <param name="prmCcnumber">Input parameter. </param>
		/// <param name="prmCvv2">Input parameter. </param>
		/// <param name="prmCcexpires">Input parameter. </param>
		/// <param name="prmNationalId">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int InsertTestPeople(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateInsertTestPeopleCall(dataAccessProvider, prmNumber, prmGender, prmGivenName, prmMiddleInitial, prmSurname, prmStreetAddress, prmCity, prmState, prmZipCode, prmCountry, prmEmailAddress,  
prmTelephoneNumber, prmMothersMaiden, prmBirthday, prmCctype, prmCcnumber, prmCvv2, prmCcexpires, prmNationalId))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}

		/// <summary>Calls stored procedure 'Insert_TestPeople1'.<br/><br/></summary>
		/// <param name="prmNumber">Input parameter. </param>
		/// <param name="prmGender">Input parameter. </param>
		/// <param name="prmGivenName">Input parameter. </param>
		/// <param name="prmMiddleInitial">Input parameter. </param>
		/// <param name="prmSurname">Input parameter. </param>
		/// <param name="prmStreetAddress">Input parameter. </param>
		/// <param name="prmCity">Input parameter. </param>
		/// <param name="prmState">Input parameter. </param>
		/// <param name="prmZipCode">Input parameter. </param>
		/// <param name="prmCountry">Input parameter. </param>
		/// <param name="prmEmailAddress">Input parameter. </param>
		/// <param name="prmTelephoneNumber">Input parameter. </param>
		/// <param name="prmMothersMaiden">Input parameter. </param>
		/// <param name="prmBirthday">Input parameter. </param>
		/// <param name="prmCctype">Input parameter. </param>
		/// <param name="prmCcnumber">Input parameter. </param>
		/// <param name="prmCvv2">Input parameter. </param>
		/// <param name="prmCcexpires">Input parameter. </param>
		/// <param name="prmNationalId">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int InsertTestPeople1(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return InsertTestPeople1(prmNumber, prmGender, prmGivenName, prmMiddleInitial, prmSurname, prmStreetAddress, prmCity, prmState, prmZipCode, prmCountry, prmEmailAddress,  
prmTelephoneNumber, prmMothersMaiden, prmBirthday, prmCctype, prmCcnumber, prmCvv2, prmCcexpires, prmNationalId, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'Insert_TestPeople1'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter. </param>
		/// <param name="prmGender">Input parameter. </param>
		/// <param name="prmGivenName">Input parameter. </param>
		/// <param name="prmMiddleInitial">Input parameter. </param>
		/// <param name="prmSurname">Input parameter. </param>
		/// <param name="prmStreetAddress">Input parameter. </param>
		/// <param name="prmCity">Input parameter. </param>
		/// <param name="prmState">Input parameter. </param>
		/// <param name="prmZipCode">Input parameter. </param>
		/// <param name="prmCountry">Input parameter. </param>
		/// <param name="prmEmailAddress">Input parameter. </param>
		/// <param name="prmTelephoneNumber">Input parameter. </param>
		/// <param name="prmMothersMaiden">Input parameter. </param>
		/// <param name="prmBirthday">Input parameter. </param>
		/// <param name="prmCctype">Input parameter. </param>
		/// <param name="prmCcnumber">Input parameter. </param>
		/// <param name="prmCvv2">Input parameter. </param>
		/// <param name="prmCcexpires">Input parameter. </param>
		/// <param name="prmNationalId">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int InsertTestPeople1(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateInsertTestPeople1Call(dataAccessProvider, prmNumber, prmGender, prmGivenName, prmMiddleInitial, prmSurname, prmStreetAddress, prmCity, prmState, prmZipCode, prmCountry, prmEmailAddress,  
prmTelephoneNumber, prmMothersMaiden, prmBirthday, prmCctype, prmCcnumber, prmCvv2, prmCcexpires, prmNationalId))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}

		/// <summary>Calls stored procedure 'Update_TestPeople'.<br/><br/></summary>
		/// <param name="prmNumber">Input parameter. </param>
		/// <param name="prmGender">Input parameter. </param>
		/// <param name="prmGivenName">Input parameter. </param>
		/// <param name="prmMiddleInitial">Input parameter. </param>
		/// <param name="prmSurname">Input parameter. </param>
		/// <param name="prmStreetAddress">Input parameter. </param>
		/// <param name="prmCity">Input parameter. </param>
		/// <param name="prmState">Input parameter. </param>
		/// <param name="prmZipCode">Input parameter. </param>
		/// <param name="prmCountry">Input parameter. </param>
		/// <param name="prmEmailAddress">Input parameter. </param>
		/// <param name="prmTelephoneNumber">Input parameter. </param>
		/// <param name="prmMothersMaiden">Input parameter. </param>
		/// <param name="prmBirthday">Input parameter. </param>
		/// <param name="prmCctype">Input parameter. </param>
		/// <param name="prmCcnumber">Input parameter. </param>
		/// <param name="prmCvv2">Input parameter. </param>
		/// <param name="prmCcexpires">Input parameter. </param>
		/// <param name="prmNationalId">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int UpdateTestPeople(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return UpdateTestPeople(prmNumber, prmGender, prmGivenName, prmMiddleInitial, prmSurname, prmStreetAddress, prmCity, prmState, prmZipCode, prmCountry, prmEmailAddress,  
prmTelephoneNumber, prmMothersMaiden, prmBirthday, prmCctype, prmCcnumber, prmCvv2, prmCcexpires, prmNationalId, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'Update_TestPeople'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter. </param>
		/// <param name="prmGender">Input parameter. </param>
		/// <param name="prmGivenName">Input parameter. </param>
		/// <param name="prmMiddleInitial">Input parameter. </param>
		/// <param name="prmSurname">Input parameter. </param>
		/// <param name="prmStreetAddress">Input parameter. </param>
		/// <param name="prmCity">Input parameter. </param>
		/// <param name="prmState">Input parameter. </param>
		/// <param name="prmZipCode">Input parameter. </param>
		/// <param name="prmCountry">Input parameter. </param>
		/// <param name="prmEmailAddress">Input parameter. </param>
		/// <param name="prmTelephoneNumber">Input parameter. </param>
		/// <param name="prmMothersMaiden">Input parameter. </param>
		/// <param name="prmBirthday">Input parameter. </param>
		/// <param name="prmCctype">Input parameter. </param>
		/// <param name="prmCcnumber">Input parameter. </param>
		/// <param name="prmCvv2">Input parameter. </param>
		/// <param name="prmCcexpires">Input parameter. </param>
		/// <param name="prmNationalId">Input parameter. </param>
		/// <returns>Number of rows affected, if the database / routine doesn't suppress rowcounting.</returns>
		public static int UpdateTestPeople(System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateUpdateTestPeopleCall(dataAccessProvider, prmNumber, prmGender, prmGivenName, prmMiddleInitial, prmSurname, prmStreetAddress, prmCity, prmState, prmZipCode, prmCountry, prmEmailAddress,  
prmTelephoneNumber, prmMothersMaiden, prmBirthday, prmCctype, prmCcnumber, prmCvv2, prmCcexpires, prmNationalId))
			{
				int toReturn = call.Call();
				return toReturn;
			}
		}
		
		/// <summary>Creates the call object for the call 'ClearTestPeople' to stored procedure 'ClearTestPeople'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateClearTestPeopleCall(IDataAccessCore dataAccessProvider)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[ClearTestPeople]", "ClearTestPeople");
		}

		/// <summary>Creates the call object for the call 'DeleteTestPeopleById' to stored procedure 'Delete_TestPeopleByID'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateDeleteTestPeopleByIdCall(IDataAccessCore dataAccessProvider, System.Int32 prmNumber)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[Delete_TestPeopleByID]", "DeleteTestPeopleById")
							.AddParameter("@prm_Number", "Int", 0, ParameterDirection.Input, true, 10, 0, prmNumber);
		}

		/// <summary>Creates the call object for the call 'InsertTestPeople' to stored procedure 'Insert_TestPeople'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter</param>
		/// <param name="prmGender">Input parameter</param>
		/// <param name="prmGivenName">Input parameter</param>
		/// <param name="prmMiddleInitial">Input parameter</param>
		/// <param name="prmSurname">Input parameter</param>
		/// <param name="prmStreetAddress">Input parameter</param>
		/// <param name="prmCity">Input parameter</param>
		/// <param name="prmState">Input parameter</param>
		/// <param name="prmZipCode">Input parameter</param>
		/// <param name="prmCountry">Input parameter</param>
		/// <param name="prmEmailAddress">Input parameter</param>
		/// <param name="prmTelephoneNumber">Input parameter</param>
		/// <param name="prmMothersMaiden">Input parameter</param>
		/// <param name="prmBirthday">Input parameter</param>
		/// <param name="prmCctype">Input parameter</param>
		/// <param name="prmCcnumber">Input parameter</param>
		/// <param name="prmCvv2">Input parameter</param>
		/// <param name="prmCcexpires">Input parameter</param>
		/// <param name="prmNationalId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateInsertTestPeopleCall(IDataAccessCore dataAccessProvider, System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[Insert_TestPeople]", "InsertTestPeople")
							.AddParameter("@prm_Number", "Int", 0, ParameterDirection.Input, true, 10, 0, prmNumber)
							.AddParameter("@prm_Gender", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmGender)
							.AddParameter("@prm_GivenName", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmGivenName)
							.AddParameter("@prm_MiddleInitial", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmMiddleInitial)
							.AddParameter("@prm_Surname", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmSurname)
							.AddParameter("@prm_StreetAddress", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmStreetAddress)
							.AddParameter("@prm_City", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCity)
							.AddParameter("@prm_State", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmState)
							.AddParameter("@prm_ZipCode", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmZipCode)
							.AddParameter("@prm_Country", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCountry)
							.AddParameter("@prm_EmailAddress", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmEmailAddress) 

							.AddParameter("@prm_TelephoneNumber", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmTelephoneNumber)
							.AddParameter("@prm_MothersMaiden", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmMothersMaiden)
							.AddParameter("@prm_Birthday", "DateTime", 0, ParameterDirection.Input, true, 0, 0, prmBirthday)
							.AddParameter("@prm_CCType", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCctype)
							.AddParameter("@prm_CCNumber", "Decimal", 0, ParameterDirection.Input, true, 18, 0, prmCcnumber)
							.AddParameter("@prm_CVV2", "Int", 0, ParameterDirection.Input, true, 10, 0, prmCvv2)
							.AddParameter("@prm_CCExpires", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCcexpires)
							.AddParameter("@prm_NationalID", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmNationalId);
		}

		/// <summary>Creates the call object for the call 'InsertTestPeople1' to stored procedure 'Insert_TestPeople1'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter</param>
		/// <param name="prmGender">Input parameter</param>
		/// <param name="prmGivenName">Input parameter</param>
		/// <param name="prmMiddleInitial">Input parameter</param>
		/// <param name="prmSurname">Input parameter</param>
		/// <param name="prmStreetAddress">Input parameter</param>
		/// <param name="prmCity">Input parameter</param>
		/// <param name="prmState">Input parameter</param>
		/// <param name="prmZipCode">Input parameter</param>
		/// <param name="prmCountry">Input parameter</param>
		/// <param name="prmEmailAddress">Input parameter</param>
		/// <param name="prmTelephoneNumber">Input parameter</param>
		/// <param name="prmMothersMaiden">Input parameter</param>
		/// <param name="prmBirthday">Input parameter</param>
		/// <param name="prmCctype">Input parameter</param>
		/// <param name="prmCcnumber">Input parameter</param>
		/// <param name="prmCvv2">Input parameter</param>
		/// <param name="prmCcexpires">Input parameter</param>
		/// <param name="prmNationalId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateInsertTestPeople1Call(IDataAccessCore dataAccessProvider, System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[Insert_TestPeople1]", "InsertTestPeople1")
							.AddParameter("@prm_Number", "Int", 0, ParameterDirection.Input, true, 10, 0, prmNumber)
							.AddParameter("@prm_Gender", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmGender)
							.AddParameter("@prm_GivenName", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmGivenName)
							.AddParameter("@prm_MiddleInitial", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmMiddleInitial)
							.AddParameter("@prm_Surname", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmSurname)
							.AddParameter("@prm_StreetAddress", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmStreetAddress)
							.AddParameter("@prm_City", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCity)
							.AddParameter("@prm_State", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmState)
							.AddParameter("@prm_ZipCode", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmZipCode)
							.AddParameter("@prm_Country", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCountry)
							.AddParameter("@prm_EmailAddress", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmEmailAddress) 

							.AddParameter("@prm_TelephoneNumber", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmTelephoneNumber)
							.AddParameter("@prm_MothersMaiden", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmMothersMaiden)
							.AddParameter("@prm_Birthday", "DateTime", 0, ParameterDirection.Input, true, 0, 0, prmBirthday)
							.AddParameter("@prm_CCType", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCctype)
							.AddParameter("@prm_CCNumber", "Decimal", 0, ParameterDirection.Input, true, 18, 0, prmCcnumber)
							.AddParameter("@prm_CVV2", "Int", 0, ParameterDirection.Input, true, 10, 0, prmCvv2)
							.AddParameter("@prm_CCExpires", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCcexpires)
							.AddParameter("@prm_NationalID", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmNationalId);
		}

		/// <summary>Creates the call object for the call 'UpdateTestPeople' to stored procedure 'Update_TestPeople'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter</param>
		/// <param name="prmGender">Input parameter</param>
		/// <param name="prmGivenName">Input parameter</param>
		/// <param name="prmMiddleInitial">Input parameter</param>
		/// <param name="prmSurname">Input parameter</param>
		/// <param name="prmStreetAddress">Input parameter</param>
		/// <param name="prmCity">Input parameter</param>
		/// <param name="prmState">Input parameter</param>
		/// <param name="prmZipCode">Input parameter</param>
		/// <param name="prmCountry">Input parameter</param>
		/// <param name="prmEmailAddress">Input parameter</param>
		/// <param name="prmTelephoneNumber">Input parameter</param>
		/// <param name="prmMothersMaiden">Input parameter</param>
		/// <param name="prmBirthday">Input parameter</param>
		/// <param name="prmCctype">Input parameter</param>
		/// <param name="prmCcnumber">Input parameter</param>
		/// <param name="prmCvv2">Input parameter</param>
		/// <param name="prmCcexpires">Input parameter</param>
		/// <param name="prmNationalId">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateUpdateTestPeopleCall(IDataAccessCore dataAccessProvider, System.Int32 prmNumber, System.String prmGender, System.String prmGivenName, System.String prmMiddleInitial, System.String prmSurname, System.String prmStreetAddress, System.String prmCity, System.String prmState, System.String prmZipCode, System.String prmCountry, System.String prmEmailAddress,  
System.String prmTelephoneNumber, System.String prmMothersMaiden, System.DateTime prmBirthday, System.String prmCctype, System.Decimal prmCcnumber, System.Int32 prmCvv2, System.String prmCcexpires, System.String prmNationalId)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[Update_TestPeople]", "UpdateTestPeople")
							.AddParameter("@prm_Number", "Int", 0, ParameterDirection.Input, true, 10, 0, prmNumber)
							.AddParameter("@prm_Gender", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmGender)
							.AddParameter("@prm_GivenName", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmGivenName)
							.AddParameter("@prm_MiddleInitial", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmMiddleInitial)
							.AddParameter("@prm_Surname", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmSurname)
							.AddParameter("@prm_StreetAddress", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmStreetAddress)
							.AddParameter("@prm_City", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCity)
							.AddParameter("@prm_State", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmState)
							.AddParameter("@prm_ZipCode", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmZipCode)
							.AddParameter("@prm_Country", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCountry)
							.AddParameter("@prm_EmailAddress", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmEmailAddress) 

							.AddParameter("@prm_TelephoneNumber", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmTelephoneNumber)
							.AddParameter("@prm_MothersMaiden", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmMothersMaiden)
							.AddParameter("@prm_Birthday", "DateTime", 0, ParameterDirection.Input, true, 0, 0, prmBirthday)
							.AddParameter("@prm_CCType", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCctype)
							.AddParameter("@prm_CCNumber", "Decimal", 0, ParameterDirection.Input, true, 18, 0, prmCcnumber)
							.AddParameter("@prm_CVV2", "Int", 0, ParameterDirection.Input, true, 10, 0, prmCvv2)
							.AddParameter("@prm_CCExpires", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmCcexpires)
							.AddParameter("@prm_NationalID", "NVarChar", 64, ParameterDirection.Input, true, 0, 0, prmNationalId);
		}


		#region Included Code

		#endregion
	}
}
