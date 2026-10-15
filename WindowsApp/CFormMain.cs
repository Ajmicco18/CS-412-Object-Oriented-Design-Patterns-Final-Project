using BankAccounts.Logic.DataModules;
using BankAccounts.Logic.Entities;
using BankAccounts.UX.WinForms;
using DataApplication.UX;

namespace WindowsApp
{
    public partial class CFormMain : Form
    {
        public CFormTableCountry? FormTableCountry = null;
        public CFormTableSupplier? FormTableSupplier = null;
        public CFormMain()
        {
            InitializeComponent();
        }

        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == mnuBanksAndBankAccts)
            {
                // Create some objects that will be given to the form (aggregation relationship).
                CDMBank oModule = new CDMBank();
                CViewBrowserDefault<CBank> oBrowserView = new CViewBrowserDefault<CBank>(oModule.BrowserModel);
                CViewEntityBank oEntityView = new CViewEntityBank();

                // [C#] This creates a new MDI child in the MDI main form
                CFormTemplateMaster oMasterForm = new CFormTemplateMaster(oModule, oBrowserView, oEntityView);
                oMasterForm.MdiParent = this;
                oMasterForm.Show();
            }
            else if (sender == mnuCountries)
            {
                //[C#] This shows a modal form, i.e. freezing all other forms.
                if (FormTableCountry == null)
                    FormTableCountry = new CFormTableCountry();
                FormTableCountry?.ShowDialog();
            }
            else if (sender == mnuSuppliers)
            {
                if(FormTableSupplier == null)
                    FormTableSupplier = new CFormTableSupplier();
                FormTableSupplier?.ShowDialog();
                /*CFormTableSupplier oFormTableSupplier = new CFormTableSupplier();
                oFormTableSupplier.MdiParent = this;
                oFormTableSupplier?.Show();*/
            }
        }
    }
}
