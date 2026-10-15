using BankAccounts.Logic.Entities;
using DataApplication;
using DataApplication.Logic;
using BankAccounts.Logic.Visitors;
using Lib.Common.Interfaces;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Logic.Models
{
    public class CBankModel : List<CBank>, IMasterDetailModel
    {
        public IDBTable MasterTable = CDBTableFactory.Instance.CreateTable("BANK");
        public IDBTable DetailTable = CDBTableFactory.Instance.CreateTable("BANK_ACCOUNT");

        public CBank           Master
        {
            get
            {
                if (this.Count == 0)
                    return null;
                else
                    return this[0];
            }
        }
        // ....................................................................
        public List<CBankAccount> Details = new List<CBankAccount>();
        // ....................................................................

        // --------------------------------------------------------------------------------------
        public CBankModel()
        {
        }

        #region
        public IEntity NewMasterDetail()
        {
            this.Clear();
            this.MasterTable?.RecordSet.Clear();

            this.Details.Clear();
            this.DetailTable?.RecordSet.Clear();

            CBank oNewMasterEntity = new CBank();
            oNewMasterEntity.Change = EntityChangeType.CREATED;
            this.Add(oNewMasterEntity);
            this.Details.Clear();

            return oNewMasterEntity;
        }

        public void LoadMasterDetail(int p_nMasterKeyValue)
        {
            this.MasterTable.LoadRecord(p_nMasterKeyValue);
            this.DetailTable.LoadTable(null, p_nMasterKeyValue);
        }

        public int SaveMasterDetail()
        {
            int nMasterID;
            using (IDbTransaction iTransaction = CData.Instance.DB.BeginTransaction())
            {
                try
                {

                    if (this.Master.Change != EntityChangeType.DELETED)
                     this.MasterTable?.SaveTable(iTransaction);          // First insert the master.
                    nMasterID = this.Master.Id;
                    // Get the ID of the master and copy to the foreign key in the details.
                    foreach (var oDetail in this.Details)
                        oDetail.BankID = nMasterID;
                    this.DetailTable?.SaveTable(iTransaction);        // Then insert/update the details.
                    if (this.Master.Change == EntityChangeType.DELETED)
                        this.MasterTable?.SaveTable(iTransaction);          // First insert the master.
                    iTransaction.Commit();
                }
                catch
                {
                    iTransaction.Rollback();
                    throw;
                }
            }
            return nMasterID;
        }
    
        public void DeleteMasterDetail()
        {
            this.Master.Change = EntityChangeType.DELETED;
            foreach (var oDetail in this.Details)
                oDetail.Change = EntityChangeType.DELETED;
            SaveMasterDetail();
        }

        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            p_oEntityLoader.Visit(this.MasterTable.RecordSet, this);
            this.Details.Clear();
            p_oEntityLoader.Visit(this.DetailTable.RecordSet, this.Details);
        }
        // --------------------------------------------------------------------------------------
        // Synchronizes the table records with the entities in the model, by adding new records
        // if they are not already added
        public void AcceptVisitBeforeSave(IVisitorToModel p_oRecordAdder)
        {
            p_oRecordAdder.Visit(this.MasterTable.RecordSet, this);
            p_oRecordAdder.Visit(this.DetailTable.RecordSet, this.Details);
        }
        #endregion
    }
}
