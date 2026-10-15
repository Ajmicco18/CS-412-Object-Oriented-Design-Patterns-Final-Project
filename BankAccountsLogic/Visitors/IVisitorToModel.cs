using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Logic.Entities;
using BankAccounts.Data.Records;

using Lib.Data.DB;
using Lib.Logic;

namespace BankAccounts.Logic.Visitors
{
    public interface IVisitorToModel
    {
        public void Visit(IList p_oRecordSet, List<CBank> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CBankAccount> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CCountry> p_oEntityList);
        public void Visit(IList p_oRecordSet, List<CSupplier> p_oEntityList);

    }
}
