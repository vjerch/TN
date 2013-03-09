﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 3.5
// Code is generated using templates: SD.TemplateBindings.SharedTemplates.NET20
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.CoolJ.HelperClasses
{
	
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	
	/// <summary>Singleton implementation of the FieldInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	/// <remarks>It uses a single instance of an internal class. The access isn't marked with locks as the FieldInfoProviderBase class is threadsafe.</remarks>
	internal static class FieldInfoProviderSingleton
	{
		#region Class Member Declarations
		private static readonly IFieldInfoProvider _providerInstance = new FieldInfoProviderCore();
		#endregion

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static FieldInfoProviderSingleton()
		{
		}

		/// <summary>Gets the singleton instance of the FieldInfoProviderCore</summary>
		/// <returns>Instance of the FieldInfoProvider.</returns>
		public static IFieldInfoProvider GetInstance()
		{
			return _providerInstance;
		}
	}

	/// <summary>Actual implementation of the FieldInfoProvider. Used by singleton wrapper.</summary>
	internal class FieldInfoProviderCore : FieldInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="FieldInfoProviderCore"/> class.</summary>
		internal FieldInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores.</summary>
		private void Init()
		{
			this.InitClass( (10 + 0));
			InitAuditInfoEntityInfos();
			InitAuditInfoActionTypeRoEntityInfos();
			InitEntityRoEntityInfos();
			InitErrorEntityInfos();
			InitRokEntityInfos();
			InitRokTipRoEntityInfos();
			InitRoleRoEntityInfos();
			InitTrgovanjeGlavaEntityInfos();
			InitTrgovanjeStavkaEntityInfos();
			InitUserEntityInfos();

			this.ConstructElementFieldStructures(InheritanceInfoProviderSingleton.GetInstance());
		}

		/// <summary>Inits AuditInfoEntity's FieldInfo objects</summary>
		private void InitAuditInfoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditInfoFieldIndex), "AuditInfoEntity");
			this.AddElementFieldInfo("AuditInfoEntity", "ActionDateTime", typeof(System.DateTime), false, false, false, false,  (int)AuditInfoFieldIndex.ActionDateTime, 0, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "AuditInfoActionTypeId", typeof(System.Int64), false, true, false, false,  (int)AuditInfoFieldIndex.AuditInfoActionTypeId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "AuditInfoId", typeof(System.Int64), true, false, false, false,  (int)AuditInfoFieldIndex.AuditInfoId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)AuditInfoFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "EntityId", typeof(System.Int64), false, true, false, false,  (int)AuditInfoFieldIndex.EntityId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "JsonData", typeof(System.String), false, false, false, false,  (int)AuditInfoFieldIndex.JsonData, 2147483647, 0, 0);
			this.AddElementFieldInfo("AuditInfoEntity", "PrimaryKeyValue", typeof(System.Int64), false, false, false, false,  (int)AuditInfoFieldIndex.PrimaryKeyValue, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoEntity", "UserId", typeof(System.Int64), false, true, false, false,  (int)AuditInfoFieldIndex.UserId, 0, 0, 19);
		}
		/// <summary>Inits AuditInfoActionTypeRoEntity's FieldInfo objects</summary>
		private void InitAuditInfoActionTypeRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(AuditInfoActionTypeRoFieldIndex), "AuditInfoActionTypeRoEntity");
			this.AddElementFieldInfo("AuditInfoActionTypeRoEntity", "AuditInfoActionTypeId", typeof(System.Int64), true, false, false, false,  (int)AuditInfoActionTypeRoFieldIndex.AuditInfoActionTypeId, 0, 0, 19);
			this.AddElementFieldInfo("AuditInfoActionTypeRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)AuditInfoActionTypeRoFieldIndex.Code, 128, 0, 0);
			this.AddElementFieldInfo("AuditInfoActionTypeRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)AuditInfoActionTypeRoFieldIndex.Name, 256, 0, 0);
		}
		/// <summary>Inits EntityRoEntity's FieldInfo objects</summary>
		private void InitEntityRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(EntityRoFieldIndex), "EntityRoEntity");
			this.AddElementFieldInfo("EntityRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)EntityRoFieldIndex.Code, 128, 0, 0);
			this.AddElementFieldInfo("EntityRoEntity", "EntityId", typeof(System.Int64), true, false, false, false,  (int)EntityRoFieldIndex.EntityId, 0, 0, 19);
			this.AddElementFieldInfo("EntityRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)EntityRoFieldIndex.Name, 256, 0, 0);
		}
		/// <summary>Inits ErrorEntity's FieldInfo objects</summary>
		private void InitErrorEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(ErrorFieldIndex), "ErrorEntity");
			this.AddElementFieldInfo("ErrorEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)ErrorFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("ErrorEntity", "ErrorDateTime", typeof(System.DateTime), false, false, false, false,  (int)ErrorFieldIndex.ErrorDateTime, 0, 0, 0);
			this.AddElementFieldInfo("ErrorEntity", "ErrorId", typeof(System.Int64), true, false, false, false,  (int)ErrorFieldIndex.ErrorId, 0, 0, 19);
			this.AddElementFieldInfo("ErrorEntity", "Message", typeof(System.String), false, false, false, false,  (int)ErrorFieldIndex.Message, 2147483647, 0, 0);
			this.AddElementFieldInfo("ErrorEntity", "ParentErrorId", typeof(Nullable<System.Int64>), false, true, false, true,  (int)ErrorFieldIndex.ParentErrorId, 0, 0, 19);
			this.AddElementFieldInfo("ErrorEntity", "StackTrace", typeof(System.String), false, false, false, true,  (int)ErrorFieldIndex.StackTrace, 2147483647, 0, 0);
		}
		/// <summary>Inits RokEntity's FieldInfo objects</summary>
		private void InitRokEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RokFieldIndex), "RokEntity");
			this.AddElementFieldInfo("RokEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)RokFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("RokEntity", "Naziv", typeof(System.String), false, false, false, false,  (int)RokFieldIndex.Naziv, 50, 0, 0);
			this.AddElementFieldInfo("RokEntity", "RokId", typeof(System.Int64), true, false, false, false,  (int)RokFieldIndex.RokId, 0, 0, 19);
			this.AddElementFieldInfo("RokEntity", "RokTipId", typeof(System.Int64), false, true, false, false,  (int)RokFieldIndex.RokTipId, 0, 0, 19);
			this.AddElementFieldInfo("RokEntity", "Sifra", typeof(System.String), false, false, false, false,  (int)RokFieldIndex.Sifra, 50, 0, 0);
		}
		/// <summary>Inits RokTipRoEntity's FieldInfo objects</summary>
		private void InitRokTipRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RokTipRoFieldIndex), "RokTipRoEntity");
			this.AddElementFieldInfo("RokTipRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)RokTipRoFieldIndex.Code, 128, 0, 0);
			this.AddElementFieldInfo("RokTipRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)RokTipRoFieldIndex.Name, 256, 0, 0);
			this.AddElementFieldInfo("RokTipRoEntity", "RokTipId", typeof(System.Int64), true, false, false, false,  (int)RokTipRoFieldIndex.RokTipId, 0, 0, 19);
		}
		/// <summary>Inits RoleRoEntity's FieldInfo objects</summary>
		private void InitRoleRoEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(RoleRoFieldIndex), "RoleRoEntity");
			this.AddElementFieldInfo("RoleRoEntity", "Code", typeof(System.String), false, false, false, false,  (int)RoleRoFieldIndex.Code, 128, 0, 0);
			this.AddElementFieldInfo("RoleRoEntity", "Name", typeof(System.String), false, false, false, false,  (int)RoleRoFieldIndex.Name, 256, 0, 0);
			this.AddElementFieldInfo("RoleRoEntity", "RoleId", typeof(System.Int64), true, false, false, false,  (int)RoleRoFieldIndex.RoleId, 0, 0, 19);
		}
		/// <summary>Inits TrgovanjeGlavaEntity's FieldInfo objects</summary>
		private void InitTrgovanjeGlavaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TrgovanjeGlavaFieldIndex), "TrgovanjeGlavaEntity");
			this.AddElementFieldInfo("TrgovanjeGlavaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)TrgovanjeGlavaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("TrgovanjeGlavaEntity", "Datum", typeof(System.DateTime), false, false, false, false,  (int)TrgovanjeGlavaFieldIndex.Datum, 0, 0, 0);
			this.AddElementFieldInfo("TrgovanjeGlavaEntity", "Komentar", typeof(System.String), false, false, false, true,  (int)TrgovanjeGlavaFieldIndex.Komentar, 2147483647, 0, 0);
			this.AddElementFieldInfo("TrgovanjeGlavaEntity", "TrgovanjeGlavaId", typeof(System.Int64), true, false, false, false,  (int)TrgovanjeGlavaFieldIndex.TrgovanjeGlavaId, 0, 0, 19);
		}
		/// <summary>Inits TrgovanjeStavkaEntity's FieldInfo objects</summary>
		private void InitTrgovanjeStavkaEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(TrgovanjeStavkaFieldIndex), "TrgovanjeStavkaEntity");
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "Ponuda", typeof(System.Decimal), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.Ponuda, 0, 2, 18);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "PonudaDodatak", typeof(System.Decimal), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.PonudaDodatak, 0, 4, 10);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "Potraznja", typeof(System.Decimal), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.Potraznja, 0, 2, 18);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "PotraznjaDodatak", typeof(System.Decimal), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.PotraznjaDodatak, 0, 4, 10);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "Promet", typeof(System.Decimal), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.Promet, 0, 2, 18);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "PrometDodatak", typeof(System.Decimal), false, false, false, false,  (int)TrgovanjeStavkaFieldIndex.PrometDodatak, 0, 4, 10);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "RokId", typeof(System.Int64), false, true, false, false,  (int)TrgovanjeStavkaFieldIndex.RokId, 0, 0, 19);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "TrgovanjeGlavaId", typeof(System.Int64), false, true, false, false,  (int)TrgovanjeStavkaFieldIndex.TrgovanjeGlavaId, 0, 0, 19);
			this.AddElementFieldInfo("TrgovanjeStavkaEntity", "TrgovanjeStavkaId", typeof(System.Int64), true, false, false, false,  (int)TrgovanjeStavkaFieldIndex.TrgovanjeStavkaId, 0, 0, 19);
		}
		/// <summary>Inits UserEntity's FieldInfo objects</summary>
		private void InitUserEntityInfos()
		{
			this.AddFieldIndexEnumForElementName(typeof(UserFieldIndex), "UserEntity");
			this.AddElementFieldInfo("UserEntity", "ConcurrencyGuid", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.ConcurrencyGuid, 50, 0, 0);
			this.AddElementFieldInfo("UserEntity", "Password", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Password, 50, 0, 0);
			this.AddElementFieldInfo("UserEntity", "RoleId", typeof(System.Int64), false, true, false, false,  (int)UserFieldIndex.RoleId, 0, 0, 19);
			this.AddElementFieldInfo("UserEntity", "UserId", typeof(System.Int64), true, false, false, false,  (int)UserFieldIndex.UserId, 0, 0, 19);
			this.AddElementFieldInfo("UserEntity", "Username", typeof(System.String), false, false, false, false,  (int)UserFieldIndex.Username, 50, 0, 0);
		}
		
	}
}



