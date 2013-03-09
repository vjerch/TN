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
	/// <summary>Implements the relations factory for the entity: TrgovanjeStavka. </summary>
	public partial class TrgovanjeStavkaRelations
	{
		/// <summary>CTor</summary>
		public TrgovanjeStavkaRelations()
		{
		}

		/// <summary>Gets all relations of the TrgovanjeStavkaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.RokEntityUsingRokId);
			toReturn.Add(this.TrgovanjeGlavaEntityUsingTrgovanjeGlavaId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between TrgovanjeStavkaEntity and RokEntity over the m:1 relation they have, using the relation between the fields:
		/// TrgovanjeStavka.RokId - Rok.RokId
		/// </summary>
		public virtual IEntityRelation RokEntityUsingRokId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "Rok", false);
				relation.AddEntityFieldPair(RokFields.RokId, TrgovanjeStavkaFields.RokId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RokEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaEntity", true);
				return relation;
			}
		}
		/// <summary>Returns a new IEntityRelation object, between TrgovanjeStavkaEntity and TrgovanjeGlavaEntity over the m:1 relation they have, using the relation between the fields:
		/// TrgovanjeStavka.TrgovanjeGlavaId - TrgovanjeGlava.TrgovanjeGlavaId
		/// </summary>
		public virtual IEntityRelation TrgovanjeGlavaEntityUsingTrgovanjeGlavaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "TrgovanjeGlava", false);
				relation.AddEntityFieldPair(TrgovanjeGlavaFields.TrgovanjeGlavaId, TrgovanjeStavkaFields.TrgovanjeGlavaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeGlavaEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaEntity", true);
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
	internal static class StaticTrgovanjeStavkaRelations
	{
		internal static readonly IEntityRelation RokEntityUsingRokIdStatic = new TrgovanjeStavkaRelations().RokEntityUsingRokId;
		internal static readonly IEntityRelation TrgovanjeGlavaEntityUsingTrgovanjeGlavaIdStatic = new TrgovanjeStavkaRelations().TrgovanjeGlavaEntityUsingTrgovanjeGlavaId;

		/// <summary>CTor</summary>
		static StaticTrgovanjeStavkaRelations()
		{
		}
	}
}
