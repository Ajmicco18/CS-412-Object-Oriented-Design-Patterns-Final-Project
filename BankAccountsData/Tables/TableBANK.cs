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
    public class TableBANK: CDBTable<BANK>
    {
        public TableBANK() { }

        public override void LoadRecord(int p_nKeyValue)
        {
            this.records.Clear(); // Empty the existing records

            // We create an object to hold the ID parameter for the select statement
            BANK? oParams = new BANK();
            oParams.ID = p_nKeyValue;


            using (var iTransaction = CData.Instance.DB.BeginTransaction())
            {
                try
                {
                    var oRecords = CData.Instance.DB.SelectWithParams<BANK>(
                            "select * from BANK where ID = @ID", oParams, iTransaction);
                    iTransaction.Commit();

                    // When a select returns no records a null object might be returned by the method
                    if (oRecords != null)
                    {
                        this.records = oRecords;

                        foreach (var oRecord in this.records)
                            Debug.WriteLine(oRecord.ToString());
                    }
                }
                catch
                {
                    iTransaction.Rollback();
                    throw;
                }
            }
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            this.records.Clear(); // Empty the existing records

            var oRecords = CData.Instance.DB.Select<BANK>("select * from BANK", p_iTransaction);

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                
               CData.Instance.DB.SaveChanges<BANK>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"  insert into BANK
                                (
                                   COUNTRY_CID
                                  ,BANK_NAME	
                                  ,SWIFT_CODE	
                                  ,ACCOUNT_NUM
                                  ,ROUTING_NUM
                                )
                                values
                                (
                                     @COUNTRY_CID				
                                    ,@BANK_NAME	
                                    ,@SWIFT_CODE	
                                    ,@ACCOUNT_NUM
                                    ,@ROUTING_NUM
                                )",

                            // Provide the update statement that will be used for updated records
                            @"
                            update BANK set
                                COUNTRY_CID                = @COUNTRY_CID
                                ,BANK_NAME                = @BANK_NAME	
                                ,SWIFT_CODE               = @SWIFT_CODE	
                                ,ACCOUNT_NUM              = @ACCOUNT_NUM
                                ,ROUTING_NUM              = @ROUTING_NUM
                            where
                                ID = @ID",

                            // Provide the delete statement that will be used for deleted records
                            @"delete from BANK where ID = @ID",

                            p_iTransaction
                        );

                // We reload the table to reflect all the changes that have been saved in the DB
                // With this we secure that fields altered by DB triggers are properly loaded
                this.LoadTable(p_iTransaction);
            }
        }
    }
}
