﻿///////////////////////////////////////////////////////////////
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
	/// <summary>Implements the relations factory for the entity: TrgovanjeGlava. </summary>
	public partial class TrgovanjeGlavaRelations
	{
		/// <summary>CTor</summary>
		public TrgovanjeGlavaRelations()
		{
		}

		/// <summary>Gets all relations of the TrgovanjeGlavaEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.TrgovanjeStavkaEntityUsingTrgovanjeGlavaId);
			return toReturn;
		}

		#region Class Property Declarations

		/// <summary>Returns a new IEntityRelation object, between TrgovanjeGlavaEntity and TrgovanjeStavkaEntity over the 1:n relation they have, using the relation between the fields:
		/// TrgovanjeGlava.TrgovanjeGlavaId - TrgovanjeStavka.TrgovanjeGlavaId
		/// </summary>
		public virtual IEntityRelation TrgovanjeStavkaEntityUsingTrgovanjeGlavaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.OneToMany, "TrgovanjeStavkaCollection" , true);
				relation.AddEntityFieldPair(TrgovanjeGlavaFields.TrgovanjeGlavaId, TrgovanjeStavkaFields.TrgovanjeGlavaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeGlavaEntity", true);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("TrgovanjeStavkaEntity", false);
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
	internal static class StaticTrgovanjeGlavaRelations
	{
		internal static readonly IEntityRelation TrgovanjeStavkaEntityUsingTrgovanjeGlavaIdStatic = new TrgovanjeGlavaRelations().TrgovanjeStavkaEntityUsingTrgovanjeGlavaId;

		/// <summary>CTor</summary>
		static StaticTrgovanjeGlavaRelations()
		{
		}
	}
}
