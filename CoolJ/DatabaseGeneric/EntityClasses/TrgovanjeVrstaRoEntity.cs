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
	/// <summary>Entity class which represents the entity 'TrgovanjeVrstaRo'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)]	
	public partial class TrgovanjeVrstaRoEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private EntityCollection<TrgovanjeStavkaEntity> _trgovanjeStavkaCollection;
		private EntityCollection<TrgovanjeStavkaHnbEntity> _trgovanjeStavkaHnbCollection;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name TrgovanjeStavkaCollection</summary>
			public static readonly string TrgovanjeStavkaCollection = "TrgovanjeStavkaCollection";
			/// <summary>Member name TrgovanjeStavkaHnbCollection</summary>
			public static readonly string TrgovanjeStavkaHnbCollection = "TrgovanjeStavkaHnbCollection";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new TrgovanjeVrstaRoEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<TrgovanjeVrstaRoEntity> FetchTrgovanjeVrstaRoCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(TrgovanjeVrstaRoFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<TrgovanjeVrstaRoEntity> toReturn = new EntityCollection<TrgovanjeVrstaRoEntity>(new TrgovanjeVrstaRoEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<TrgovanjeVrstaRoEntity> FetchTrgovanjeVrstaRoCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<TrgovanjeVrstaRoEntity> toReturn = new EntityCollection<TrgovanjeVrstaRoEntity>(new TrgovanjeVrstaRoEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static TrgovanjeVrstaRoEntity FetchTrgovanjeVrstaRo(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long TrgovanjeVrstaRoId)
		{
			TrgovanjeVrstaRoEntity _TrgovanjeVrstaRoEntity = new TrgovanjeVrstaRoEntity(TrgovanjeVrstaRoId);
			adapter.FetchEntity(_TrgovanjeVrstaRoEntity, prefetchPath);
			return _TrgovanjeVrstaRoEntity;
		}

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TrgovanjeVrstaRoEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public TrgovanjeVrstaRoEntity():base("TrgovanjeVrstaRoEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TrgovanjeVrstaRoEntity(IEntityFields2 fields):base("TrgovanjeVrstaRoEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TrgovanjeVrstaRoEntity</param>
		public TrgovanjeVrstaRoEntity(IValidator validator):base("TrgovanjeVrstaRoEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="trgovanjeVrstaId">PK value for TrgovanjeVrstaRo which data should be fetched into this TrgovanjeVrstaRo object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TrgovanjeVrstaRoEntity(System.Int64 trgovanjeVrstaId):base("TrgovanjeVrstaRoEntity")
		{
			InitClassEmpty(null, null);
			this.TrgovanjeVrstaId = trgovanjeVrstaId;
		}

		/// <summary> CTor</summary>
		/// <param name="trgovanjeVrstaId">PK value for TrgovanjeVrstaRo which data should be fetched into this TrgovanjeVrstaRo object</param>
		/// <param name="validator">The custom validator object for this TrgovanjeVrstaRoEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TrgovanjeVrstaRoEntity(System.Int64 trgovanjeVrstaId, IValidator validator):base("TrgovanjeVrstaRoEntity")
		{
			InitClassEmpty(validator, null);
			this.TrgovanjeVrstaId = trgovanjeVrstaId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TrgovanjeVrstaRoEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_trgovanjeStavkaCollection = (EntityCollection<TrgovanjeStavkaEntity>)info.GetValue("_trgovanjeStavkaCollection", typeof(EntityCollection<TrgovanjeStavkaEntity>));
				_trgovanjeStavkaHnbCollection = (EntityCollection<TrgovanjeStavkaHnbEntity>)info.GetValue("_trgovanjeStavkaHnbCollection", typeof(EntityCollection<TrgovanjeStavkaHnbEntity>));
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
				case "TrgovanjeStavkaCollection":
					this.TrgovanjeStavkaCollection.Add((TrgovanjeStavkaEntity)entity);
					break;
				case "TrgovanjeStavkaHnbCollection":
					this.TrgovanjeStavkaHnbCollection.Add((TrgovanjeStavkaHnbEntity)entity);
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
				case "TrgovanjeStavkaCollection":
					toReturn.Add(Relations.TrgovanjeStavkaEntityUsingTrgovanjeVrstaId);
					break;
				case "TrgovanjeStavkaHnbCollection":
					toReturn.Add(Relations.TrgovanjeStavkaHnbEntityUsingTrgovanjeVrstaId);
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
				case "TrgovanjeStavkaCollection":
					this.TrgovanjeStavkaCollection.Add((TrgovanjeStavkaEntity)relatedEntity);
					break;
				case "TrgovanjeStavkaHnbCollection":
					this.TrgovanjeStavkaHnbCollection.Add((TrgovanjeStavkaHnbEntity)relatedEntity);
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
				case "TrgovanjeStavkaCollection":
					this.PerformRelatedEntityRemoval(this.TrgovanjeStavkaCollection, relatedEntity, signalRelatedEntityManyToOne);
					break;
				case "TrgovanjeStavkaHnbCollection":
					this.PerformRelatedEntityRemoval(this.TrgovanjeStavkaHnbCollection, relatedEntity, signalRelatedEntityManyToOne);
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
			return toReturn;
		}
		
		/// <summary>Gets a list of all entity collections stored as member variables in this entity. Only 1:n related collections are returned.</summary>
		/// <returns>Collection with 0 or more IEntityCollection2 objects, referenced by this entity</returns>
		protected override List<IEntityCollection2> GetMemberEntityCollections()
		{
			List<IEntityCollection2> toReturn = new List<IEntityCollection2>();
			toReturn.Add(this.TrgovanjeStavkaCollection);
			toReturn.Add(this.TrgovanjeStavkaHnbCollection);
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
				info.AddValue("_trgovanjeStavkaCollection", ((_trgovanjeStavkaCollection!=null) && (_trgovanjeStavkaCollection.Count>0) && !this.MarkedForDeletion)?_trgovanjeStavkaCollection:null);
				info.AddValue("_trgovanjeStavkaHnbCollection", ((_trgovanjeStavkaHnbCollection!=null) && (_trgovanjeStavkaHnbCollection.Count>0) && !this.MarkedForDeletion)?_trgovanjeStavkaHnbCollection:null);
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new TrgovanjeVrstaRoRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'TrgovanjeStavka' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTrgovanjeStavkaCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TrgovanjeStavkaFields.TrgovanjeVrstaId, null, ComparisonOperator.Equal, this.TrgovanjeVrstaId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entities of type 'TrgovanjeStavkaHnb' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTrgovanjeStavkaHnbCollection()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TrgovanjeStavkaHnbFields.TrgovanjeVrstaId, null, ComparisonOperator.Equal, this.TrgovanjeVrstaId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeVrstaRoEntityFactory));
		}
#if !CF
		/// <summary>Adds the member collections to the collections queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void AddToMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue) 
		{
			base.AddToMemberEntityCollectionsQueue(collectionsQueue);
			collectionsQueue.Enqueue(this._trgovanjeStavkaCollection);
			collectionsQueue.Enqueue(this._trgovanjeStavkaHnbCollection);
		}
		
		/// <summary>Gets the member collections queue from the queue (base first)</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		protected override void GetFromMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue)
		{
			base.GetFromMemberEntityCollectionsQueue(collectionsQueue);
			this._trgovanjeStavkaCollection = (EntityCollection<TrgovanjeStavkaEntity>) collectionsQueue.Dequeue();
			this._trgovanjeStavkaHnbCollection = (EntityCollection<TrgovanjeStavkaHnbEntity>) collectionsQueue.Dequeue();

		}
		
		/// <summary>Determines whether the entity has populated member collections</summary>
		/// <returns>true if the entity has populated member collections.</returns>
		protected override bool HasPopulatedMemberEntityCollections()
		{
			bool toReturn = false;
			toReturn |=(this._trgovanjeStavkaCollection != null);
			toReturn |=(this._trgovanjeStavkaHnbCollection != null);
			return toReturn ? true : base.HasPopulatedMemberEntityCollections();
		}
		
		/// <summary>Creates the member entity collections queue.</summary>
		/// <param name="collectionsQueue">The collections queue.</param>
		/// <param name="requiredQueue">The required queue.</param>
		protected override void CreateMemberEntityCollectionsQueue(Queue<IEntityCollection2> collectionsQueue, Queue<bool> requiredQueue) 
		{
			base.CreateMemberEntityCollectionsQueue(collectionsQueue, requiredQueue);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TrgovanjeStavkaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeStavkaEntityFactory))) : null);
			collectionsQueue.Enqueue(requiredQueue.Dequeue() ? new EntityCollection<TrgovanjeStavkaHnbEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeStavkaHnbEntityFactory))) : null);
		}
