using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using BankAccounts.Logic.Entities;
using BankAccounts.Logic.Models;
using DataApplication.Logic;
using Lib.Common.Interfaces;
using Lib.Logic;

namespace BankAccounts.Logic.DataModules
{
    public class CDMBank : CDataModule, IDataModule
    {
        // ....................................................................
        public IMasterDetailModel Model { get { return (IMasterDetailModel)this.model; } }
        // ....................................................................
        public CBankModel BankModel { get { return (CBankModel)this.model; } }
        // ....................................................................
        public CBankBrowserModel BrowserModel;
        // ....................................................................

        private CCountryListModel _masterLookup;
        public CCountryListModel MasterLookup { get { return this._masterLookup; } }
        // ....................................................................

        public CSupplierListModel _detailLookup;
        public CSupplierListModel DetailLookup { get { return this._detailLookup; } }

        public CDMBank() : base()
        {
            this.model = new CBankModel();
            this.BrowserModel = new CBankBrowserModel();
            this._masterLookup = new CCountryListModel(true);
            this._detailLookup = new CSupplierListModel(true);
        }
        public int MasterKeyValue { get; set; }

        #region
        public bool ModuleDelete()
        {
            bool bResult = false;
            try
            {
                Model.DeleteMasterDetail();
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }

        public bool ModuleLoad()
        {
            bool bResult = false;
            try
            {
                Model.LoadMasterDetail(this.MasterKeyValue);
                this.entityLoader.EntityChangeHandler = ModuleOnAnyEntityChange;
                BankModel.AcceptVisitAfterLoad(this.entityLoader);
                this.IsLoaded = true;
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult; 
        }

        public bool ModuleLoadBrowser()
        {
            bool bResult = false;
            try
            {
                BrowserModel.View.LoadTable(null);
                BrowserModel.AcceptVisitAfterLoad(this.entityLoader);
                this.IsLoaded = true;
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }

        public bool ModuleLoadLookups()
        {
            bool bResult = false;
            try
            {
                _masterLookup.Table.LoadTable(null);
                _masterLookup.AcceptVisitAfterLoad(this.entityLoader);

                _detailLookup.Table.LoadTable(null);
                _detailLookup.AcceptVisitAfterLoad(this.entityLoader);

                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }

        public bool ModuleNew()
        {
            IEntity iEntity = Model.NewMasterDetail();
            iEntity.OnPropertyChange += ModuleOnAnyEntityChange;
            return true;
        }

        public void ModuleOnAnyEntityChange(object? sender, PropertyChangedEventArgs e)
        {
            if (sender != null)
            {
                Debug.WriteLine($"Property {e.PropertyName} has changed on a :{sender.GetType().Name} entity.");

                if (sender is CBank)
                    ((CBank)sender).LookupCountry(this._masterLookup);
                else if (sender is CBankAccount)
                    ((CBankAccount)sender).LookupSupplier(this._detailLookup);
            }
        }

        public bool ModuleSave()
        {
            bool bResult = false;
            try
            {
                BankModel.AcceptVisitBeforeSave(this.recordAdder); // Custom code for CAppUserModel
                this.MasterKeyValue = Model.SaveMasterDetail();
                bResult = true;
            }
            catch (Exception oException)
            {
                this.LastError = oException.Message;
            }
            return bResult;
        }
        #endregion
    }
}
