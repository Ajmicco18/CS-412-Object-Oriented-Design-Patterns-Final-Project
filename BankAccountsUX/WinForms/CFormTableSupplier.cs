using BankAccounts.Logic.DataModules;
using BankAccounts.Logic.Entities;
using DataApplication.UX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.UX.WinForms
{
    public partial class CFormTableSupplier : CFormTemplateTable
    {
        private CDMSupplierList module;
        public CFormTableSupplier():base()
        {
            InitializeComponent();
            this.module = new CDMSupplierList();
        }

        protected override void DisplayModelEntitiesOnGrid()
        {
            editableGridRecords.Populate<CSupplier>(this.module.Model);
        }
        // --------------------------------------------------------------------------------------
        protected override bool IsModuleLoaded()
        {
            return this.module.IsLoaded;
        }
        // --------------------------------------------------------------------------------------
        protected override bool LoadModule()
        {
            return this.module.ModuleLoad();
        }
        // --------------------------------------------------------------------------------------
        protected override bool SaveModule()
        {
            return this.module.ModuleSave();
        }
        // --------------------------------------------------------------------------------------
        protected override string LastErrorMessage()
        {
            return this.module.LastError;
        }
    }
}
