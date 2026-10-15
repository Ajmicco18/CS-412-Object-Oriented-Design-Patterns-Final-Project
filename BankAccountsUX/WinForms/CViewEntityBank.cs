using BankAccounts.Logic.DataModules;
using BankAccounts.Logic.Entities;
using DataApplication.UX;
using Lib.Logic;
using Lib.UX.DataForms;
using Lib.UX.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccounts.UX.WinForms
{
    public partial class CViewEntityBank : Form, IEntityViewForm
    {
        protected CDMBank module { get; set; }
        protected CEditableGridDecorator detailsGrid;
        protected DataGridViewComboBoxColumn? cbcSupplier = null;
        public CViewEntityBank()
        {
            InitializeComponent();
        }

        public void SetParent(Form p_oForm)
        {
            CFormTemplateMaster oMasterForm = (CFormTemplateMaster)p_oForm;

            this.detailsGrid = new CEditableGridDecorator(this.dgvDetails, oMasterForm.FormContext);
            oMasterForm.DetailGrids.Add(this.detailsGrid);

            this.module = (CDMBank)oMasterForm.Module;
        }

        public void WriteMasterToUI()
        {
            CBank oCurrentUser = this.module.BankModel.Master;

            this.txtBankName.Text = oCurrentUser.BankName;
            this.txtRoutNumber.Text = oCurrentUser.RoutingNumber;
            this.txtSwiftCode.Text = oCurrentUser.SwiftCode;
            this.txtAccountNum.Text = oCurrentUser.AccountNumber;

            this.displayCountryLookup(oCurrentUser);
        }

        public void ReadMasterFromUI()
        {
            CBank oCurrentUser = this.module.BankModel.Master;

            oCurrentUser.BankName = this.txtBankName.Text;
            oCurrentUser.RoutingNumber = this.txtRoutNumber.Text;
            oCurrentUser.SwiftCode = this.txtSwiftCode.Text;
            oCurrentUser.AccountNumber = this.txtAccountNum.Text;

            oCurrentUser.CountryCodeID = -1;
            if (this.cbCountry.SelectedItem != null)
            {
                CCountry oSelectedCountry = (CCountry)this.cbCountry.SelectedItem;
                oCurrentUser.CountryCodeID = oSelectedCountry.CodeId;
            }

            oCurrentUser.Change = EntityChangeType.UPDATED;
        }

        public void WriteDetailListToUI()
        {
            this.detailsGrid.Populate<CBankAccount>(this.module.BankModel.Details);

            this.addLookupComboBoxOnDetailList();
        }

        private void displayCountryLookup(CBank p_oCurrentBank)
        {
            // Loads all the options
            this.cbCountry.ValueMember = "CodeID";
            this.cbCountry.DisplayMember = "Name";
            this.cbCountry.Items.Clear();
            foreach (CCountry oCountry in this.module.MasterLookup)
                this.cbCountry.Items.Add(oCountry);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentBank.LookupCountry(this.module.MasterLookup);

            this.cbCountry.SelectedItem = p_oCurrentBank.Country;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cbCountry.Text = p_oCurrentBank.Country?.Name ?? "No name";
        }

        protected void addLookupComboBoxOnDetailList()
        {
            //PATTERNS: Lazy Initialization. In this case we will create the column when it is first needed
            //          and prevent for adding it each time we load/create a new master entity
            DataGridViewColumn? oFoundColumn = null;
            int nIndex = 0;
            foreach (DataGridViewColumn oColumn in this.dgvDetails.Columns)
            {
                if (oColumn.DataPropertyName == "SupplierName")
                {
                    oFoundColumn = oColumn;
                    break;
                }
                nIndex++;
            }

            if (oFoundColumn != null)
                oFoundColumn.Visible = false;



            this.cbcSupplier = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Supplier Name",
                Width = 200,

                ValueMember = "ID",              // The key field of the lookup entity
                DisplayMember = "Name",          // The field that will used for displaying a lookup entity

                DataPropertyName = "SupplierId",    // The foreign key field on the detail entity that will receive the selected value

                FlatStyle = FlatStyle.Popup,
            };

            if (oFoundColumn == null)
                this.dgvDetails.Columns.Add(cbcSupplier);
            else
                this.dgvDetails.Columns.Insert(nIndex, cbcSupplier);


            // (Re)loads all the options
            this.cbcSupplier.DataSource = null;
            this.cbcSupplier.DataSource = this.module.DetailLookup;
        }


        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == btnNewDetail)
                this.detailsGrid.CreateRow<CBankAccount>(new CBankAccount());
            else if (sender == btnDeleteDetail)
                this.detailsGrid.DeleteRow();
        }
    }
}
