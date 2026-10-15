using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Data.DB;
using Lib.Common.Attribs;
using System.ComponentModel.DataAnnotations;

namespace BankAccounts.Data.Records
{
    public class BANK: CDBRecord
    {
        [Key]  //.NET: Example of declaring a field as primary key, using the Key attribute
        public int ID { get; set; }
        public int? COUNTRY_CID{ get; set; }
        public string? BANK_NAME { get; set; }
        public string? SWIFT_CODE { get; set; }
        public string? ACCOUNT_NUM { get; set; }

        public string? ROUTING_NUM { get; set;}
    }
}
