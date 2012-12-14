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
	/// <summary>Class which contains the static logic to execute retrieval stored procedures in the database.</summary>
	public static partial class RetrievalProcedures
	{

		/// <summary>Gets the SP Call using query for fetching the TestPeopleByIdResponse TypedView.</summary>
		/// <param name="prmNumber">Input parameter of stored procedure</param>
		/// <returns>ready to use IRetrievalQuery instance for fetching the typedview</returns>
		/// <remarks>Output parameters are not set after query is executed</remarks>
		public static IRetrievalQuery GetQueryForTestPeopleByIdResponseTypedView(System.Int32 prmNumber)
		{
			IRetrievalQuery query = GetSelectTestPeopleByIdCallAsQuery(prmNumber);
			query.ResultsetNumber = 1;
			return query;
		}
		
		/// <summary>Fetches the typed view 'TestPeopleByIdResponse' using a stored procedure call. </summary>
		/// <param name="typedViewToFetch">The typed view to fetch. Should be a 'TestPeopleByIdResponseTypedView' instance</param>
		/// <param name="prmNumber">Input parameter of stored procedure</param>
		/// <returns> The specified TypedView to fetch</returns>
		public static TTypedView FetchTestPeopleByIdResponseTypedView<TTypedView>(TTypedView typedViewToFetch, System.Int32 prmNumber)
			where TTypedView: ITypedView2 
		{
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				FetchTestPeopleByIdResponseTypedView(adapter, typedViewToFetch, prmNumber);
			}
			return typedViewToFetch;
		}

		/// <summary>Fetches the typed view 'TestPeopleByIdResponse' using a stored procedure call. </summary>
		/// <param name="adapter">The adapter.</param>
		/// <param name="typedViewToFetch">The typed view to fetch. Should be a 'TestPeopleByIdResponseTypedView' instance</param>
		/// <param name="prmNumber">Input parameter of stored procedure</param>
		public static void FetchTestPeopleByIdResponseTypedView(IDataAccessAdapter adapter, ITypedView2 typedViewToFetch, System.Int32 prmNumber)
		{
			StoredProcedureCall call = CreateSelectTestPeopleByIdCall(adapter, prmNumber);
			IRetrievalQuery query = call.ToRetrievalQuery();
			query.ResultsetNumber = 1;
			adapter.FetchTypedView(typedViewToFetch, query);
		}

		/// <summary>Gets the SP Call using query for fetching the TestPeopleResponse TypedView.</summary>
		/// <returns>ready to use IRetrievalQuery instance for fetching the typedview</returns>
		/// <remarks>Output parameters are not set after query is executed</remarks>
		public static IRetrievalQuery GetQueryForTestPeopleResponseTypedView()
		{
			IRetrievalQuery query = GetSelectTestPeopleCallAsQuery();
			query.ResultsetNumber = 1;
			return query;
		}
		
		/// <summary>Fetches the typed view 'TestPeopleResponse' using a stored procedure call. </summary>
		/// <param name="typedViewToFetch">The typed view to fetch. Should be a 'TestPeopleResponseTypedView' instance</param>
		/// <returns> The specified TypedView to fetch</returns>
		public static TTypedView FetchTestPeopleResponseTypedView<TTypedView>(TTypedView typedViewToFetch)
			where TTypedView: ITypedView2 
		{
			using(DataAccessAdapter adapter = new DataAccessAdapter())
			{
				FetchTestPeopleResponseTypedView(adapter, typedViewToFetch);
			}
			return typedViewToFetch;
		}

		/// <summary>Fetches the typed view 'TestPeopleResponse' using a stored procedure call. </summary>
		/// <param name="adapter">The adapter.</param>
		/// <param name="typedViewToFetch">The typed view to fetch. Should be a 'TestPeopleResponseTypedView' instance</param>
		public static void FetchTestPeopleResponseTypedView(IDataAccessAdapter adapter, ITypedView2 typedViewToFetch)
		{
			StoredProcedureCall call = CreateSelectTestPeopleCall(adapter);
			IRetrievalQuery query = call.ToRetrievalQuery();
			query.ResultsetNumber = 1;
			adapter.FetchTypedView(typedViewToFetch, query);
		}


		/// <summary>Calls stored procedure 'Select_TestPeople'.<br/><br/></summary>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SelectTestPeople()
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return SelectTestPeople(dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'Select_TestPeople'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SelectTestPeople(IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSelectTestPeopleCall(dataAccessProvider))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'Select_TestPeople'.</summary>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSelectTestPeopleCallAsQuery()
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return CreateSelectTestPeopleCall(dataAccessProvider).ToRetrievalQuery();
			}
		}

		/// <summary>Calls stored procedure 'Select_TestPeopleByID'.<br/><br/></summary>
		/// <param name="prmNumber">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SelectTestPeopleById(System.Int32 prmNumber)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return SelectTestPeopleById(prmNumber, dataAccessProvider);
			}
		}

		/// <summary>Calls stored procedure 'Select_TestPeopleByID'.<br/><br/></summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter. </param>
		/// <returns>Filled DataTable with resultset(s) of stored procedure</returns>
		public static DataTable SelectTestPeopleById(System.Int32 prmNumber, IDataAccessCore dataAccessProvider)
		{
			using(StoredProcedureCall call = CreateSelectTestPeopleByIdCall(dataAccessProvider, prmNumber))
			{
				DataTable toReturn = call.FillDataTable();
				return toReturn;
			}
		}

		/// <summary>Creates an IRetrievalQuery object for a call to the procedure 'Select_TestPeopleByID'.</summary>
		/// <param name="prmNumber">Input parameter of stored procedure</param>
		/// <returns>IRetrievalQuery object which is ready to use for datafetching</returns>
		public static IRetrievalQuery GetSelectTestPeopleByIdCallAsQuery(System.Int32 prmNumber)
		{
			using(DataAccessAdapter dataAccessProvider = new DataAccessAdapter())
			{
				return CreateSelectTestPeopleByIdCall(dataAccessProvider, prmNumber).ToRetrievalQuery();
			}
		}

		/// <summary>Creates the call object for the call 'SelectTestPeople' to stored procedure 'Select_TestPeople'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSelectTestPeopleCall(IDataAccessCore dataAccessProvider)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[Select_TestPeople]", "SelectTestPeople");
		}

		/// <summary>Creates the call object for the call 'SelectTestPeopleById' to stored procedure 'Select_TestPeopleByID'.</summary>
		/// <param name="dataAccessProvider">The data access provider.</param>
		/// <param name="prmNumber">Input parameter</param>
		/// <returns>Ready to use StoredProcedureCall object</returns>
		private static StoredProcedureCall CreateSelectTestPeopleByIdCall(IDataAccessCore dataAccessProvider, System.Int32 prmNumber)
		{
			return new StoredProcedureCall(dataAccessProvider, @"[PatrickTest].[dbo].[Select_TestPeopleByID]", "SelectTestPeopleById")
							.AddParameter("@prm_Number", "Int", 0, ParameterDirection.Input, true, 10, 0, prmNumber);
		}


		#region Included Code

		#endregion
	}
}
