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
using System.Data;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.Serialization;
using LLBL.DAL;
using LLBL.DAL.FactoryClasses;
using LLBL.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;


namespace LLBL.DAL.TypedViewClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	
	/// <summary>Typed datatable for the view 'TestPeopleByIdResponse'.<br/><br/></summary>
	[Serializable, System.ComponentModel.DesignerCategory("Code")]
	[ToolboxItem(true)]
	[DesignTimeVisible(true)]
	public partial class TestPeopleByIdResponseTypedView : TypedViewBase<TestPeopleByIdResponseRow>, ITypedView2
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesView
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private DataColumn _columnNumber;
		private DataColumn _columnGender;
		private DataColumn _columnGivenName;
		private DataColumn _columnMiddleInitial;
		private DataColumn _columnSurname;
		private DataColumn _columnStreetAddress;
		private DataColumn _columnCity;
		private DataColumn _columnState;
		private DataColumn _columnZipCode;
		private DataColumn _columnCountry;
		private DataColumn _columnEmailAddress;
		private DataColumn _columnTelephoneNumber;
		private DataColumn _columnMothersMaiden;
		private DataColumn _columnBirthday;
		private DataColumn _columnCctype;
		private DataColumn _columnCcnumber;
		private DataColumn _columnCvv2;
		private DataColumn _columnCcexpires;
		private DataColumn _columnNationalId;
		private IEntityFields2	_fields;
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		private static Hashtable	_customProperties;
		private static Hashtable	_fieldsCustomProperties;
		#endregion

		#region Class Constants
		/// <summary>
		/// The amount of fields in the resultset.
		/// </summary>
		private const int AmountOfFields = 19;
		#endregion

		/// <summary>Static CTor for setting up custom property hashtables.</summary>
		static TestPeopleByIdResponseTypedView()
		{
			SetupCustomPropertyHashtables();
		}

		/// <summary>CTor</summary>
		public TestPeopleByIdResponseTypedView():base("TestPeopleByIdResponse")
		{
			InitClass();
		}
#if !CF	
		/// <summary>Protected constructor for deserialization.</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected TestPeopleByIdResponseTypedView(SerializationInfo info, StreamingContext context):base(info, context)
		{
			if (SerializationHelper.Optimization == SerializationOptimization.None)
			{
				InitMembers();
			}
		}
