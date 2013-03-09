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
        Rok = 2,
        TrgovanjeGlava = 3,
        TrgovanjeStavka = 4,
        User = 5
    }

    public enum RoleEnum
    {
        Admin = 1,
        User = 2
    }
}
