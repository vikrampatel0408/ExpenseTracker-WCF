using System;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace expService
{
    [DataContract]
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        [DataMember]
        public string ExpenseName { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember]
        public DateTime ExpenseDate { get; set; }

        [DataMember]
        public string Category { get; set; }
    }
}