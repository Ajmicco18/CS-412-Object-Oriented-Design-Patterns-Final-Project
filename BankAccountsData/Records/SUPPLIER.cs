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
    public class SUPPLIER : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public int SUPPLIER_CATEGORY_CID { get; set; }

        [DisplayName("Supplier")]
        public string NAME {  get; set; }
    }
}
