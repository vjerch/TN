using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NinjaSoftware.TrzisteNovca.CoolJ.DatabaseGeneric.BusinessLogic
{
    public enum AuditInfoActionTypeEnum
    {
        Insert = 1,
        Update = 2,
        Delete = 3
    }

    public enum EntityEnum
    {
        AuditInfo = 1,
        TrgovanjeGlava = 3,
        TrgovanjeStavka = 4,
        User = 5,
        RepoAukcija = 6
    }

    public enum RoleEnum
    {
        Admin = 1,
        User = 2
    }

    public enum ValutaEnum
    { 
        Kn = 1,
        Chf = 2,
        Eur = 3,
        Usd = 4
    }

    public enum TrgovanjeVrstaEnum
    { 
        Opoziv = 1,
        TomNext = 2,
        SpotNext = 3,
        RocniDepozit = 4,
        JedanTjedan = 5,
        DvaTjedna = 6,
        JedanMjesec = 7,
        TriMjeseca = 8,
        ViseOdTriMjeseca = 9,
        Prekonocni = 10
    }

    public enum SudionikGrupa
    {
        Dionicari = 1,
        KorisneAdrese = 2,
        Banke = 3,
        InvesticijskiFondovi = 4,
        MirovinskiFondovi = 5,
        OsiguravajucaDrustva = 6,
        StambeneStedionice = 7
    }
}
