using Lib.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lib.Common.Attribs;
using BankAccounts.Data.Records;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BankAccounts.Logic.Entities
{
    public class CCountry : CEntity<COUNTRY>
    {
        [Key]
        [ColumnWidth(30)]
        public int CodeId
        {
            get { return this.Record.CID; }
            set { this.Record.CID = value; }
        }

        [DisplayName("Country")]   //.NET: Example of declaring the description of a field.
        public string? Name
        {
            get { return this.Record.NAME; }
            set
            {
                if (value == null)
                    throw new Exception("The country should have a name");
                else
                    this.Record.NAME = value;
            }
        }

        public CCountry(): base() { }
    }
}
