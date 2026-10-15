using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.ComponentModel;

using BankAccounts.Data.Records;
using BankAccounts.Logic.Entities;


namespace BankAccounts.Logic.Visitors
{
    public class CVisitorEntityLoader: IVisitorToModel
    {
        public PropertyChangedEventHandler? EntityChangeHandler { get; set; } = null;

        #region // IVisitorToModel \\
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CBank> p_oEntityList)
        {
            foreach(BANK oRecord in p_oRecordSet)
            {
                CBank oEntity = new CBank();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CBankAccount> p_oEntityList)
        {
            foreach(BANK_ACCOUNT oRecord in p_oRecordSet)
            {
                CBankAccount oEntity = new CBankAccount();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                oEntity.BankID = oEntity.BankID;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CCountry> p_oEntityList)
        {
            foreach (COUNTRY oRecord in p_oRecordSet)
            {
                CCountry oEntity = new CCountry();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        public void Visit(IList p_oRecordSet, List<CSupplier> p_oEntityList)
        {
            foreach (SUPPLIER oRecord in p_oRecordSet)
            {
                CSupplier oEntity = new CSupplier();
                oEntity.Record = oRecord;
                oEntity.OnPropertyChange += EntityChangeHandler;
                p_oEntityList.Add(oEntity);
            }
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
