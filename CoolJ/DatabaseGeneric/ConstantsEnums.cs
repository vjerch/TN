///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;

namespace NinjaSoftware.TrzisteNovca.CoolJ
{
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AuditInfo.</summary>
	public enum AuditInfoFieldIndex
	{
		///<summary>ActionDateTime. </summary>
		ActionDateTime,
		///<summary>AuditInfoActionTypeId. </summary>
		AuditInfoActionTypeId,
		///<summary>AuditInfoId. </summary>
		AuditInfoId,
		///<summary>ConcurrencyGuid. </summary>
		ConcurrencyGuid,
		///<summary>EntityId. </summary>
		EntityId,
		///<summary>JsonData. </summary>
		JsonData,
		///<summary>PrimaryKeyValue. </summary>
		PrimaryKeyValue,
		///<summary>UserId. </summary>
		UserId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: AuditInfoActionTypeRo.</summary>
	public enum AuditInfoActionTypeRoFieldIndex
	{
		///<summary>AuditInfoActionTypeId. </summary>
		AuditInfoActionTypeId,
		///<summary>Code. </summary>
		Code,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: EntityRo.</summary>
	public enum EntityRoFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>EntityId. </summary>
		EntityId,
		///<summary>Name. </summary>
		Name,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: Error.</summary>
	public enum ErrorFieldIndex
	{
		///<summary>ConcurrencyGuid. </summary>
		ConcurrencyGuid,
		///<summary>ErrorDateTime. </summary>
		ErrorDateTime,
		///<summary>ErrorId. </summary>
		ErrorId,
		///<summary>Message. </summary>
		Message,
		///<summary>ParentErrorId. </summary>
		ParentErrorId,
		///<summary>StackTrace. </summary>
		StackTrace,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: RoleRo.</summary>
	public enum RoleRoFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>Name. </summary>
		Name,
		///<summary>RoleId. </summary>
		RoleId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TrgovanjeGlava.</summary>
	public enum TrgovanjeGlavaFieldIndex
	{
		///<summary>ConcurrencyGuid. </summary>
		ConcurrencyGuid,
		///<summary>Datum. </summary>
		Datum,
		///<summary>Komentar. </summary>
		Komentar,
		///<summary>TrgovanjeGlavaId. </summary>
		TrgovanjeGlavaId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TrgovanjeStavka.</summary>
	public enum TrgovanjeStavkaFieldIndex
	{
		///<summary>ConcurrencyGuid. </summary>
		ConcurrencyGuid,
		///<summary>Ponuda. </summary>
		Ponuda,
		///<summary>PonudaDodatak. </summary>
		PonudaDodatak,
		///<summary>Potraznja. </summary>
		Potraznja,
		///<summary>PotraznjaDodatak. </summary>
		PotraznjaDodatak,
		///<summary>Promet. </summary>
		Promet,
		///<summary>PrometDodatak. </summary>
		PrometDodatak,
		///<summary>TrgovanjeGlavaId. </summary>
		TrgovanjeGlavaId,
		///<summary>TrgovanjeStavkaId. </summary>
		TrgovanjeStavkaId,
		///<summary>TrgovanjeVrstaId. </summary>
		TrgovanjeVrstaId,
		///<summary>ValutaId. </summary>
		ValutaId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: TrgovanjeVrstaRo.</summary>
	public enum TrgovanjeVrstaRoFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>Name. </summary>
		Name,
		///<summary>SifraSlog. </summary>
		SifraSlog,
		///<summary>TrgovanjeVrstaId. </summary>
		TrgovanjeVrstaId,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: User.</summary>
	public enum UserFieldIndex
	{
		///<summary>ConcurrencyGuid. </summary>
		ConcurrencyGuid,
		///<summary>Password. </summary>
		Password,
		///<summary>RoleId. </summary>
		RoleId,
		///<summary>UserId. </summary>
		UserId,
		///<summary>Username. </summary>
		Username,
		/// <summary></summary>
		AmountOfFields
	}
	/// <summary>Index enum to fast-access EntityFields in the IEntityFields collection for the entity: ValutaRo.</summary>
	public enum ValutaRoFieldIndex
	{
		///<summary>Code. </summary>
		Code,
		///<summary>Name. </summary>
		Name,
		///<summary>SifraSlog. </summary>
		SifraSlog,
		///<summary>ValutaId. </summary>
		ValutaId,
		/// <summary></summary>
		AmountOfFields
	}



	/// <summary>Enum definition for all the entity types defined in this namespace. Used by the entityfields factory.</summary>
	public enum EntityType
	{
		///<summary>AuditInfo</summary>
		AuditInfoEntity,
		///<summary>AuditInfoActionTypeRo</summary>
		AuditInfoActionTypeRoEntity,
		///<summary>EntityRo</summary>
		EntityRoEntity,
		///<summary>Error</summary>
		ErrorEntity,
		///<summary>RoleRo</summary>
		RoleRoEntity,
		///<summary>TrgovanjeGlava</summary>
		TrgovanjeGlavaEntity,
		///<summary>TrgovanjeStavka</summary>
		TrgovanjeStavkaEntity,
		///<summary>TrgovanjeVrstaRo</summary>
		TrgovanjeVrstaRoEntity,
		///<summary>User</summary>
		UserEntity,
		///<summary>ValutaRo</summary>
		ValutaRoEntity
	}


	#region Custom ConstantsEnums Code
	
	// __LLBLGENPRO_USER_CODE_REGION_START CustomUserConstants
	// __LLBLGENPRO_USER_CODE_REGION_END
	#endregion

	#region Included code

	#endregion
}

