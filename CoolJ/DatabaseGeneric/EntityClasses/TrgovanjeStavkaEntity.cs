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
	/// <summary>Entity class which represents the entity 'TrgovanjeStavka'.<br/><br/></summary>
	[Serializable]
	[JsonObject(MemberSerialization.OptIn)]	
	public partial class TrgovanjeStavkaEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		#region Class Member Declarations
		private RokEntity _rok;
		private TrgovanjeGlavaEntity _trgovanjeGlava;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		#endregion

		#region Statics
		private static Dictionary<string, string>	_customProperties;
		private static Dictionary<string, Dictionary<string, string>>	_fieldsCustomProperties;

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Rok</summary>
			public static readonly string Rok = "Rok";
			/// <summary>Member name TrgovanjeGlava</summary>
			public static readonly string TrgovanjeGlava = "TrgovanjeGlava";
		}

        /// <summary>
		/// Returns number of entities after filterBucket is applied.
		/// If you need number of all entities send null as filterBucket.
        /// </summary>
		public static int GetNumberOfEntities(DataAccessAdapterBase adapter, 
			IRelationPredicateBucket filterBucket)
		{
			EntityCollection entityCollection = new EntityCollection(new TrgovanjeStavkaEntityFactory());
			return adapter.GetDbCount(entityCollection, filterBucket);
		}
		
		/// <summary>
        /// Efficient pageing for grid.
        /// </summary>
        /// <param name="pageNumber">Must be greater than zero.</param>
        /// <param name="sortDirection">Validne vrijednosti su 'asc' i 'desc'.</param>
        public static EntityCollection<TrgovanjeStavkaEntity> FetchTrgovanjeStavkaCollectionForPaging(DataAccessAdapterBase adapter,
			RelationPredicateBucket bucket,
			PrefetchPath2 prefetchPath,
            int pageNumber,
            int pageSize,
            string sortField,
			bool isSortAscending)
        {
			string sortDirection = isSortAscending ? "asc" : "desc";

            Type sortEntityFieldType = typeof(TrgovanjeStavkaFields);
            string sortEntityFieldTypeName = SortHelper.GetEntityFieldTypeNameForSorting(sortField, sortEntityFieldType);
            if (!string.IsNullOrWhiteSpace(sortEntityFieldTypeName))
            {
                sortEntityFieldType = Type.GetType(sortEntityFieldTypeName);
            }

            sortField = SortHelper.GetSortField(sortField);			

			SortExpression sort = SortHelper.GetSortExpression(sortField, sortDirection, sortEntityFieldType);
			
            EntityCollection<TrgovanjeStavkaEntity> toReturn = new EntityCollection<TrgovanjeStavkaEntity>(new TrgovanjeStavkaEntityFactory());
            adapter.FetchEntityCollection(toReturn, bucket, pageSize, sort, prefetchPath, pageNumber, pageSize);

            return toReturn;
        }
		
		public static EntityCollection<TrgovanjeStavkaEntity> FetchTrgovanjeStavkaCollection(DataAccessAdapterBase adapter,
			IRelationPredicateBucket filterBucket,
			PrefetchPath2 prefetchPath)
		{
			EntityCollection<TrgovanjeStavkaEntity> toReturn = new EntityCollection<TrgovanjeStavkaEntity>(new TrgovanjeStavkaEntityFactory());
			adapter.FetchEntityCollection(toReturn, filterBucket, prefetchPath);
			return toReturn;
		}
		
		public static TrgovanjeStavkaEntity FetchTrgovanjeStavka(DataAccessAdapterBase adapter, PrefetchPath2 prefetchPath, long TrgovanjeStavkaId)
		{
			TrgovanjeStavkaEntity _TrgovanjeStavkaEntity = new TrgovanjeStavkaEntity(TrgovanjeStavkaId);
			adapter.FetchEntity(_TrgovanjeStavkaEntity, prefetchPath);
			return _TrgovanjeStavkaEntity;
		}

		#endregion
		
		/// <summary> Static CTor for setting up custom property hashtables. Is executed before the first instance of this entity class or derived classes is constructed. </summary>
		static TrgovanjeStavkaEntity()
		{
			SetupCustomPropertyHashtables();
		}
		
		/// <summary> CTor</summary>
		public TrgovanjeStavkaEntity():base("TrgovanjeStavkaEntity")
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <remarks>For framework usage.</remarks>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public TrgovanjeStavkaEntity(IEntityFields2 fields):base("TrgovanjeStavkaEntity")
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this TrgovanjeStavkaEntity</param>
		public TrgovanjeStavkaEntity(IValidator validator):base("TrgovanjeStavkaEntity")
		{
			InitClassEmpty(validator, null);
		}
				
		/// <summary> CTor</summary>
		/// <param name="trgovanjeStavkaId">PK value for TrgovanjeStavka which data should be fetched into this TrgovanjeStavka object</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TrgovanjeStavkaEntity(System.Int64 trgovanjeStavkaId):base("TrgovanjeStavkaEntity")
		{
			InitClassEmpty(null, null);
			this.TrgovanjeStavkaId = trgovanjeStavkaId;
		}

		/// <summary> CTor</summary>
		/// <param name="trgovanjeStavkaId">PK value for TrgovanjeStavka which data should be fetched into this TrgovanjeStavka object</param>
		/// <param name="validator">The custom validator object for this TrgovanjeStavkaEntity</param>
		/// <remarks>The entity is not fetched by this constructor. Use a DataAccessAdapter for that.</remarks>
		public TrgovanjeStavkaEntity(System.Int64 trgovanjeStavkaId, IValidator validator):base("TrgovanjeStavkaEntity")
		{
			InitClassEmpty(validator, null);
			this.TrgovanjeStavkaId = trgovanjeStavkaId;
		}

		/// <summary> Protected CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		[EditorBrowsable(EditorBrowsableState.Never)]
		protected TrgovanjeStavkaEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			if(SerializationHelper.Optimization != SerializationOptimization.Fast) 
			{
				_rok = (RokEntity)info.GetValue("_rok", typeof(RokEntity));
				if(_rok!=null)
				{
					_rok.AfterSave+=new EventHandler(OnEntityAfterSave);
				}
				_trgovanjeGlava = (TrgovanjeGlavaEntity)info.GetValue("_trgovanjeGlava", typeof(TrgovanjeGlavaEntity));
				if(_trgovanjeGlava!=null)
				{
					_trgovanjeGlava.AfterSave+=new EventHandler(OnEntityAfterSave);
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
			switch((TrgovanjeStavkaFieldIndex)fieldIndex)
			{
				case TrgovanjeStavkaFieldIndex.RokId:
					DesetupSyncRok(true, false);
					break;
				case TrgovanjeStavkaFieldIndex.TrgovanjeGlavaId:
					DesetupSyncTrgovanjeGlava(true, false);
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
				case "Rok":
					this.Rok = (RokEntity)entity;
					break;
				case "TrgovanjeGlava":
					this.TrgovanjeGlava = (TrgovanjeGlavaEntity)entity;
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
				case "Rok":
					toReturn.Add(Relations.RokEntityUsingRokId);
					break;
				case "TrgovanjeGlava":
					toReturn.Add(Relations.TrgovanjeGlavaEntityUsingTrgovanjeGlavaId);
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
				case "Rok":
					SetupSyncRok(relatedEntity);
					break;
				case "TrgovanjeGlava":
					SetupSyncTrgovanjeGlava(relatedEntity);
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
				case "Rok":
					DesetupSyncRok(false, true);
					break;
				case "TrgovanjeGlava":
					DesetupSyncTrgovanjeGlava(false, true);
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
			if(_rok!=null)
			{
				toReturn.Add(_rok);
			}
			if(_trgovanjeGlava!=null)
			{
				toReturn.Add(_trgovanjeGlava);
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
				info.AddValue("_rok", (!this.MarkedForDeletion?_rok:null));
				info.AddValue("_trgovanjeGlava", (!this.MarkedForDeletion?_trgovanjeGlava:null));
			}
			// __LLBLGENPRO_USER_CODE_REGION_START GetObjectInfo
			// __LLBLGENPRO_USER_CODE_REGION_END
			base.GetObjectData(info, context);
		}


				
		/// <summary>Gets a list of all the EntityRelation objects the type of this instance has.</summary>
		/// <returns>A list of all the EntityRelation objects the type of this instance has. Hierarchy relations are excluded.</returns>
		protected override List<IEntityRelation> GetAllRelations()
		{
			return new TrgovanjeStavkaRelations().GetAllRelations();
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Rok' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoRok()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(RokFields.RokId, null, ComparisonOperator.Equal, this.RokId));
			return bucket;
		}

		/// <summary> Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'TrgovanjeGlava' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoTrgovanjeGlava()
		{
			IRelationPredicateBucket bucket = new RelationPredicateBucket();
			bucket.PredicateExpression.Add(new FieldCompareValuePredicate(TrgovanjeGlavaFields.TrgovanjeGlavaId, null, ComparisonOperator.Equal, this.TrgovanjeGlavaId));
			return bucket;
		}
		

		/// <summary>Creates a new instance of the factory related to this entity</summary>
		protected override IEntityFactory2 CreateEntityFactory()
		{
			return EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeStavkaEntityFactory));
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
			toReturn.Add("Rok", _rok);
			toReturn.Add("TrgovanjeGlava", _trgovanjeGlava);
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
			_fieldsCustomProperties.Add("Ponuda", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PonudaDodatak", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Potraznja", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PotraznjaDodatak", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("Promet", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("PrometDodatak", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("RokId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TrgovanjeGlavaId", fieldHashtable);
			fieldHashtable = new Dictionary<string, string>();
			_fieldsCustomProperties.Add("TrgovanjeStavkaId", fieldHashtable);
		}
		#endregion

		/// <summary> Removes the sync logic for member _rok</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncRok(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _rok, new PropertyChangedEventHandler( OnRokPropertyChanged ), "Rok", NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses.StaticTrgovanjeStavkaRelations.RokEntityUsingRokIdStatic, true, signalRelatedEntity, "TrgovanjeStavkaCollection", resetFKFields, new int[] { (int)TrgovanjeStavkaFieldIndex.RokId } );
			_rok = null;
		}

		/// <summary> setups the sync logic for member _rok</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncRok(IEntityCore relatedEntity)
		{
			if(_rok!=relatedEntity)
			{
				DesetupSyncRok(true, true);
				_rok = (RokEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _rok, new PropertyChangedEventHandler( OnRokPropertyChanged ), "Rok", NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses.StaticTrgovanjeStavkaRelations.RokEntityUsingRokIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnRokPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Removes the sync logic for member _trgovanjeGlava</summary>
		/// <param name="signalRelatedEntity">If set to true, it will call the related entity's UnsetRelatedEntity method</param>
		/// <param name="resetFKFields">if set to true it will also reset the FK fields pointing to the related entity</param>
		private void DesetupSyncTrgovanjeGlava(bool signalRelatedEntity, bool resetFKFields)
		{
			this.PerformDesetupSyncRelatedEntity( _trgovanjeGlava, new PropertyChangedEventHandler( OnTrgovanjeGlavaPropertyChanged ), "TrgovanjeGlava", NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses.StaticTrgovanjeStavkaRelations.TrgovanjeGlavaEntityUsingTrgovanjeGlavaIdStatic, true, signalRelatedEntity, "TrgovanjeStavkaCollection", resetFKFields, new int[] { (int)TrgovanjeStavkaFieldIndex.TrgovanjeGlavaId } );
			_trgovanjeGlava = null;
		}

		/// <summary> setups the sync logic for member _trgovanjeGlava</summary>
		/// <param name="relatedEntity">Instance to set as the related entity of type entityType</param>
		private void SetupSyncTrgovanjeGlava(IEntityCore relatedEntity)
		{
			if(_trgovanjeGlava!=relatedEntity)
			{
				DesetupSyncTrgovanjeGlava(true, true);
				_trgovanjeGlava = (TrgovanjeGlavaEntity)relatedEntity;
				this.PerformSetupSyncRelatedEntity( _trgovanjeGlava, new PropertyChangedEventHandler( OnTrgovanjeGlavaPropertyChanged ), "TrgovanjeGlava", NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses.StaticTrgovanjeStavkaRelations.TrgovanjeGlavaEntityUsingTrgovanjeGlavaIdStatic, true, new string[] {  } );
			}
		}
		
		/// <summary>Handles property change events of properties in a related entity.</summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnTrgovanjeGlavaPropertyChanged( object sender, PropertyChangedEventArgs e )
		{
			switch( e.PropertyName )
			{
				default:
					break;
			}
		}

		/// <summary> Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this TrgovanjeStavkaEntity</param>
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
		public  static TrgovanjeStavkaRelations Relations
		{
			get	{ return new TrgovanjeStavkaRelations(); }
		}
		
		/// <summary> The custom properties for this entity type.</summary>
		/// <remarks>The data returned from this property should be considered read-only: it is not thread safe to alter this data at runtime.</remarks>
		public  static Dictionary<string, string> CustomProperties
		{
			get { return _customProperties;}
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Rok' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathRok
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(RokEntityFactory))),	(IEntityRelation)GetRelationsForField("Rok")[0], (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeStavkaEntity, (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.RokEntity, 0, null, null, null, null, "Rok", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
		}

		/// <summary> Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'TrgovanjeGlava' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathTrgovanjeGlava
		{
			get	{ return new PrefetchPathElement2(new EntityCollection(EntityFactoryCache2.GetEntityFactory(typeof(TrgovanjeGlavaEntityFactory))),	(IEntityRelation)GetRelationsForField("TrgovanjeGlava")[0], (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeStavkaEntity, (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeGlavaEntity, 0, null, null, null, null, "TrgovanjeGlava", SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne); }
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

		/// <summary> The ConcurrencyGuid property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."ConcurrencyGuid"<br/>
		/// Table field type characteristics (type, precision, scale, length): NVarChar, 0, 0, 50<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.String ConcurrencyGuid
		{
			get { return (System.String)GetValue((int)TrgovanjeStavkaFieldIndex.ConcurrencyGuid, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.ConcurrencyGuid, value); }
		}

		/// <summary> The Ponuda property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."Ponuda"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 18, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal Ponuda
		{
			get { return (System.Decimal)GetValue((int)TrgovanjeStavkaFieldIndex.Ponuda, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.Ponuda, value); }
		}

		/// <summary> The PonudaDodatak property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."PonudaDodatak"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal PonudaDodatak
		{
			get { return (System.Decimal)GetValue((int)TrgovanjeStavkaFieldIndex.PonudaDodatak, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.PonudaDodatak, value); }
		}

		/// <summary> The Potraznja property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."Potraznja"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 18, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal Potraznja
		{
			get { return (System.Decimal)GetValue((int)TrgovanjeStavkaFieldIndex.Potraznja, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.Potraznja, value); }
		}

		/// <summary> The PotraznjaDodatak property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."PotraznjaDodatak"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal PotraznjaDodatak
		{
			get { return (System.Decimal)GetValue((int)TrgovanjeStavkaFieldIndex.PotraznjaDodatak, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.PotraznjaDodatak, value); }
		}

		/// <summary> The Promet property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."Promet"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 18, 2, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal Promet
		{
			get { return (System.Decimal)GetValue((int)TrgovanjeStavkaFieldIndex.Promet, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.Promet, value); }
		}

		/// <summary> The PrometDodatak property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."PrometDodatak"<br/>
		/// Table field type characteristics (type, precision, scale, length): Decimal, 10, 4, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Decimal PrometDodatak
		{
			get { return (System.Decimal)GetValue((int)TrgovanjeStavkaFieldIndex.PrometDodatak, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.PrometDodatak, value); }
		}

		/// <summary> The RokId property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."RokId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int64 RokId
		{
			get { return (System.Int64)GetValue((int)TrgovanjeStavkaFieldIndex.RokId, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.RokId, value); }
		}

		/// <summary> The TrgovanjeGlavaId property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."TrgovanjeGlavaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		[JsonProperty]		
		public virtual System.Int64 TrgovanjeGlavaId
		{
			get { return (System.Int64)GetValue((int)TrgovanjeStavkaFieldIndex.TrgovanjeGlavaId, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.TrgovanjeGlavaId, value); }
		}

		/// <summary> The TrgovanjeStavkaId property of the Entity TrgovanjeStavka<br/><br/></summary>
		/// <remarks>Mapped on  table field: "TrgovanjeStavka"."TrgovanjeStavkaId"<br/>
		/// Table field type characteristics (type, precision, scale, length): BigInt, 19, 0, 0<br/>
		/// Table field behavior characteristics (is nullable, is PK, is identity): false, true, true</remarks>
		[JsonProperty]		
		public virtual System.Int64 TrgovanjeStavkaId
		{
			get { return (System.Int64)GetValue((int)TrgovanjeStavkaFieldIndex.TrgovanjeStavkaId, true); }
			set	{ SetValue((int)TrgovanjeStavkaFieldIndex.TrgovanjeStavkaId, value); }
		}

		/// <summary> Gets / sets related entity of type 'RokEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual RokEntity Rok
		{
			get	{ return _rok; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncRok(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "TrgovanjeStavkaCollection", "Rok", _rok, true); 
				}
			}
		}

		/// <summary> Gets / sets related entity of type 'TrgovanjeGlavaEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		[JsonProperty]
		public virtual TrgovanjeGlavaEntity TrgovanjeGlava
		{
			get	{ return _trgovanjeGlava; }
			set
			{
				if(this.IsDeserializing)
				{
					SetupSyncTrgovanjeGlava(value);
				}
				else
				{
					SetSingleRelatedEntityNavigator(value, "TrgovanjeStavkaCollection", "TrgovanjeGlava", _trgovanjeGlava, true); 
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
			get { return (int)NinjaSoftware.TrzisteNovca.CoolJ.EntityType.TrgovanjeStavkaEntity; }
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
