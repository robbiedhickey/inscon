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
using System.Collections;
using System.Collections.Generic;
using LLBL.DAL;
using LLBL.DAL.FactoryClasses;
using LLBL.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBL.DAL.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: TestPeople1. </summary>
	public partial class TestPeople1Relations
	{
		/// <summary>CTor</summary>
		public TestPeople1Relations()
		{
		}

		/// <summary>Gets all relations of the TestPeople1Entity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTestPeople1Relations
	{

		/// <summary>CTor</summary>
		static StaticTestPeople1Relations()
		{
		}
	}
}