#endif
		/// <summary>Gets the IEntityFields2 collection of fields of this typed view. </summary>
		/// <returns>Ready to use IEntityFields2 collection object.</returns>
		public virtual IEntityFields2 GetFieldsInfo()
		{
			return _fields;
		}

		/// <summary>Creates a new typed row during the build of the datatable during a Fill session by a dataadapter.</summary>
		/// <param name="rowBuilder">supplied row builder to pass to the typed row</param>
		/// <returns>the new typed datarow</returns>
		protected override DataRow NewRowFromBuilder(DataRowBuilder rowBuilder) 
		{
			return new TestPeopleByIdResponseRow(rowBuilder);
		}

		/// <summary>Initializes the hashtables for the typed view type and typed view field custom properties. </summary>
		private static void SetupCustomPropertyHashtables()
		{
			_customProperties = new Hashtable();
			_fieldsCustomProperties = new Hashtable();
			Hashtable fieldHashtable;
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Number", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Gender", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("GivenName", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MiddleInitial", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Surname", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("StreetAddress", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("City", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("State", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("ZipCode", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Country", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("EmailAddress", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("TelephoneNumber", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("MothersMaiden", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Birthday", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Cctype", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Ccnumber", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Cvv2", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("Ccexpires", fieldHashtable);
			fieldHashtable = new Hashtable();
			_fieldsCustomProperties.Add("NationalId", fieldHashtable);
		}

		/// <summary>
		/// Initialize the datastructures.
		/// </summary>
		protected override void InitClass()
		{
			TableName = "TestPeopleByIdResponse";		
			_columnNumber = GeneralUtils.CreateTypedDataTableColumn("Number", @"Number", typeof(System.Int32), this.Columns);
			_columnGender = GeneralUtils.CreateTypedDataTableColumn("Gender", @"Gender", typeof(System.String), this.Columns);
			_columnGivenName = GeneralUtils.CreateTypedDataTableColumn("GivenName", @"GivenName", typeof(System.String), this.Columns);
			_columnMiddleInitial = GeneralUtils.CreateTypedDataTableColumn("MiddleInitial", @"MiddleInitial", typeof(System.String), this.Columns);
			_columnSurname = GeneralUtils.CreateTypedDataTableColumn("Surname", @"Surname", typeof(System.String), this.Columns);
			_columnStreetAddress = GeneralUtils.CreateTypedDataTableColumn("StreetAddress", @"StreetAddress", typeof(System.String), this.Columns);
			_columnCity = GeneralUtils.CreateTypedDataTableColumn("City", @"City", typeof(System.String), this.Columns);
			_columnState = GeneralUtils.CreateTypedDataTableColumn("State", @"State", typeof(System.String), this.Columns);
			_columnZipCode = GeneralUtils.CreateTypedDataTableColumn("ZipCode", @"ZipCode", typeof(System.String), this.Columns);
			_columnCountry = GeneralUtils.CreateTypedDataTableColumn("Country", @"Country", typeof(System.String), this.Columns);
			_columnEmailAddress = GeneralUtils.CreateTypedDataTableColumn("EmailAddress", @"EmailAddress", typeof(System.String), this.Columns);
			_columnTelephoneNumber = GeneralUtils.CreateTypedDataTableColumn("TelephoneNumber", @"TelephoneNumber", typeof(System.String), this.Columns);
			_columnMothersMaiden = GeneralUtils.CreateTypedDataTableColumn("MothersMaiden", @"MothersMaiden", typeof(System.String), this.Columns);
			_columnBirthday = GeneralUtils.CreateTypedDataTableColumn("Birthday", @"Birthday", typeof(System.DateTime), this.Columns);
			_columnCctype = GeneralUtils.CreateTypedDataTableColumn("Cctype", @"Cctype", typeof(System.String), this.Columns);
			_columnCcnumber = GeneralUtils.CreateTypedDataTableColumn("Ccnumber", @"Ccnumber", typeof(System.Decimal), this.Columns);
			_columnCvv2 = GeneralUtils.CreateTypedDataTableColumn("Cvv2", @"Cvv2", typeof(System.Int32), this.Columns);
			_columnCcexpires = GeneralUtils.CreateTypedDataTableColumn("Ccexpires", @"Ccexpires", typeof(System.String), this.Columns);
			_columnNationalId = GeneralUtils.CreateTypedDataTableColumn("NationalId", @"NationalId", typeof(System.String), this.Columns);
			_fields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.TestPeopleByIdResponseTypedView);
			
			// __LLBLGENPRO_USER_CODE_REGION_START AdditionalFields
			// be sure to call _fields.Expand(number of new fields) first. 
			// __LLBLGENPRO_USER_CODE_REGION_END
			
			OnInitialized();
		}

		/// <summary>Initializes the members, after a clone action.</summary>
		private void InitMembers()
		{
			_columnNumber = this.Columns["Number"];
			_columnGender = this.Columns["Gender"];
			_columnGivenName = this.Columns["GivenName"];
			_columnMiddleInitial = this.Columns["MiddleInitial"];
			_columnSurname = this.Columns["Surname"];
			_columnStreetAddress = this.Columns["StreetAddress"];
			_columnCity = this.Columns["City"];
			_columnState = this.Columns["State"];
			_columnZipCode = this.Columns["ZipCode"];
			_columnCountry = this.Columns["Country"];
			_columnEmailAddress = this.Columns["EmailAddress"];
			_columnTelephoneNumber = this.Columns["TelephoneNumber"];
			_columnMothersMaiden = this.Columns["MothersMaiden"];
			_columnBirthday = this.Columns["Birthday"];
			_columnCctype = this.Columns["Cctype"];
			_columnCcnumber = this.Columns["Ccnumber"];
			_columnCvv2 = this.Columns["Cvv2"];
			_columnCcexpires = this.Columns["Ccexpires"];
			_columnNationalId = this.Columns["NationalId"];
			_fields = EntityFieldsFactory.CreateTypedViewEntityFieldsObject(TypedViewType.TestPeopleByIdResponseTypedView);
			// __LLBLGENPRO_USER_CODE_REGION_START InitMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			
		}

		/// <summary>Clones this instance.</summary>
		/// <returns>A clone of this instance</returns>
		public override DataTable Clone() 
		{
			TestPeopleByIdResponseTypedView cloneToReturn = ((TestPeopleByIdResponseTypedView)(base.Clone()));
			cloneToReturn.InitMembers();
			return cloneToReturn;
		}
#if !CF			
		/// <summary>Creates a new instance of the DataTable class.</summary>
		/// <returns>a new instance of a datatable with this schema.</returns>
		protected override DataTable CreateInstance() 
		{
			return new TestPeopleByIdResponseTypedView();
		}
#endif

		#region Class Property Declarations
		/// <summary>The custom properties for this TypedView type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary>The custom properties for the type of this TypedView instance.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable CustomPropertiesOfType
		{
			get { return TestPeopleByIdResponseTypedView.CustomProperties;}
		}

		/// <summary>The custom properties for the fields of this TypedView type. The returned Hashtable contains per fieldname a hashtable of name-value pairs. </summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public static Hashtable FieldsCustomProperties
		{
			get { return _fieldsCustomProperties;}
		}

		/// <summary>The custom properties for the fields of the type of this TypedView instance. The returned Hashtable contains per fieldname a hashtable of name-value pairs.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		[System.ComponentModel.Browsable(false)]
		public virtual Hashtable FieldsCustomPropertiesOfType
		{
			get { return TestPeopleByIdResponseTypedView.FieldsCustomProperties;}
		}

		/// <summary>Returns the column object belonging to the TypedView field Number</summary>
		internal DataColumn NumberColumn 
		{
			get { return _columnNumber; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Gender</summary>
		internal DataColumn GenderColumn 
		{
			get { return _columnGender; }
		}

		/// <summary>Returns the column object belonging to the TypedView field GivenName</summary>
		internal DataColumn GivenNameColumn 
		{
			get { return _columnGivenName; }
		}

		/// <summary>Returns the column object belonging to the TypedView field MiddleInitial</summary>
		internal DataColumn MiddleInitialColumn 
		{
			get { return _columnMiddleInitial; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Surname</summary>
		internal DataColumn SurnameColumn 
		{
			get { return _columnSurname; }
		}

		/// <summary>Returns the column object belonging to the TypedView field StreetAddress</summary>
		internal DataColumn StreetAddressColumn 
		{
			get { return _columnStreetAddress; }
		}

		/// <summary>Returns the column object belonging to the TypedView field City</summary>
		internal DataColumn CityColumn 
		{
			get { return _columnCity; }
		}

		/// <summary>Returns the column object belonging to the TypedView field State</summary>
		internal DataColumn StateColumn 
		{
			get { return _columnState; }
		}

		/// <summary>Returns the column object belonging to the TypedView field ZipCode</summary>
		internal DataColumn ZipCodeColumn 
		{
			get { return _columnZipCode; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Country</summary>
		internal DataColumn CountryColumn 
		{
			get { return _columnCountry; }
		}

		/// <summary>Returns the column object belonging to the TypedView field EmailAddress</summary>
		internal DataColumn EmailAddressColumn 
		{
			get { return _columnEmailAddress; }
		}

		/// <summary>Returns the column object belonging to the TypedView field TelephoneNumber</summary>
		internal DataColumn TelephoneNumberColumn 
		{
			get { return _columnTelephoneNumber; }
		}

		/// <summary>Returns the column object belonging to the TypedView field MothersMaiden</summary>
		internal DataColumn MothersMaidenColumn 
		{
			get { return _columnMothersMaiden; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Birthday</summary>
		internal DataColumn BirthdayColumn 
		{
			get { return _columnBirthday; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Cctype</summary>
		internal DataColumn CctypeColumn 
		{
			get { return _columnCctype; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Ccnumber</summary>
		internal DataColumn CcnumberColumn 
		{
			get { return _columnCcnumber; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Cvv2</summary>
		internal DataColumn Cvv2Column 
		{
			get { return _columnCvv2; }
		}

		/// <summary>Returns the column object belonging to the TypedView field Ccexpires</summary>
		internal DataColumn CcexpiresColumn 
		{
			get { return _columnCcexpires; }
		}

		/// <summary>Returns the column object belonging to the TypedView field NationalId</summary>
		internal DataColumn NationalIdColumn 
		{
			get { return _columnNationalId; }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalColumnProperties
		// __LLBLGENPRO_USER_CODE_REGION_END
		
 		#endregion

		#region Custom TypedView code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion

		#region Included Code

		#endregion
	}

	/// <summary>Typed datarow for the typed datatable TestPeopleByIdResponse</summary>
	public partial class TestPeopleByIdResponseRow : DataRow
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfacesRow
		// __LLBLGENPRO_USER_CODE_REGION_END
			
	{
		#region Class Member Declarations
		private TestPeopleByIdResponseTypedView	_parent;
		#endregion

		/// <summary>CTor</summary>
		/// <param name="rowBuilder">Row builder object to use when building this row</param>
		protected internal TestPeopleByIdResponseRow(DataRowBuilder rowBuilder) : base(rowBuilder) 
		{
			_parent = ((TestPeopleByIdResponseTypedView)(this.Table));
		}

		#region Class Property Declarations

		/// <summary>Gets / sets the value of the TypedView field Number<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."Number"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 Number 
		{
			get { return IsNumberNull() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.NumberColumn]; }
			set { this[_parent.NumberColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Number is NULL, false otherwise.</summary>
		public bool IsNumberNull() 
		{
			return IsNull(_parent.NumberColumn);
		}

		/// <summary>Sets the TypedView field Number to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetNumberNull() 
		{
			this[_parent.NumberColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Gender<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."Gender"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String Gender 
		{
			get { return IsGenderNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.GenderColumn]; }
			set { this[_parent.GenderColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Gender is NULL, false otherwise.</summary>
		public bool IsGenderNull() 
		{
			return IsNull(_parent.GenderColumn);
		}

		/// <summary>Sets the TypedView field Gender to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGenderNull() 
		{
			this[_parent.GenderColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field GivenName<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."GivenName"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String GivenName 
		{
			get { return IsGivenNameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.GivenNameColumn]; }
			set { this[_parent.GivenNameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field GivenName is NULL, false otherwise.</summary>
		public bool IsGivenNameNull() 
		{
			return IsNull(_parent.GivenNameColumn);
		}

		/// <summary>Sets the TypedView field GivenName to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetGivenNameNull() 
		{
			this[_parent.GivenNameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field MiddleInitial<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."MiddleInitial"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String MiddleInitial 
		{
			get { return IsMiddleInitialNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MiddleInitialColumn]; }
			set { this[_parent.MiddleInitialColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field MiddleInitial is NULL, false otherwise.</summary>
		public bool IsMiddleInitialNull() 
		{
			return IsNull(_parent.MiddleInitialColumn);
		}

		/// <summary>Sets the TypedView field MiddleInitial to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMiddleInitialNull() 
		{
			this[_parent.MiddleInitialColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Surname<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."Surname"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String Surname 
		{
			get { return IsSurnameNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.SurnameColumn]; }
			set { this[_parent.SurnameColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Surname is NULL, false otherwise.</summary>
		public bool IsSurnameNull() 
		{
			return IsNull(_parent.SurnameColumn);
		}

		/// <summary>Sets the TypedView field Surname to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetSurnameNull() 
		{
			this[_parent.SurnameColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field StreetAddress<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."StreetAddress"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String StreetAddress 
		{
			get { return IsStreetAddressNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.StreetAddressColumn]; }
			set { this[_parent.StreetAddressColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field StreetAddress is NULL, false otherwise.</summary>
		public bool IsStreetAddressNull() 
		{
			return IsNull(_parent.StreetAddressColumn);
		}

		/// <summary>Sets the TypedView field StreetAddress to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetStreetAddressNull() 
		{
			this[_parent.StreetAddressColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field City<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."City"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String City 
		{
			get { return IsCityNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CityColumn]; }
			set { this[_parent.CityColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field City is NULL, false otherwise.</summary>
		public bool IsCityNull() 
		{
			return IsNull(_parent.CityColumn);
		}

		/// <summary>Sets the TypedView field City to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCityNull() 
		{
			this[_parent.CityColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field State<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."State"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String State 
		{
			get { return IsStateNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.StateColumn]; }
			set { this[_parent.StateColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field State is NULL, false otherwise.</summary>
		public bool IsStateNull() 
		{
			return IsNull(_parent.StateColumn);
		}

		/// <summary>Sets the TypedView field State to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetStateNull() 
		{
			this[_parent.StateColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field ZipCode<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."ZipCode"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String ZipCode 
		{
			get { return IsZipCodeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.ZipCodeColumn]; }
			set { this[_parent.ZipCodeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field ZipCode is NULL, false otherwise.</summary>
		public bool IsZipCodeNull() 
		{
			return IsNull(_parent.ZipCodeColumn);
		}

		/// <summary>Sets the TypedView field ZipCode to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetZipCodeNull() 
		{
			this[_parent.ZipCodeColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Country<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."Country"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String Country 
		{
			get { return IsCountryNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CountryColumn]; }
			set { this[_parent.CountryColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Country is NULL, false otherwise.</summary>
		public bool IsCountryNull() 
		{
			return IsNull(_parent.CountryColumn);
		}

		/// <summary>Sets the TypedView field Country to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCountryNull() 
		{
			this[_parent.CountryColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field EmailAddress<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."EmailAddress"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String EmailAddress 
		{
			get { return IsEmailAddressNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.EmailAddressColumn]; }
			set { this[_parent.EmailAddressColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field EmailAddress is NULL, false otherwise.</summary>
		public bool IsEmailAddressNull() 
		{
			return IsNull(_parent.EmailAddressColumn);
		}

		/// <summary>Sets the TypedView field EmailAddress to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetEmailAddressNull() 
		{
			this[_parent.EmailAddressColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field TelephoneNumber<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."TelephoneNumber"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String TelephoneNumber 
		{
			get { return IsTelephoneNumberNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.TelephoneNumberColumn]; }
			set { this[_parent.TelephoneNumberColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field TelephoneNumber is NULL, false otherwise.</summary>
		public bool IsTelephoneNumberNull() 
		{
			return IsNull(_parent.TelephoneNumberColumn);
		}

		/// <summary>Sets the TypedView field TelephoneNumber to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetTelephoneNumberNull() 
		{
			this[_parent.TelephoneNumberColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field MothersMaiden<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."MothersMaiden"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String MothersMaiden 
		{
			get { return IsMothersMaidenNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.MothersMaidenColumn]; }
			set { this[_parent.MothersMaidenColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field MothersMaiden is NULL, false otherwise.</summary>
		public bool IsMothersMaidenNull() 
		{
			return IsNull(_parent.MothersMaidenColumn);
		}

		/// <summary>Sets the TypedView field MothersMaiden to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetMothersMaidenNull() 
		{
			this[_parent.MothersMaidenColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Birthday<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."Birthday"<br/>
		/// View field characteristics (type, precision, scale, length): DateTime, 0, 0, 0</remarks>
		public System.DateTime Birthday 
		{
			get { return IsBirthdayNull() ? (System.DateTime)TypeDefaultValue.GetDefaultValue(typeof(System.DateTime)) : (System.DateTime)this[_parent.BirthdayColumn]; }
			set { this[_parent.BirthdayColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Birthday is NULL, false otherwise.</summary>
		public bool IsBirthdayNull() 
		{
			return IsNull(_parent.BirthdayColumn);
		}

		/// <summary>Sets the TypedView field Birthday to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetBirthdayNull() 
		{
			this[_parent.BirthdayColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Cctype<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."CCType"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String Cctype 
		{
			get { return IsCctypeNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CctypeColumn]; }
			set { this[_parent.CctypeColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Cctype is NULL, false otherwise.</summary>
		public bool IsCctypeNull() 
		{
			return IsNull(_parent.CctypeColumn);
		}

		/// <summary>Sets the TypedView field Cctype to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCctypeNull() 
		{
			this[_parent.CctypeColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Ccnumber<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."CCNumber"<br/>
		/// View field characteristics (type, precision, scale, length): Decimal, 18, 0, 0</remarks>
		public System.Decimal Ccnumber 
		{
			get { return IsCcnumberNull() ? (System.Decimal)TypeDefaultValue.GetDefaultValue(typeof(System.Decimal)) : (System.Decimal)this[_parent.CcnumberColumn]; }
			set { this[_parent.CcnumberColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Ccnumber is NULL, false otherwise.</summary>
		public bool IsCcnumberNull() 
		{
			return IsNull(_parent.CcnumberColumn);
		}

		/// <summary>Sets the TypedView field Ccnumber to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCcnumberNull() 
		{
			this[_parent.CcnumberColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Cvv2<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."CVV2"<br/>
		/// View field characteristics (type, precision, scale, length): Int, 10, 0, 0</remarks>
		public System.Int32 Cvv2 
		{
			get { return IsCvv2Null() ? (System.Int32)TypeDefaultValue.GetDefaultValue(typeof(System.Int32)) : (System.Int32)this[_parent.Cvv2Column]; }
			set { this[_parent.Cvv2Column] = value; }
		}

		/// <summary>Returns true if the TypedView field Cvv2 is NULL, false otherwise.</summary>
		public bool IsCvv2Null() 
		{
			return IsNull(_parent.Cvv2Column);
		}

		/// <summary>Sets the TypedView field Cvv2 to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCvv2Null() 
		{
			this[_parent.Cvv2Column] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field Ccexpires<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."CCExpires"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String Ccexpires 
		{
			get { return IsCcexpiresNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.CcexpiresColumn]; }
			set { this[_parent.CcexpiresColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field Ccexpires is NULL, false otherwise.</summary>
		public bool IsCcexpiresNull() 
		{
			return IsNull(_parent.CcexpiresColumn);
		}

		/// <summary>Sets the TypedView field Ccexpires to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetCcexpiresNull() 
		{
			this[_parent.CcexpiresColumn] = System.Convert.DBNull;
		}

		/// <summary>Gets / sets the value of the TypedView field NationalId<br/><br/></summary>
		/// <remarks>Mapped on view field: "Resultset1"."NationalID"<br/>
		/// View field characteristics (type, precision, scale, length): NVarChar, 0, 0, 64</remarks>
		public System.String NationalId 
		{
			get { return IsNationalIdNull() ? (System.String)TypeDefaultValue.GetDefaultValue(typeof(System.String)) : (System.String)this[_parent.NationalIdColumn]; }
			set { this[_parent.NationalIdColumn] = value; }
		}

		/// <summary>Returns true if the TypedView field NationalId is NULL, false otherwise.</summary>
		public bool IsNationalIdNull() 
		{
			return IsNull(_parent.NationalIdColumn);
		}

		/// <summary>Sets the TypedView field NationalId to NULL. Not recommended; a typed list should be used as a readonly object.</summary>
    	public void SetNationalIdNull() 
		{
			this[_parent.NationalIdColumn] = System.Convert.DBNull;
		}
		#endregion
		
		#region Custom Typed View Row Code
		
		// __LLBLGENPRO_USER_CODE_REGION_START CustomTypedViewRowCode
		// __LLBLGENPRO_USER_CODE_REGION_END
		
		#endregion
		
		#region Included Row Code

		#endregion	
	}
}
