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
    public class TableBANK_ACCOUNT : CDBTable<BANK_ACCOUNT>
    {
        public int MasterID { get; set; }
        public TableBANK_ACCOUNT() { }

        public override void LoadTable(IDbTransaction? p_iTransaction, int p_nMasterKeyValue)
        {
            this.MasterID = p_nMasterKeyValue;
            this.LoadTable(p_iTransaction);
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            this.records.Clear(); // Empty the existing records
                                  // We create an object to hold the ID parameter for the select statement
            BANK_ACCOUNT? oParams = new BANK_ACCOUNT();
            oParams.BANK_ID = this.MasterID;
            var oRecords = CData.Instance.DB.SelectWithParams<BANK_ACCOUNT>(
                    "select * from BANK_ACCOUNT where BANK_ID = @BANK_ID", oParams, p_iTransaction);

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }

        public override void SaveTable(IDbTransaction p_iTransaction)
        {
            if (this.records != null)
            {
                CData.Instance.DB.SaveChanges<BANK_ACCOUNT>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into BANK_ACCOUNT
                                  (
                                    SUPPLIER_ID
                                    ,IBAN
                                    ,BANK_ID
	                                ,BENEFICIARY
                                    ,AMOUNT_DUE
                                    ,ACCOUNT_TYPE
                                  )
                                  values
                                  (
                                    @SUPPLIER_ID
                                    ,@IBAN
                                    ,@BANK_ID
	                                ,@BENEFICIARY
                                    ,@AMOUNT_DUE
                                    ,@ACCOUNT_TYPE
                                  )",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update BANK_ACCOUNT set
                                    SUPPLIER_ID          = @SUPPLIER_ID
                                    ,IBAN                = @IBAN
                                    ,BANK_ID             = @BANK_ID
	                                ,BENEFICIARY          = @BENEFICIARY
                                    ,AMOUNT_DUE          = @AMOUNT_DUE
                                    ,ACCOUNT_TYPE        = @ACCOUNT_TYPE
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from BANK_ACCOUNT where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }


    }
}
