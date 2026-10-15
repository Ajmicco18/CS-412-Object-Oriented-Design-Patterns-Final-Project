using BankAccounts.Data.Records;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Logic.Entities
{
    public class CBankAccount : CEntity<BANK_ACCOUNT>
    {
        [Key]

        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }

        public int SupplierID
        {
            get { return this.Record.SUPPLIER_ID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.SUPPLIER_ID = null;
                else
                    this.Record.SUPPLIER_ID = value;
                InvokePropertyChanged(nameof(SupplierID));
            }
        }

        public void LookupSupplier(List<CSupplier> p_oSupplier)
        {
            var oFound = p_oSupplier.Where(x => x.ID == this.SupplierID).ToList();
            if (oFound.Count > 0)
                this.Supplier = oFound[0];
            else
                this.Supplier = null;
        }

        [Browsable(false)]
        public CSupplier? Supplier { get; set; } = null;
        public string IBAN
        {
            get { return this.Record.IBAN; }
            set { this.Record.IBAN = value; }
        }

        public int BankID
        {
            get { return this.Record.BANK_ID; }
            set { this.Record.BANK_ID = value; }
        }

        public string Beneficiary
        {
            get { return this.Record.BENEFICIARY; }
            set { this.Record.BENEFICIARY = value; }
        }

        public int AmountDue {
            get { return this.Record.AMOUNT_DUE; }
            set { this.Record.AMOUNT_DUE = value; }
        }

        public string AccountType
        {
            get { return this.Record.ACCOUNT_TYPE; }
            set { this.Record.ACCOUNT_TYPE = value; }
        }

        
    }
}
