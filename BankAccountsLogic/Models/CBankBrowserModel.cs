using BankAccounts.Logic.Visitors;
using DataApplication.Logic;
using Lib.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Logic.Entities;

namespace BankAccounts.Logic.Models
{
    public class CBankBrowserModel : List<CBank>
    { 
            // ....................................................................
            public IDBTable View = CDBTableFactory.Instance.CreateTable("BANK");
            // ....................................................................
            private Dictionary<string, Object> _criteria = new Dictionary<string, object>();
            public Dictionary<string, object> Criteria { get { return _criteria; } }
            // ....................................................................


            // --------------------------------------------------------------------------------------
            public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
            {
                this.Clear();
                p_oEntityLoader.Visit(this.View.RecordSet, this);
            }
            // --------------------------------------------------------------------------------------

        }
}
