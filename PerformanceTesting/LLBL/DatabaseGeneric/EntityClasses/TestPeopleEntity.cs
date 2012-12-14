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
using System.ComponentModel;
using System.Collections.Generic;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Xml.Serialization;
using LLBL.DAL;
using LLBL.DAL.HelperClasses;
using LLBL.DAL.FactoryClasses;
using LLBL.DAL.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBL.DAL.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Entity class which represents the entity 'TestPeople'.<br/><br/></summary>
	[Serializable]
	public partial class TestPeopleEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
		}
		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TestPeopleEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public TestPeopleEntity():base("TestPeopleEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TestPeopleEntity(IEntityFields2 fields):base("TestPeopleEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TestPeopleEntity</param>
		public TestPeopleEntity(IValidator validator):base("TestPeopleEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="number">PK value for TestPeople which data should be fetched into this TestPeople object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TestPeopleEntity(System.Int32 number):base("TestPeopleEntity")
		{
			InitClassEmpty(null, null);
			this.Number = number;
		}

		/// <summary> CTor</summary>
		/// <param name="number">PK value for TestPeople which data should be fetched into this TestPeople object</param>
		/// <param name="validator">The custom validator object for this TestPeopleEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TestPeopleEntity(System.Int32 number, IValidator validator):base("TestPeopleEntity")
		{
			InitClassEmpty(validator, null);
			this.Number = number;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TestPeopleEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}


		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				default:
					this.OnSetRelatedEntityProperty(propertyName, entity);
					break;
			}
		}
		
		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		protected override RelationCollection GetRelationsForFieldOfType(string fieldName)
		{
			return GetRelationsForField(fieldName);
		}

		/// <summary>Gets the relation objects which represent the relation the fieldName specified is mapped on. </summary>
		/// <param name="fieldName">Name of the field mapped onto the relation of which the relation objects have to be obtained.</param>
		/// <returns>RelationCollection with relation object(s) which represent the relation the field is maped on</returns>
		internal static RelationCollection GetRelationsForField(string fieldName)
		{
			RelationCollection toReturn = new RelationCollection();
			switch(fieldName)
			{
				default:
					break;				
			}
			return toReturn;
		}
#if !CF
		/// <summary>Checks if the relation mapped by the property with the name specified is a one way / single sided relation. If the passed in name is null, it/ will return true if the entity has any single-sided relation</summary>
		/// <param name="propertyName">Name of the property which is mapped onto the relation to check, or null to check if the entity has any relation/ which is single sided</param>
		/// <returns>true if the relation is single sided / one way (so the opposite relation isn't present), false otherwise</returns>
		protected override bool CheckOneWayRelations(string propertyName)
		{
			int numberOfOneWayRelations = 0;
			switch(propertyName)
			{
				case null:
					return ((numberOfOneWayRelations > 0) || base.CheckOneWayRelations(null));
				default:
					return base.CheckOneWayRelations(propertyName);
			}
		}
