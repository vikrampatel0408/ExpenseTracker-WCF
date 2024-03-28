using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace expService
{
/*    public class ExpenseTrackerContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
    }*/
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        Expense AddExpense(Expense expense);

        [OperationContract]
        List<Expense> GetExpenses();

        [OperationContract]
        void UpdateExpense(Expense updatedExpense);

        [OperationContract]
        void DeleteExpense(int expenseId);
    }
}
