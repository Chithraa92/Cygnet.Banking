namespace Cygnet.Banking.Services.Helpers
{
    public static class ApiActionsV1
    {
        private const string V1 = "api/v1";

        #region CustomerActions

        public const string Customer = $"{V1}/transaction";
        public const string CreateCustomer = "create";

        #endregion TransactionActions

        #region TransactionActions

        public const string Transaction = $"{V1}/transaction";
        public const string GetTransactionHistory = "history";
        public const string AddTransactions = "add";

        #endregion TransactionActions

        #region AccountActions

        public const string Account = $"{V1}/account";
        public const string GetAccountBalance = "balance";
        public const string CreateAccount = "create";
        public const string UpdateAccount = "update";
        public const string CreateBeneficiary = "create-beneficiary";
        public const string CreateIfsc = "create-Ifsc";

        #endregion AccountActions
    }
}