#endif
		/// <summary>Gets all related data objects, stored by name. The name is the field name mapped onto the relation for that particular data element.</summary>
		/// <returns>Dictionary with per name the related referenced data element, which can be an entity collection or an entity or null</returns>
		protected override Dictionary<string, object> GetRelatedData()
		{
			Dictionary<string, object> toReturn = new Dictionary<string, object>();
			toReturn.Add("TrgovanjeStavkaCollection", _trgovanjeStavkaCollection);
			toReturn.Add("TrgovanjeStavkaHnbCollection", _trgovanjeStavkaHnbCollection);
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
			_fieldsCustomProperties.Add("Code", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Name", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("SifraSlog", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TrgovanjeVrstaId", fieldHashtable);
		}
		#endregion

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this TrgovanjeVrstaRoEntity</param>
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
		public  static TrgovanjeVrstaRoRelations Relations
		{
			get	{ return new TrgovanjeVrstaRoRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TrgovanjeStavka' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTrgovanjeStavkaCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<TrgovanjeStavkaEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeStavkaEntityFactory))), (IEntityRelation)GetRelationsForField("TrgovanjeStavkaCollection")[0], (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeVrstaRoEntity, (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeStavkaEntity, 0, null, null, null, null, "TrgovanjeStavkaCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TrgovanjeStavkaHnb' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTrgovanjeStavkaHnbCollection
		{
			get	{ return new PrefetchPathElement2( new EntityCollection<TrgovanjeStavkaHnbEntity>(EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeStavkaHnbEntityFactory))), (IEntityRelation)GetRelationsForField("TrgovanjeStavkaHnbCollection")[0], (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeVrstaRoEntity, (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeStavkaHnbEntity, 0, null, null, null, null, "TrgovanjeStavkaHnbCollection", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany);	}
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

		/// <summary> The Code property of the Entity TrgovanjeVrstaRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeVrstaRo"."Code"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String Code
		{
			get { return (System.String)GetValue((int)TrgovanjeVrstaRoFieldIndex.Code, true); }
			set	{ SetValue((int)TrgovanjeVrstaRoFieldIndex.Code, value); }
		}

		/// <summary> The Name property of the Entity TrgovanjeVrstaRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeVrstaRo"."Name"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String Name
		{
			get { return (System.String)GetValue((int)TrgovanjeVrstaRoFieldIndex.Name, true); }
			set	{ SetValue((int)TrgovanjeVrstaRoFieldIndex.Name, value); }
		}

		/// <summary> The SifraSlog property of the Entity TrgovanjeVrstaRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeVrstaRo"."SifraSlog"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String SifraSlog
		{
			get { return (System.String)GetValue((int)TrgovanjeVrstaRoFieldIndex.SifraSlog, true); }
			set	{ SetValue((int)TrgovanjeVrstaRoFieldIndex.SifraSlog, value); }
		}

		/// <summary> The TrgovanjeVrstaId property of the Entity TrgovanjeVrstaRo<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeVrstaRo"."TrgovanjeVrstaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		[JsonProperty]		
		public virtual System.Int64 TrgovanjeVrstaId
		{
			get { return (System.Int64)GetValue((int)TrgovanjeVrstaRoFieldIndex.TrgovanjeVrstaId, true); }
			set	{ SetValue((int)TrgovanjeVrstaRoFieldIndex.TrgovanjeVrstaId, value); }
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TrgovanjeStavkaEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TrgovanjeStavkaEntity))]
		public virtual EntityCollection<TrgovanjeStavkaEntity> TrgovanjeStavkaCollection
		{
			get { return GetOrCreateEntityCollection<TrgovanjeStavkaEntity, TrgovanjeStavkaEntityFactory>("TrgovanjeVrsta", true, false, ref _trgovanjeStavkaCollection);	}
		}

		/// <summary> Gets the EntityCollection with the related entities of type 'TrgovanjeStavkaHnbEntity' which are related to this entity via a relation of type '1:n'. If the EntityCollection hasn't been fetched yet, the collection returned will be empty.<br/><br/></summary>
		[TypeContainedAttribute(typeof(TrgovanjeStavkaHnbEntity))]
		public virtual EntityCollection<TrgovanjeStavkaHnbEntity> TrgovanjeStavkaHnbCollection
		{
			get { return GetOrCreateEntityCollection<TrgovanjeStavkaHnbEntity, TrgovanjeStavkaHnbEntityFactory>("TrgovanjeVrsta", true, false, ref _trgovanjeStavkaHnbCollection);	}
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
			get { return (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeVrstaRoEntity; }
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
