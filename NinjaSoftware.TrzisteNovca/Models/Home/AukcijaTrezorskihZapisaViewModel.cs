using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using NinjaSoftware.TrzisteNovca.Common;
using NinjaSoftware.TrzisteNovca.CoolJ.EntityClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.TrzisteNovca.Models.Home
{
    public class AukcijaTrezorskihZapisaViewModel
    {
        public AukcijaTrezorskihZapisaViewModel(DataAccessAdapterBase adapter, string baseDirectory)
        {
            this.AukcijaDateDictionary = new Dictionary<DateTime, string>();

            DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(baseDirectory, Config.AukcijaTrezorskihZapisaFolderPath()));
            foreach (FileInfo fileInfo in directoryInfo.EnumerateFiles())
            {
                try
                {
                    string[] fileParts = fileInfo.Name.Split('_');
                    int year = Convert.ToInt32(fileParts[3].Replace(".xls", ""));
                    int month = Convert.ToInt32(fileParts[2]);
                    int day = Convert.ToInt32(fileParts[1]);

                    DateTime date = new DateTime(year, month, day);

                    this.AukcijaDateDictionary.Add(date, fileInfo.Name);
                }
                catch (Exception ex)
                {
                    ErrorEntity.LogException(adapter, ex);
                }
            }

            this.AukcijaDateDictionary = this.AukcijaDateDictionary.
                OrderByDescending(ad => ad.Key).
                ToDictionary(ad => ad.Key, ad => ad.Value);
        }

        public Dictionary<DateTime, string> AukcijaDateDictionary { get; set; }
    }
}