using Lib.Data.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Data.Records
{
    public class COUNTRY : CDBRecord
    {
        [Key]
        public int CID { get; set; }

        [DisplayName("Country")]
        public string NAME { get; set; }
    }
}
