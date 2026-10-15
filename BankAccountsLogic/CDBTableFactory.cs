using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BankAccounts.Data;
using BankAccounts.Data.Records;
using BankAccounts.Data.Tables;
using Lib.Data.DB;
using Lib.Common.Interfaces;

namespace DataApplication.Logic
{
    public class CDBTableFactory
    {
        #region // Singleton \\
        // ....................................................................
        private static CDBTableFactory? __instance = null;
        public static CDBTableFactory Instance
        {
            get
            {
                //PATTERN: Lazy initialization. The only instance is created at the first time that is needed.
                if (__instance == null)
                    __instance = new CDBTableFactory();
                return __instance;
            }
        }
        private CDBTableFactory()
        {
        }
        // ....................................................................
        #endregion

        // --------------------------------------------------------------------------------------
        // [PATTERNS] Factory Method
        public IDBTable CreateTable(string p_sTableName)
        {
            // [C# ADVANCED] We cast the type to Object and then convert to the base class CDBRecord for the T in the generic class CDBTable
            if (p_sTableName == "BANK")
                return new TableBANK();
            else if (p_sTableName == "BANK_ACCOUNT")
                return new TableBANK_ACCOUNT();
            else if (p_sTableName == "COUNTRY")
                return new TableCOUNTRY();
            else if (p_sTableName == "SUPPLIER")
                return new TableSUPPLIER();
            else
                return null;
        }
        // --------------------------------------------------------------------------------------
    }

}
