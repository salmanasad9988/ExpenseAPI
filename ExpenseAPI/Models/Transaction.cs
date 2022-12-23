using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseAPI.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Details { get; set; } = string.Empty;
        public int Type { get; set; }//0-credit, 1-debit
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
