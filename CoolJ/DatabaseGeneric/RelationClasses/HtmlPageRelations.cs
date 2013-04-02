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
	/// <summary>Implements the relations factory for the entity: HtmlPage. </summary>
	public partial class HtmlPageRelations
	{
		/// <summary>CTor</summary>
		public HtmlPageRelations()
		{
		}

		/// <summary>Gets all relations of the HtmlPageEntity as a list of IEntityRelation objects.</summary>
		/// <returns>a list of IEntityRelation objects</returns>
		public virtual List<IEntityRelation> GetAllRelations()
		{
			List<IEntityRelation> toReturn = new List<IEntityRelation>();
			toReturn.Add(this.SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaId);
			return toReturn;
		}

		#region Class Property Declarations



		/// <summary>Returns a new IEntityRelation object, between HtmlPageEntity and SistemskaInstancaPodatakaRoEntity over the m:1 relation they have, using the relation between the fields:
		/// HtmlPage.SistemskaInstancaPodatakaId - SistemskaInstancaPodatakaRo.SistemskaInstancaPodatakaId
		/// </summary>
		public virtual IEntityRelation SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaId
		{
			get
			{
				IEntityRelation relation = new EntityRelation(SD.LLBLGen.Pro.ORMSupportClasses.RelationType.ManyToOne, "SistemskaInstancaPodataka", false);
				relation.AddEntityFieldPair(SistemskaInstancaPodatakaRoFields.SistemskaInstancaPodatakaId, HtmlPageFields.SistemskaInstancaPodatakaId);
				relation.InheritanceInfoPkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("SistemskaInstancaPodatakaRoEntity", false);
				relation.InheritanceInfoFkSideEntity = InheritanceInfoProviderSingleton.GetInstance().GetInheritanceInfo("HtmlPageEntity", true);
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
	internal static class StaticHtmlPageRelations
	{
		internal static readonly IEntityRelation SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaIdStatic = new HtmlPageRelations().SistemskaInstancaPodatakaRoEntityUsingSistemskaInstancaPodatakaId;

		/// <summary>CTor</summary>
		static StaticHtmlPageRelations()
		{
		}
	}
}
