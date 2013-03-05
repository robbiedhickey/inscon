using System;

namespace Enterprise.DALServices.DAL.Test.Helpers
{
    using System.Transactions;

    public static class TransactionHelper
    {
        public static void Rollback(Action action)
        {
            using (var scope = new TransactionScope())
            {
                action();
                scope.Dispose();
            }
        }
    }
}
