﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 2024. 06. 15. 13:54:28
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace enTelefonkony
{
    public partial class enHelyseg {

        public enHelyseg()
        {
            this.enSzemlyek = new List<enSzemly>();
            OnCreated();
        }

        public int id { get; set; }

        public string IRSZ { get; set; }

        public string nev { get; set; }

        public virtual IList<enSzemly> enSzemlyek { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        #endregion
    }

}
