using BankAccounts.Data.Records;
using Lib.Common.Attribs;
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
    public class CBank:CEntity<BANK>
    {
        [Key]

        public int Id
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }

        public int CountryCodeID
        {
            get { return this.Record.COUNTRY_CID ?? -1; }
            set
            {
                if (value == -1)
                    this.Record.COUNTRY_CID = null;
                else
                    this.Record.COUNTRY_CID = value;
                InvokePropertyChanged(nameof(CountryCodeID));
            }
        }

        public void LookupCountry(List<CCountry> p_oCountry)
        {
            var oFound = p_oCountry.Where(x => x.CodeId == this.CountryCodeID).ToList();
            if (oFound.Count > 0)
                this.Country = oFound[0];
            else
                this.Country = null;
        }

        [Browsable(false)]
        public CCountry? Country { get; set; } = null;
        public string CountryName
        {
            get
            {
                if (this.Country == null)
                    return "";
                else
                    return this.Country.Name ?? "";
            }
        }

        public string BankName
        {
            get { return this.Record.BANK_NAME; }
            set { this.Record.BANK_NAME = value; }
        }

        public string SwiftCode
        {
            get { return this.Record.SWIFT_CODE; }
            set { this.Record.SWIFT_CODE = value; }
        }

        public string AccountNumber
        {
            get { return this.Record.ACCOUNT_NUM; }
            set { this.Record.ACCOUNT_NUM = value; }
        }

        public string RoutingNumber
        {
            get { return this.Record.ROUTING_NUM; }
            set { this.Record.ROUTING_NUM = value; }
        }
        public CBank() : base() { }


    }
}
