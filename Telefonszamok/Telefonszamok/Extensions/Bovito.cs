using enTelefonkony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefonszamok.Extensions
{
    public static class Bovito
    {
        public static string Telefonszamok(this enSzemly enSzemely)
        {
            var s = ""; 
            foreach (var x in enSzemely.enTelefonszamok)
            {
                s = s + x.szam; if (x != enSzemely.enTelefonszamok.Last()) s = s + ", ";
            }
            return s;
        }
    }
}
