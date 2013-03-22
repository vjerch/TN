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
using System.Data;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the PersistenceInfoProviderBase class is threadsafe.</remarks>
	internal static class PersistenceInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass((11 + 0));
			InitAuditInfoEntityMappings();
			InitAuditInfoActionTypeRoEntityMappings();
			InitEntityRoEntityMappings();
			InitErrorEntityMappings();
			InitRepoAukcijaEntityMappings();
			InitRoleRoEntityMappings();
			InitTrgovanjeGlavaEntityMappings();
			InitTrgovanjeStavkaEntityMappings();
			InitTrgovanjeVrstaRoEntityMappings();
			InitUserEntityMappings();
			InitValutaRoEntityMappings();

		}


		/// <summary>Inits AuditInfoEntity's mappings</summary>
		private void InitAuditInfoEntityMappings()
		{
			this.AddElementMapping( "AuditInfoEntity", @"TrzisteNovca", @"dbo", "AuditInfo", 8 );
			this.AddElementFieldMapping( "AuditInfoEntity", "ActionDateTime", "ActionDateTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 0 );
			this.AddElementFieldMapping( "AuditInfoEntity", "AuditInfoActionTypeId", "AuditInfoActionTypeId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "AuditInfoEntity", "AuditInfoId", "AuditInfoId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "AuditInfoEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "AuditInfoEntity", "EntityId", "EntityId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "AuditInfoEntity", "JsonData", "JsonData", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
			this.AddElementFieldMapping( "AuditInfoEntity", "PrimaryKeyValue", "PrimaryKeyValue", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 6 );
			this.AddElementFieldMapping( "AuditInfoEntity", "UserId", "UserId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 7 );
		}
		/// <summary>Inits AuditInfoActionTypeRoEntity's mappings</summary>
		private void InitAuditInfoActionTypeRoEntityMappings()
		{
			this.AddElementMapping( "AuditInfoActionTypeRoEntity", @"TrzisteNovca", @"dbo", "AuditInfoActionTypeRo", 3 );
			this.AddElementFieldMapping( "AuditInfoActionTypeRoEntity", "AuditInfoActionTypeId", "AuditInfoActionTypeId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 0 );
			this.AddElementFieldMapping( "AuditInfoActionTypeRoEntity", "Code", "Code", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "AuditInfoActionTypeRoEntity", "Name", "Name", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits EntityRoEntity's mappings</summary>
		private void InitEntityRoEntityMappings()
		{
			this.AddElementMapping( "EntityRoEntity", @"TrzisteNovca", @"dbo", "EntityRo", 3 );
			this.AddElementFieldMapping( "EntityRoEntity", "Code", "Code", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "EntityRoEntity", "EntityId", "EntityId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 1 );
			this.AddElementFieldMapping( "EntityRoEntity", "Name", "Name", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 2 );
		}
		/// <summary>Inits ErrorEntity's mappings</summary>
		private void InitErrorEntityMappings()
		{
			this.AddElementMapping( "ErrorEntity", @"TrzisteNovca", @"dbo", "Error", 6 );
			this.AddElementFieldMapping( "ErrorEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ErrorEntity", "ErrorDateTime", "ErrorDateTime", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "ErrorEntity", "ErrorId", "ErrorId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "ErrorEntity", "Message", "Message", false, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 3 );
			this.AddElementFieldMapping( "ErrorEntity", "ParentErrorId", "ParentErrorId", true, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 4 );
			this.AddElementFieldMapping( "ErrorEntity", "StackTrace", "StackTrace", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 5 );
		}
		/// <summary>Inits RepoAukcijaEntity's mappings</summary>
		private void InitRepoAukcijaEntityMappings()
		{
			this.AddElementMapping( "RepoAukcijaEntity", @"TrzisteNovca", @"dbo", "RepoAukcija", 15 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "BrojAukcije", "BrojAukcije", true, "NVarChar", 20, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "DatumAukcije", "DatumAukcije", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 2 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "DatumReotkupa", "DatumReotkupa", true, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 3 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "FiksnaRepoStopa", "FiksnaRepoStopa", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 4 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "GranicnaRepoStopa", "GranicnaRepoStopa", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 5 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "KoeficijentRaspodjele", "KoeficijentRaspodjele", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 6 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "NajnizaRepoStopa", "NajnizaRepoStopa", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 7 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "NajvisaRepoStopa", "NajvisaRepoStopa", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 8 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "OdbijenePonudeUkupno", "OdbijenePonudeUkupno", true, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 9 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "PostoPrihvacenihPoGranicnojStopi", "PostoPrihvacenihPoGranicnojStopi", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 10 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "PrihvacenePonudeUkupno", "PrihvacenePonudeUkupno", true, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 11 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "PristiglePonudeUkupno", "PristiglePonudeUkupno", true, "Decimal", 0, 2, 10, false, "", null, typeof(System.Decimal), 12 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "RepoAukcijaId", "RepoAukcijaId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 13 );
			this.AddElementFieldMapping( "RepoAukcijaEntity", "VaganaRepoStopa", "VaganaRepoStopa", true, "Decimal", 0, 2, 5, false, "", null, typeof(System.Decimal), 14 );
		}
		/// <summary>Inits RoleRoEntity's mappings</summary>
		private void InitRoleRoEntityMappings()
		{
			this.AddElementMapping( "RoleRoEntity", @"TrzisteNovca", @"dbo", "RoleRo", 3 );
			this.AddElementFieldMapping( "RoleRoEntity", "Code", "Code", false, "NVarChar", 128, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "RoleRoEntity", "Name", "Name", false, "NVarChar", 256, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "RoleRoEntity", "RoleId", "RoleId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 2 );
		}
		/// <summary>Inits TrgovanjeGlavaEntity's mappings</summary>
		private void InitTrgovanjeGlavaEntityMappings()
		{
			this.AddElementMapping( "TrgovanjeGlavaEntity", @"TrzisteNovca", @"dbo", "TrgovanjeGlava", 4 );
			this.AddElementFieldMapping( "TrgovanjeGlavaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "TrgovanjeGlavaEntity", "Datum", "Datum", false, "DateTime", 0, 0, 0, false, "", null, typeof(System.DateTime), 1 );
			this.AddElementFieldMapping( "TrgovanjeGlavaEntity", "Komentar", "Komentar", true, "NVarChar", 2147483647, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "TrgovanjeGlavaEntity", "TrgovanjeGlavaId", "TrgovanjeGlavaId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
		}
		/// <summary>Inits TrgovanjeStavkaEntity's mappings</summary>
		private void InitTrgovanjeStavkaEntityMappings()
		{
			this.AddElementMapping( "TrgovanjeStavkaEntity", @"TrzisteNovca", @"dbo", "TrgovanjeStavka", 11 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "Ponuda", "Ponuda", false, "Decimal", 0, 2, 18, false, "", null, typeof(System.Decimal), 1 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "PonudaDodatak", "PonudaDodatak", false, "Decimal", 0, 4, 10, false, "", null, typeof(System.Decimal), 2 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "Potraznja", "Potraznja", false, "Decimal", 0, 2, 18, false, "", null, typeof(System.Decimal), 3 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "PotraznjaDodatak", "PotraznjaDodatak", false, "Decimal", 0, 4, 10, false, "", null, typeof(System.Decimal), 4 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "Promet", "Promet", false, "Decimal", 0, 2, 18, false, "", null, typeof(System.Decimal), 5 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "PrometDodatak", "PrometDodatak", false, "Decimal", 0, 4, 10, false, "", null, typeof(System.Decimal), 6 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "TrgovanjeGlavaId", "TrgovanjeGlavaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 7 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "TrgovanjeStavkaId", "TrgovanjeStavkaId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 8 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "TrgovanjeVrstaId", "TrgovanjeVrstaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 9 );
			this.AddElementFieldMapping( "TrgovanjeStavkaEntity", "ValutaId", "ValutaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 10 );
		}
		/// <summary>Inits TrgovanjeVrstaRoEntity's mappings</summary>
		private void InitTrgovanjeVrstaRoEntityMappings()
		{
			this.AddElementMapping( "TrgovanjeVrstaRoEntity", @"TrzisteNovca", @"dbo", "TrgovanjeVrstaRo", 4 );
			this.AddElementFieldMapping( "TrgovanjeVrstaRoEntity", "Code", "Code", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "TrgovanjeVrstaRoEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "TrgovanjeVrstaRoEntity", "SifraSlog", "SifraSlog", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "TrgovanjeVrstaRoEntity", "TrgovanjeVrstaId", "TrgovanjeVrstaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 3 );
		}
		/// <summary>Inits UserEntity's mappings</summary>
		private void InitUserEntityMappings()
		{
			this.AddElementMapping( "UserEntity", @"TrzisteNovca", @"dbo", "User", 5 );
			this.AddElementFieldMapping( "UserEntity", "ConcurrencyGuid", "ConcurrencyGuid", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "UserEntity", "Password", "Password", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "UserEntity", "RoleId", "RoleId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 2 );
			this.AddElementFieldMapping( "UserEntity", "UserId", "UserId", false, "BigInt", 0, 0, 19, true, "SCOPE_IDENTITY()", null, typeof(System.Int64), 3 );
			this.AddElementFieldMapping( "UserEntity", "Username", "Username", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4 );
		}
		/// <summary>Inits ValutaRoEntity's mappings</summary>
		private void InitValutaRoEntityMappings()
		{
			this.AddElementMapping( "ValutaRoEntity", @"TrzisteNovca", @"dbo", "ValutaRo", 4 );
			this.AddElementFieldMapping( "ValutaRoEntity", "Code", "Code", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 0 );
			this.AddElementFieldMapping( "ValutaRoEntity", "Name", "Name", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1 );
			this.AddElementFieldMapping( "ValutaRoEntity", "SifraSlog", "SifraSlog", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2 );
			this.AddElementFieldMapping( "ValutaRoEntity", "ValutaId", "ValutaId", false, "BigInt", 0, 0, 19, false, "", null, typeof(System.Int64), 3 );
		}

	}
}