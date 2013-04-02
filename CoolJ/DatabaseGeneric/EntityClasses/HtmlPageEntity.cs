///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
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
using NinjaSoftware.TrzisteNovca.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.FactoryClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;
using Newtonsoft.Json;
using NinjaSoftware.Api.CoolJ;

namespace NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'HtmlPage'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)]	
	public partial class HtmlPageEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private SistemskaInstancaPodatakaRoEntity _sistemskaInstancaPodataka;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name SistemskaInstancaPodataka</summary>
			public static readonly string SistemskaInstancaPodataka = "SistemskaInstancaPodataka";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new HtmlPageEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<HtmlPageEntity> FetchHtmlPageCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(HtmlPageFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<HtmlPageEntity> toReturn = new EntityCollection<HtmlPageEntity>(new HtmlPageEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<HtmlPageEntity> FetchHtmlPageCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<HtmlPageEntity> toReturn = new EntityCollection<HtmlPageEntity>(new HtmlPageEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static HtmlPageEntity FetchHtmlPage(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long HtmlPageId)
		{
			HtmlPageEntity _HtmlPageEntity = new HtmlPageEntity(HtmlPageId);
			adapter.FetchEntity(_HtmlPageEntity, prefetchPath);
			return _HtmlPageEntity;
		}

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static HtmlPageEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public HtmlPageEntity():base("HtmlPageEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public HtmlPageEntity(IEntityFields2 fields):base("HtmlPageEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this HtmlPageEntity</param>
		public HtmlPageEntity(IValidator validator):base("HtmlPageEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="htmlPageId">PK value for HtmlPage which data should be fetched into this HtmlPage object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public HtmlPageEntity(System.Int64 htmlPageId):base("HtmlPageEntity")
		{
			InitClassEmpty(null, null);
			this.HtmlPageId = htmlPageId;
		}

		/// <summary> CTor</summary>
		/// <param name="htmlPageId">PK value for HtmlPage which data should be fetched into this HtmlPage object</param>
		/// <param name="validator">The custom validator object for this HtmlPageEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public HtmlPageEntity(System.Int64 htmlPageId, IValidator validator):base("HtmlPageEntity")
		{
			InitClassEmpty(validator, null);
			this.HtmlPageId = htmlPageId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected HtmlPageEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_sistemskaInstancaPodataka = (SistemskaInstancaPodatakaRoEntity)info.GetValue("_sistemskaInstancaPodataka", typeof(SistemskaInstancaPodatakaRoEntity));
				if(_sistemskaInstancaPodataka!=null)
				{
					_sistemskaInstancaPodataka.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				this.FixupDeserialization(FieldInfoProviderSingleton.GetInstance());
			}
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		
		/// <summary>Performs the desync setup when an FK field has been changed. The entity referenced based on the FK field will be dereferenced and sync info will be removed.</summary>
		/// <param name="fieldIndex">The fieldindex.</param>
		protected override void PerformDesyncSetupFKFieldChange(int fieldIndex)
		{
			switch((HtmlPageFieldIndex)fieldIndex)
			{
				case HtmlPageFieldIndex.SistemskaInstancaPodatakaId:
					DesetupSyncSistemskaInstancaPodataka(true, false);
					break;
				default:
					base.PerformDesyncSetupFKFieldChange(fieldIndex);
					break;
			}
		}

		/// <summary> Sets the related entity property to the entity specified. If the property is a collection, it will add the entity specified to that collection.</summary>
		/// <param name="propertyName">Name of the property.</param>
		/// <param name="entity">Entity to set as an related entity</param>
		/// <remarks>Used by prefetch path logic.</remarks>
		protected override void SetRelatedEntityProperty(string propertyName, IEntityCore entity)
		{
			switch(propertyName)
			{
				case "SistemskaInstancaPodataka":
					this.SistemskaInstancaPodataka = (SistemskaInstancaPodatakaRoEntity)entity;
					break;
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
				case "SistemskaInstancaPodataka":
					toReturn.Add(Relations.SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaId);
					break;
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
				case "SistemskaInstancaPodataka":
					SetupSyncSistemskaInstancaPodataka(relatedEntity);
					break;
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
				case "SistemskaInstancaPodataka":
					DesetupSyncSistemskaInstancaPodataka(false, true);
					break;
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
			if(_sistemskaInstancaPodataka!=null)
			{
				toReturn.Add(_sistemskaInstancaPodataka);
			}
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
				info.AddValue("_sistemskaInstancaPodataka", (!this.MarkedForDeletion?_sistemskaInstancaPodataka:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new HtmlPageRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'SistemskaInstancaPodatakaRo' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoSistemskaInstancaPodataka()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(SistemskaInstancaPodatakaRoFields.SistemskaInstancaPodatakaId, null, ComparisonOperator.Equal, this.SistemskaInstancaPodatakaId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(HtmlPageEntityFactory));
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
			toReturn.Add("SistemskaInstancaPodataka", _sistemskaInstancaPodataka);
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
			_fieldsCustomProperties.Add("ConcurrencyGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Html", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("HtmlPageId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SistemskaInstancaPodatakaId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _sistemskaInstancaPodataka</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncSistemskaInstancaPodataka(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _sistemskaInstancaPodataka, new PropertyChangedEventHandler( OnSistemskaInstancaPodatakaPropertyChanged ), "SistemskaInstancaPodataka", NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses.StaticHtmlPageRelations.SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaIdStatic, true, signalRelatedEntity, "HtmlPageCollection", resetFKFields, new int[] { (int)HtmlPageFieldIndex.SistemskaInstancaPodatakaId } );
			_sistemskaInstancaPodataka = null;
		}

		/// <summary> setups the sync logic for member _sistemskaInstancaPodataka</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncSistemskaInstancaPodataka(IEntityCore relatedEntity)
		{
			if(_sistemskaInstancaPodataka!=relatedEntity)
			{
				DesetupSyncSistemskaInstancaPodataka(true, true);
				_sistemskaInstancaPodataka = (SistemskaInstancaPodatakaRoEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _sistemskaInstancaPodataka, new PropertyChangedEventHandler( OnSistemskaInstancaPodatakaPropertyChanged ), "SistemskaInstancaPodataka", NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses.StaticHtmlPageRelations.SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnSistemskaInstancaPodatakaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this HtmlPageEntity</param>
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
		public  static HtmlPageRelations Relations
		{
			get	{ return new HtmlPageRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'SistemskaInstancaPodatakaRo' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathSistemskaInstancaPodataka
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(SistemskaInstancaPodatakaRoEntityFactory))),	(IEntityRelation)GetRelationsForField("SistemskaInstancaPodataka")[0], (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.HtmlPageEntity, (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.SistemskaInstancaPodatakaRoEntity, 0, null, null, null, null, "SistemskaInstancaPodataka", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ConcurrencyGuid property of the Entity HtmlPage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "HtmlPage"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)HtmlPageFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)HtmlPageFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The Html property of the Entity HtmlPage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "HtmlPage"."Html"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 2147483647<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String Html
		{
			get { return (System.String)GetValue((int)HtmlPageFieldIndex.Html, true); }
			set	{ SetValue((int)HtmlPageFieldIndex.Html, value); }
		}

		/// <summary> The HtmlPageId property of the Entity HtmlPage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "HtmlPage"."HtmlPageId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]		
		public virtual System.Int64 HtmlPageId
		{
			get { return (System.Int64)GetValue((int)HtmlPageFieldIndex.HtmlPageId, true); }
			set	{ SetValue((int)HtmlPageFieldIndex.HtmlPageId, value); }
		}

		/// <summary> The Name property of the Entity HtmlPage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "HtmlPage"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 64<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)HtmlPageFieldIndex.Name, true); }
			set	{ SetValue((int)HtmlPageFieldIndex.Name, value); }
		}

		/// <summary> The SistemskaInstancaPodatakaId property of the Entity HtmlPage<br/><br/></summary>
		/// <remarks>Mapped on  table field: "HtmlPage"."SistemskaInstancaPodatakaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Int64> SistemskaInstancaPodatakaId
		{
			get { return (Nullable<System.Int64>)GetValue((int)HtmlPageFieldIndex.SistemskaInstancaPodatakaId, false); }
			set	{ SetValue((int)HtmlPageFieldIndex.SistemskaInstancaPodatakaId, value); }
		}

		/// <summary> Gets / sets related entity of type 'SistemskaInstancaPodatakaRoEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual SistemskaInstancaPodatakaRoEntity SistemskaInstancaPodataka
		{
			get	{ return _sistemskaInstancaPodataka; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncSistemskaInstancaPodataka(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "HtmlPageCollection", "SistemskaInstancaPodataka", _sistemskaInstancaPodataka, true); 
				}
			}
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
		
		/// <summary>Returns the NinjaSoftware.TrzisteNovca.CoolJ.EntityType enum value for this entity.</summary>
		[Browsable(false), XmlIgnore]
		protected override int LLBLGenProEntityTypeValue 
		{ 
			get { return (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.HtmlPageEntity; }
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
