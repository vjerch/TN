using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SD.LLBLGen.Pro.ORMSupportClasses;
using System.Configuration;
using NinjaSoftware.Api.CoolJ;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using System.Text;

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

        #region HTML helpers

        private static string[] _whiteListTokens = { "<b>", "</b>",
                                                       "<i>", "</i>",
                                                       "<u>", "</u>",
                                                       "<strike>", "</strike>",
                                                       "<sub>", "</sub>",
                                                       "<sup>", "</sup>",
                                                       "<p>", "</p>",
                                                       "<strong>", "</strong>",
                                                       "<em>", "</em>",
                                                       "<br />",
                                                       "<br/>",
                                                       "<div>", "</div>"
                                                     };

        private static string[] _whiteListTokensUnclosed = { "<b",
                                                       "<i",
                                                       "<u",
                                                       "<strike",
                                                       "<sub",
                                                       "<sup",
                                                       "<p",
                                                       "<strong",
                                                       "<em",
                                                       "<div"
                                                     };

        /// <summary>
        /// Ako token iz white liste ima nešto dodano (font i sl.) miče taj dodatak.
        /// Ako token nije na white listi miče ga iz stringa.
        /// </summary>
        public static string SanitazeHtml(string html)
        {
            StringBuilder bob = new StringBuilder(html);

            int tokenStartIndex = 0;
            int tokenEndIndex = 0;

            while (tokenEndIndex < bob.Length && tokenStartIndex != -1)
            {
                tokenStartIndex = bob.ToString().IndexOf('<', tokenEndIndex);

                if (-1 != tokenStartIndex)
                {
                    tokenEndIndex = bob.ToString().IndexOf('>', tokenStartIndex);

                    string token = bob.ToString(tokenStartIndex, tokenEndIndex - tokenStartIndex + 1);

                    if (!_whiteListTokens.Contains(token.ToLower()))
                    {
                        if (token.Contains("<span"))
                        {
                            bob.Replace(token, "<div>", tokenStartIndex, tokenEndIndex - tokenStartIndex + 1);
                            tokenEndIndex = tokenStartIndex + "<div>".Length;
                        }
                        else if ("</span>" == token)
                        {
                            bob.Replace(token, "</div>", tokenStartIndex, tokenEndIndex - tokenStartIndex + 1);
                            tokenEndIndex = tokenStartIndex + "</div>".Length;
                        }
                        else
                        {
                            bool isTokenSanitazed = false;

                            foreach (string tokenUnclosed in _whiteListTokensUnclosed)
                            {
                                if (token.Contains(tokenUnclosed))
                                {
                                    bob.Replace(token, tokenUnclosed + ">", tokenStartIndex, tokenEndIndex - tokenStartIndex + 1);
                                    tokenEndIndex = tokenStartIndex + tokenUnclosed.Length;
                                    isTokenSanitazed = true;
                                    break;
                                }
                            }

                            if (!isTokenSanitazed)
                            {
                                bob.Remove(tokenStartIndex, tokenEndIndex - tokenStartIndex + 1);
                                tokenEndIndex = tokenStartIndex;
                            }
                        }
                    }
                }
            }

            return bob.ToString();
        }

        /// <summary>
        /// Vraća false ako prosljeđeni html sadrži nedozvoljeni tag.
        /// Dozvoljeni tagovi su b, i, u, strike, sub, sup, p, strong, em, br i div.
        /// </summary>
        public static bool IsSafeHtml(string html)
        {
            int pozicija = 0;

            while (pozicija < html.Length)
            {
                char c = html[pozicija];

                if ('<' == c)
                {
                    int krajTokena = html.IndexOf('>', pozicija);

                    if (krajTokena < 1)
                    {
                        return false;
                    }

                    string token = html.Substring(pozicija, krajTokena - pozicija + 1);

                    if (!_whiteListTokens.Contains(token.ToLower()))
                    {
                        return false;
                    }

                    pozicija = krajTokena;
                }
                else
                {
                    pozicija++;
                }
            }

            return true;
        }

        #endregion HTML helpers
    }
}