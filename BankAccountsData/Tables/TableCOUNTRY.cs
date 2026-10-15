using BankAccounts.Data.Records;
using DataApplication;
using Lib.Data.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts.Data.Tables
{
    public class TableCOUNTRY : CDBTable<COUNTRY>
    {
        public TableCOUNTRY() { }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = CData.Instance.DB.Select<COUNTRY>("select * from COUNTRY");

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                CData.Instance.DB.SaveChanges<COUNTRY>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into COUNTRY
                                  (
                                     CID
	                                ,NAME
                                  )
                                  values
                                  (
                                     @CID
	                                ,@NAME
                                  )",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update COUNTRY set
                                     CID                = @CID
	                                ,NAME              = @NAME
                                  where 
                                    CID = @CID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from COUNTRY where CID = @CID",

                            p_iTransaction
                        );

                // We reload the table to reflect all the changes that have been saved in the DB
                // With this we secure that fields altered by DB triggers are properly loaded
                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
