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
	/// <summary>Implements the relations factory for the entity: TrgovanjeGlavaHnb. </summary>
	public partial class TrgovanjeGlavaHnbRelations
	{
		/// <summary>CTor</summary>
		public TrgovanjeGlavaHnbRelations()
		{
		}

		/// <summary>Gets all relations of the TrgovanjeGlavaHnbEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.TrgovanjeStavkaHnbEntityUsingTrgovanjeGlavaHnbId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between TrgovanjeGlavaHnbEntity and TrgovanjeStavkaHnbEntity over the 1:n relation they have, using the relation between the fields:
		/// TrgovanjeGlavaHnb.TrgovanjeGlavaHnbId - TrgovanjeStavkaHnb.TrgovanjeGlavaHnbId
		/// </summary>
		public virtual IEntityRelation TrgovanjeStavkaHnbEntityUsingTrgovanjeGlavaHnbId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TrgovanjeStavkaHnbCollection" , true);
				relation.AddEntityFieldPair(TrgovanjeGlavaHnbFields.TrgovanjeGlavaHnbId, TrgovanjeStavkaHnbFields.TrgovanjeGlavaHnbId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeGlavaHnbEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaHnbEntity", false);
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
	internal static class StaticTrgovanjeGlavaHnbRelations
	{
		internal static readonly IEntityRelation TrgovanjeStavkaHnbEntityUsingTrgovanjeGlavaHnbIdStatic = new TrgovanjeGlavaHnbRelations().TrgovanjeStavkaHnbEntityUsingTrgovanjeGlavaHnbId;

		/// <summary>CTor</summary>
		static StaticTrgovanjeGlavaHnbRelations()
		{
		}
	}
}
