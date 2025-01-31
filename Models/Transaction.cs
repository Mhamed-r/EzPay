using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPay.Models
{
    public class Transaction
    {

        [Key]
        public int TransactionId { get; set; }

        public int UserId { get; set; }

        public int ReceiverId { get; set; }

        public decimal Amount { get; set; }

        public DateTime TransactionDate { get; set; }

        [Required]
        public string TransactionType { get; set; }

        [Required]
        public string TransactionStatus { get; set; }


        public virtual User User { get; set; }

    }
}
