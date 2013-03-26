﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Entity class which represents the entity 'RepoAukcija'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)]	
	public partial class RepoAukcijaEntity : CommonEntityBase
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

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new RepoAukcijaEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<RepoAukcijaEntity> FetchRepoAukcijaCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(RepoAukcijaFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<RepoAukcijaEntity> toReturn = new EntityCollection<RepoAukcijaEntity>(new RepoAukcijaEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<RepoAukcijaEntity> FetchRepoAukcijaCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<RepoAukcijaEntity> toReturn = new EntityCollection<RepoAukcijaEntity>(new RepoAukcijaEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static RepoAukcijaEntity FetchRepoAukcija(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long RepoAukcijaId)
		{
			RepoAukcijaEntity _RepoAukcijaEntity = new RepoAukcijaEntity(RepoAukcijaId);
			adapter.FetchEntity(_RepoAukcijaEntity, prefetchPath);
			return _RepoAukcijaEntity;
		}

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static RepoAukcijaEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public RepoAukcijaEntity():base("RepoAukcijaEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public RepoAukcijaEntity(IEntityFields2 fields):base("RepoAukcijaEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this RepoAukcijaEntity</param>
		public RepoAukcijaEntity(IValidator validator):base("RepoAukcijaEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="repoAukcijaId">PK value for RepoAukcija which data should be fetched into this RepoAukcija object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RepoAukcijaEntity(System.Int64 repoAukcijaId):base("RepoAukcijaEntity")
		{
			InitClassEmpty(null, null);
			this.RepoAukcijaId = repoAukcijaId;
		}

		/// <summary> CTor</summary>
		/// <param name="repoAukcijaId">PK value for RepoAukcija which data should be fetched into this RepoAukcija object</param>
		/// <param name="validator">The custom validator object for this RepoAukcijaEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public RepoAukcijaEntity(System.Int64 repoAukcijaId, IValidator validator):base("RepoAukcijaEntity")
		{
			InitClassEmpty(validator, null);
			this.RepoAukcijaId = repoAukcijaId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected RepoAukcijaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
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
			return new RepoAukcijaRelations().GetAllRelations();
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(RepoAukcijaEntityFactory));
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
			_fieldsCustomProperties.Add("BrojAukcije", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("ConcurrencyGuid", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DatumAukcije", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("DatumReotkupa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("FiksnaRepoStopa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("GranicnaRepoStopa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("KoeficijentRaspodjele", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NajnizaRepoStopa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("NajvisaRepoStopa", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("OdbijenePonudeUkupno", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PostoPrihvacenihPoGranicnojStopi", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PrihvacenePonudeUkupno", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PristiglePonudeUkupno", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RepoAukcijaId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("VaganaRepoStopa", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this RepoAukcijaEntity</param>
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
		public  static RepoAukcijaRelations Relations
		{
			get	{ return new RepoAukcijaRelations(); }
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

		/// <summary> The BrojAukcije property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."BrojAukcije"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 20<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual System.String BrojAukcije
		{
			get { return (System.String)GetValue((int)RepoAukcijaFieldIndex.BrojAukcije, true); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.BrojAukcije, value); }
		}

		/// <summary> The ConcurrencyGuid property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)RepoAukcijaFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The DatumAukcije property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."DatumAukcije"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.DateTime DatumAukcije
		{
			get { return (System.DateTime)GetValue((int)RepoAukcijaFieldIndex.DatumAukcije, true); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.DatumAukcije, value); }
		}

		/// <summary> The DatumReotkupa property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."DatumReotkupa"<br/>
		/// Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.DateTime> DatumReotkupa
		{
			get { return (Nullable<System.DateTime>)GetValue((int)RepoAukcijaFieldIndex.DatumReotkupa, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.DatumReotkupa, value); }
		}

		/// <summary> The FiksnaRepoStopa property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."FiksnaRepoStopa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> FiksnaRepoStopa
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.FiksnaRepoStopa, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.FiksnaRepoStopa, value); }
		}

		/// <summary> The GranicnaRepoStopa property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."GranicnaRepoStopa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> GranicnaRepoStopa
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.GranicnaRepoStopa, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.GranicnaRepoStopa, value); }
		}

		/// <summary> The KoeficijentRaspodjele property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."KoeficijentRaspodjele"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> KoeficijentRaspodjele
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.KoeficijentRaspodjele, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.KoeficijentRaspodjele, value); }
		}

		/// <summary> The NajnizaRepoStopa property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."NajnizaRepoStopa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> NajnizaRepoStopa
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.NajnizaRepoStopa, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.NajnizaRepoStopa, value); }
		}

		/// <summary> The NajvisaRepoStopa property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."NajvisaRepoStopa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> NajvisaRepoStopa
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.NajvisaRepoStopa, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.NajvisaRepoStopa, value); }
		}

		/// <summary> The OdbijenePonudeUkupno property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."OdbijenePonudeUkupno"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> OdbijenePonudeUkupno
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.OdbijenePonudeUkupno, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.OdbijenePonudeUkupno, value); }
		}

		/// <summary> The PostoPrihvacenihPoGranicnojStopi property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."PostoPrihvacenihPoGranicnojStopi"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> PostoPrihvacenihPoGranicnojStopi
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.PostoPrihvacenihPoGranicnojStopi, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.PostoPrihvacenihPoGranicnojStopi, value); }
		}

		/// <summary> The PrihvacenePonudeUkupno property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."PrihvacenePonudeUkupno"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> PrihvacenePonudeUkupno
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.PrihvacenePonudeUkupno, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.PrihvacenePonudeUkupno, value); }
		}

		/// <summary> The PristiglePonudeUkupno property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."PristiglePonudeUkupno"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> PristiglePonudeUkupno
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.PristiglePonudeUkupno, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.PristiglePonudeUkupno, value); }
		}

		/// <summary> The RepoAukcijaId property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."RepoAukcijaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]		
		public virtual System.Int64 RepoAukcijaId
		{
			get { return (System.Int64)GetValue((int)RepoAukcijaFieldIndex.RepoAukcijaId, true); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.RepoAukcijaId, value); }
		}

		/// <summary> The VaganaRepoStopa property of the Entity RepoAukcija<br/><br/></summary>
		/// <remarks>Mapped on  table field: "RepoAukcija"."VaganaRepoStopa"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 5, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		[JsonProperty]		
		public virtual Nullable<System.Decimal> VaganaRepoStopa
		{
			get { return (Nullable<System.Decimal>)GetValue((int)RepoAukcijaFieldIndex.VaganaRepoStopa, false); }
			set	{ SetValue((int)RepoAukcijaFieldIndex.VaganaRepoStopa, value); }
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
			get { return (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.RepoAukcijaEntity; }
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