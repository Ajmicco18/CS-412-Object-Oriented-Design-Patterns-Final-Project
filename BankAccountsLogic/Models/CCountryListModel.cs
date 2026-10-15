using BankAccounts.Logic.Entities;
using BankAccounts.Logic.Visitors;
using DataApplication.Logic;
using Lib.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Logic.Models
{
    public class CCountryListModel :List<CCountry>
    {
        public IDBTable Table = CDBTableFactory.Instance.CreateTable("COUNTRY");

        private bool _isLookup = false;

        // --------------------------------------------------------------------------------------
        public CCountryListModel(bool p_bIsLookup)
        {
            _isLookup = p_bIsLookup;
        }
        // --------------------------------------------------------------------------------------
        public void AcceptVisitAfterLoad(IVisitorToModel p_oEntityLoader)
        {
            this.Clear();
            if (_isLookup)
                this.Add(new CCountry() { CodeId = -1, Name = "" });  //Lookup entry for null key value
            p_oEntityLoader.Visit(this.Table.RecordSet, this);

        }
        // --------------------------------------------------------------------------------------
        // Synchronizes the table records with the entries in the model, by adding any 
        // missing records to the list Records.
        public void AcceptVisitBeforeSave(IVisitorToModel p_oRecordAdder)
        {
            p_oRecordAdder.Visit(this.Table.RecordSet, this);
        }
    }
}