#endif
		/// <summary> Sets the internal parameter related to the fieldname passed to the instance relatedEntity. </summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		protected override void SetRelatedEntity(IEntityCore relatedEntity, string fieldName)
		{
			switch(fieldName)
			{
				default:
					break;
			}
		}

		/// <summary> Unsets the internal parameter related to the fieldname passed to the instance relatedEntity. Reverses the actions taken by SetRelatedEntity() </summary>
		/// <param name="relatedEntity">Instance to unset as the related entity of type entityType</param>
		/// <param name="fieldName">Name of field mapped onto the relation which resolves in the instance relatedEntity</param>
		/// <param name="signalRelatedEntityManyToOne">if set to true it will notify the manytoone side, if applicable.</param>
		protected override void UnsetRelatedEntity(IEntityCore relatedEntity, string fieldName, bool signalRelatedEntityManyToOne)
		{
			switch(fieldName)
			{
				default:
					break;
			}
		}

		/// <summary> Gets a collection of related entities referenced by this entity which depend on this entity (this entity is the PK side of their FK fields). These entities will have to be persisted after this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependingRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary> Gets a collection of related entities referenced by this entity which this entity depends on (this entity is the FK side of their PK fields). These
		/// entities will have to be persisted before this entity during a recursive save.</summary>
		/// <returns>Collection with 0 or more IEntity2 objects, referenced by this entity</returns>
		protected override List<IEntity2> GetDependentRelatedEntities()
		{
			List<IEntity2> toReturn = new List<IEntity2>();
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			return toReturn;
		}

		/// <summary>ISerializable member. Does custom serialization so event handlers do not get serialized. Serializes members of this entity class and uses the base class' implementation to serialize the rest.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			if (SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new TestPeopleRelations().GetAllRelations();
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(TestPeopleEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			return toReturn;
		}

		/// <summary> Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitClassMembersComplete();
		}


		#region Custom Property Hashtable Setup
		/// <summary> Initializes the hashtables for the entity type and entity field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Dictionary<string, string>();
			_fieldsCustomProperties = new Dictionary<string, Dictionary<string, string>>();
			Dictionary<string, string> fieldHashtable;
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Birthday", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Ccexpires", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Ccnumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Cctype", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Cvv2", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Gender", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GivenName", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MiddleInitial", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("MothersMaiden", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NationalId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Number", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("State", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("StreetAddress", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Surname", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TelephoneNumber", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ZipCode", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this TestPeopleEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();

			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END
			

			OnInitialized();

		}

		#region Class Property Declarations
		/// <summary> The relations object holding all relations of this entity with other entity classes.</summary>
		public  static TestPeopleRelations Relations
		{
			get	{ return new TestPeopleRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}


		/// <summary> The custom properties for the type of this entity instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, string> CustomPropertiesOfType
		{
			get { return CustomProperties;}
		}

		/// <summary> The custom properties for the fields of this entity type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, Dictionary<string, string>> FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary> The custom properties for the fields of the type of this entity instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[Browsable(false), XmlIgnore]
		protected override Dictionary<string, Dictionary<string, string>> FieldsCustomPropertiesOfType
		{
			get { return FieldsCustomProperties;}
		}

		/// <summary> The Birthday property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."Birthday"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> Birthday
		{
			get { return (Nullable<System.DateTime>)GetValue((int)TestPeopleFieldIndex.Birthday, false); }
			set	{ SetValue((int)TestPeopleFieldIndex.Birthday, value); }
		}

		/// <summary> The Ccexpires property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."CCExpires"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Ccexpires
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.Ccexpires, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.Ccexpires, value); }
		}

		/// <summary> The Ccnumber property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."CCNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 18, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> Ccnumber
		{
			get { return (Nullable<System.Decimal>)GetValue((int)TestPeopleFieldIndex.Ccnumber, false); }
			set	{ SetValue((int)TestPeopleFieldIndex.Ccnumber, value); }
		}

		/// <summary> The Cctype property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."CCType"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Cctype
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.Cctype, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.Cctype, value); }
		}

		/// <summary> The City property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."City"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String City
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.City, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.City, value); }
		}

		/// <summary> The Country property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."Country"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Country
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.Country, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.Country, value); }
		}

		/// <summary> The Cvv2 property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."CVV2"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> Cvv2
		{
			get { return (Nullable<System.Int32>)GetValue((int)TestPeopleFieldIndex.Cvv2, false); }
			set	{ SetValue((int)TestPeopleFieldIndex.Cvv2, value); }
		}

		/// <summary> The EmailAddress property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."EmailAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String EmailAddress
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.EmailAddress, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.EmailAddress, value); }
		}

		/// <summary> The Gender property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."Gender"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Gender
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.Gender, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.Gender, value); }
		}

		/// <summary> The GivenName property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."GivenName"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String GivenName
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.GivenName, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.GivenName, value); }
		}

		/// <summary> The MiddleInitial property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."MiddleInitial"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MiddleInitial
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.MiddleInitial, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.MiddleInitial, value); }
		}

		/// <summary> The MothersMaiden property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."MothersMaiden"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String MothersMaiden
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.MothersMaiden, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.MothersMaiden, value); }
		}

		/// <summary> The NationalId property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."NationalID"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String NationalId
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.NationalId, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.NationalId, value); }
		}

		/// <summary> The Number property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."Number"<br/>
		/// Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 Number
		{
			get { return (System.Int32)GetValue((int)TestPeopleFieldIndex.Number, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.Number, value); }
		}

		/// <summary> The State property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."State"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String State
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.State, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.State, value); }
		}

		/// <summary> The StreetAddress property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."StreetAddress"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String StreetAddress
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.StreetAddress, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.StreetAddress, value); }
		}

		/// <summary> The Surname property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."Surname"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String Surname
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.Surname, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.Surname, value); }
		}

		/// <summary> The TelephoneNumber property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."TelephoneNumber"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String TelephoneNumber
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.TelephoneNumber, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.TelephoneNumber, value); }
		}

		/// <summary> The ZipCode property of the Entity TestPeople<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TestPeople"."ZipCode"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual System.String ZipCode
		{
			get { return (System.String)GetValue((int)TestPeopleFieldIndex.ZipCode, true); }
			set	{ SetValue((int)TestPeopleFieldIndex.ZipCode, value); }
		}
	
		/// <summary> Gets the type of the hierarchy this entity is in. </summary>
		protected override InheritanceHierarchyType LLBLGenProIsInHierarchyOfType
		{
			get { return InheritanceHierarchyType.None;}
		}
		
		/// <summary> Gets or sets a value indicating whether this entity is a subtype</summary>
		protected override bool LLBLGenProIsSubType
		{
			get { return false;}
		}
		
		/// <summary>Returns the LLBL.DAL.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)LLBL.DAL.EntityType.TestPeopleEntity; }
		}

		#endregion


		#region Custom Entity code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included code

		#endregion
	}
}
