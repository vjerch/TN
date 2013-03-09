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
	/// <summary>Implements the relations factory for the entity: Rok. </summary>
	public partial class RokRelations
	{
		/// <summary>CTor</summary>
		public RokRelations()
		{
		}

		/// <summary>Gets all relations of the RokEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.TrgovanjeStavkaEntityUsingRokId);
			toReturn.Add(this.RokTipRoEntityUsingRokTipId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between RokEntity and TrgovanjeStavkaEntity over the 1:n relation they have, using the relation between the fields:
		/// Rok.RokId - TrgovanjeStavka.RokId
		/// </summary>
		public virtual IEntityRelation TrgovanjeStavkaEntityUsingRokId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TrgovanjeStavkaCollection" , true);
				relation.AddEntityFieldPair(RokFields.RokId, TrgovanjeStavkaFields.RokId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RokEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaEntity", false);
				return relation;
			}
		}


		/// <summary>Returns a new IEntityRelation object, between RokEntity and RokTipRoEntity over the m:1 relation they have, using the relation between the fields:
		/// Rok.RokTipId - RokTipRo.RokTipId
		/// </summary>
		public virtual IEntityRelation RokTipRoEntityUsingRokTipId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "RokTip", false);
				relation.AddEntityFieldPair(RokTipRoFields.RokTipId, RokFields.RokTipId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RokTipRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("RokEntity", true);
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
	internal static class StaticRokRelations
	{
		internal static readonly IEntityRelation TrgovanjeStavkaEntityUsingRokIdStatic = new RokRelations().TrgovanjeStavkaEntityUsingRokId;
		internal static readonly IEntityRelation RokTipRoEntityUsingRokTipIdStatic = new RokRelations().RokTipRoEntityUsingRokTipId;

		/// <summary>CTor</summary>
		static StaticRokRelations()
		{
		}
	}
}
