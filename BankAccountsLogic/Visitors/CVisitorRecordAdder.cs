using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lib.Logic;
using BankAccounts.Logic.Entities;

namespace BankAccounts.Logic.Visitors
{
    public class CVisitorRecordAdder: IVisitorToModel
    {

        #region // IVisitorToModel \\
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CBank> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CBankAccount> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CCountry> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CSupplier> p_oEntityList)
        {
            foreach (var oEntity in p_oEntityList)
            {
                if (oEntity.Change == EntityChangeType.CREATED)
                {
                    if (p_oRecordSet.IndexOf(oEntity.Record) == -1)
                        p_oRecordSet.Add(oEntity.Record);
                }
            }
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
