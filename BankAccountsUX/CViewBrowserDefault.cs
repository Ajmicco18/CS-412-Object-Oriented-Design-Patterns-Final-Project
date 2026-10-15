using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccounts.Logic.DataModules;
using BankAccounts.Logic.Entities;
using Lib.UX.DataForms;
using Lib.UX.DataGrid;


namespace DataApplication.UX
{
    public class CViewBrowserDefault<T> : IBrowserViewForm
    {
        private CFormTemplateMaster? _parent = null;
        private List<T> browserModel;

        public CViewBrowserDefault(List<T> p_oBrowserModel)
        {
            this.browserModel = p_oBrowserModel;
        }

        public void SetParent(Form p_oForm)
        {
            _parent = (CFormTemplateMaster)p_oForm;
        }

        public void WriteBrowserListToTheUI()
        {
            _parent?.BrowserGrid.Populate<T>(browserModel);
        }
    }
}
