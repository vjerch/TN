///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.Collections.Generic;
using NinjaSoftware.TrzisteNovca.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.FactoryClasses;
using NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: TrgovanjeStavkaHnb. </summary>
	public partial class TrgovanjeStavkaHnbRelations
	{
		/// <summary>CTor</summary>
		public TrgovanjeStavkaHnbRelations()
		{
		}

		/// <summary>Gets all relations of the TrgovanjeStavkaHnbEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.TrgovanjeGlavaHnbEntityUsingTrgovanjeGlavaHnbId);
			toReturn.Add(this.TrgovanjeVrstaRoEntityUsingTrgovanjeVrstaId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between TrgovanjeStavkaHnbEntity and TrgovanjeGlavaHnbEntity over the m:1 relation they have, using the relation between the fields:
		/// TrgovanjeStavkaHnb.TrgovanjeGlavaHnbId - TrgovanjeGlavaHnb.TrgovanjeGlavaHnbId
		/// </summary>
		public virtual IEntityRelation TrgovanjeGlavaHnbEntityUsingTrgovanjeGlavaHnbId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "TrgovanjeGlavaHnb", false);
				relation.AddEntityFieldPair(TrgovanjeGlavaHnbFields.TrgovanjeGlavaHnbId, TrgovanjeStavkaHnbFields.TrgovanjeGlavaHnbId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeGlavaHnbEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaHnbEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between TrgovanjeStavkaHnbEntity and TrgovanjeVrstaRoEntity over the m:1 relation they have, using the relation between the fields:
		/// TrgovanjeStavkaHnb.TrgovanjeVrstaId - TrgovanjeVrstaRo.TrgovanjeVrstaId
		/// </summary>
		public virtual IEntityRelation TrgovanjeVrstaRoEntityUsingTrgovanjeVrstaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "TrgovanjeVrsta", false);
				relation.AddEntityFieldPair(TrgovanjeVrstaRoFields.TrgovanjeVrstaId, TrgovanjeStavkaHnbFields.TrgovanjeVrstaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeVrstaRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaHnbEntity", true);
				return relation;
			}
		}
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSubTypeRelation(string subTypeEntityName) { return null; }
		/// <summary>stub, not used in this entity, only for TargetPerEntity entities.</summary>
		public virtual IEntityRelation GetSuperTypeRelation() { return null;}
		#endregion

		#region Included Code

		#endregion
	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticTrgovanjeStavkaHnbRelations
	{
		internal static readonly IEntityRelation TrgovanjeGlavaHnbEntityUsingTrgovanjeGlavaHnbIdStatic = new TrgovanjeStavkaHnbRelations().TrgovanjeGlavaHnbEntityUsingTrgovanjeGlavaHnbId;
		internal static readonly IEntityRelation TrgovanjeVrstaRoEntityUsingTrgovanjeVrstaIdStatic = new TrgovanjeStavkaHnbRelations().TrgovanjeVrstaRoEntityUsingTrgovanjeVrstaId;

		/// <summary>CTor</summary>
		static StaticTrgovanjeStavkaHnbRelations()
		{
		}
	}
}
