using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EzPay.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [StringLength(100)]

        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(255)]

        public string Password { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }
        public decimal Balance { get; set; }

        public DateTime Date { get; set; }

        [StringLength(10)]
        public string Role { get; set; }

        public virtual List<Payment> Payments { get; } = new List<Payment>();


        public virtual List<Transaction> Transactions { get; } = new List<Transaction>();

        //public ICollection<Subscription> Subscriptions { get; set; }


        //public ICollection<Bill> Bills { get; set; }


    }
}
