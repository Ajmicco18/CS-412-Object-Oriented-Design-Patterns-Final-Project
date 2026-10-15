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
    public class TableSUPPLIER :  CDBTable<SUPPLIER>
    {
        public TableSUPPLIER() { }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = CData.Instance.DB.Select<SUPPLIER>("select * from SUPPLIER");

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
                CData.Instance.DB.SaveChanges<SUPPLIER>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into SUPPLIER
                                  (
                                     ID
                                     ,SUPPLIER_CATEGORY_CID
	                                ,NAME
                                  )
                                  values
                                  (
                                     @ID
                                     ,@SUPPLIER_CATEGORY_CID
	                                ,@NAME
                                  )",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update SUPPLIER set
                                    ID                                   = @ID
                                    ,SUPPLIER_CATEGORY_CID               = @SUPPLIER_CATEGORY_CID
	                                ,NAME                                = @NAME
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from SUPPLIER where ID = @ID",

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
