using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Configuration;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;

namespace NinjaSoftware.TrzisteNovca.Models
{
    public static class Helper
    {
        public static DataAccessAdapterBase GetDataAccessAdapterFactory()
        {
            DataAccessAdapterBase adapter;
            switch (ConfigurationManager.ConnectionStrings[1].ProviderName)
            {
                case "System.Data.SqlClient":
                    adapter = new NinjaSoftware.TrzisteNovca.CoolJ.DatabaseSpecific.DataAccessAdapter();
                    break;
                default:
                    throw new Exception("Unsupported provider.");
            }

            return adapter;
        }

        public static DataAccessAdapterBase GetDataAccessAdapterFactory(string userName)
        {
            DataAccessAdapterBase adapter = GetDataAccessAdapterFactory();

            ((INsDataAccessAdapter)adapter).UserId = UserEntity.FetchUser(userName, null, adapter).UserId;

            return adapter;
        }
    }
}