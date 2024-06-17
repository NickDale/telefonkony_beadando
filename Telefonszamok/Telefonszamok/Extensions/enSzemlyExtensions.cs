using enTelefonkony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enTelefonkony { 

    public partial class enSzemly
    {
        public string Telefonszamok
        {
            get
            {
                var s = "";
                foreach (var x in enTelefonszamok)
                {
                    s += x.szam;
                    if (x != enTelefonszamok.Last())
                    {
                        s += ", ";
                    }
                }
                return s;
            }
        }
    }
}
