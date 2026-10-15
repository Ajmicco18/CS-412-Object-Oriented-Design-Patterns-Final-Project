using Lib.Data.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Data.Records
{
    public class BANK_ACCOUNT : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public int? SUPPLIER_ID {  get; set; }

        public string IBAN {  get; set; }

        public int BANK_ID {  get; set; }

        public string BENEFICIARY { get; set; }

        public int AMOUNT_DUE { get; set; }

        public string ACCOUNT_TYPE {  get; set; }
    }
}
