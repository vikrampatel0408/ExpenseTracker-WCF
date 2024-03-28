using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace expService
{
    public class ExpenseTrackerContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        public ExpenseTrackerContext() : base("Data Source=DESKTOP-Q60PG87\\SQLEXPRESS;Initial Catalog=ExpenseTracker;Integrated Security=True") // Replace "YourConnectionString" with your actual connection string
        {
        }
    }

    public class Service1 : IService1
    {
        private readonly ExpenseTrackerContext dbContext = new ExpenseTrackerContext();

        public Expense AddExpense(Expense expense)
        {
            dbContext.Expenses.Add(expense);
            dbContext.SaveChanges();
            return expense;
        }

        public List<Expense> GetExpenses()
        {
            return dbContext.Expenses.ToList();
        }

        public void UpdateExpense(Expense updatedExpense)
        {
            Expense existingExpense = dbContext.Expenses.FirstOrDefault(e => e.ExpenseId == updatedExpense.ExpenseId);
            if (existingExpense != null)
            {
                existingExpense.ExpenseName = updatedExpense.ExpenseName;
                existingExpense.Amount = updatedExpense.Amount;
                existingExpense.ExpenseDate = updatedExpense.ExpenseDate;
                existingExpense.Category = updatedExpense.Category;

                dbContext.SaveChanges();
            }
        }

        public void DeleteExpense(int expenseId)
        {
            Expense expenseToDelete = dbContext.Expenses.FirstOrDefault(e => e.ExpenseId == expenseId);
            if (expenseToDelete != null)
            {
                dbContext.Expenses.Remove(expenseToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
