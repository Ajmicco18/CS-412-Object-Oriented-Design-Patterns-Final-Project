using BankAccounts.Data.Records;
using Lib.Common.Attribs;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Logic.Entities
{
    public class CSupplier: CEntity<SUPPLIER>
    {
        [Key]
        [ColumnWidth(30)]
        public int ID
        {
            get { return this.Record.ID; }
            set { this.Record.ID = value; }
        }

        [DisplayName("Supplier Category ID")]
        public int SupplierCategoryCodeID
        {
            get { return this.Record.SUPPLIER_CATEGORY_CID; }
            set { this.Record.SUPPLIER_CATEGORY_CID = value; }
        }

        [DisplayName("Supplier")]   //.NET: Example of declaring the description of a field.
        public string? Name
        {
            get { return this.Record.NAME; }
            set
            {
                if (value == null)
                    throw new Exception("The supplier should have a name");
                else
                    this.Record.NAME = value;
            }
        }

        public CSupplier() : base() { }
    }
}
