using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPay.Models
{
    public class Payment
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CardNumber { get; set; }
        public int Cvv { get; set; }
        [Column(TypeName = "date")]
        public DateTime ExpiryDate { get; set; }
        public string CardHolderName { get; set; }
        public decimal Balance { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }



    }
}
