using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Model
{
    public partial class Bank
    {
        public Bank()
        {
            BankAcc = new HashSet<BankAcc>();
            Customer = new HashSet<Customer>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nchar(50)")]
        public string Name { get; set; }
        [Required]
        [Column("BIC", TypeName = "nchar(50)")]
        public string Bic { get; set; }

        [InverseProperty("Bank")]
        public ICollection<BankAcc> BankAcc { get; set; }
        [InverseProperty("Bank")]
        public ICollection<Customer> Customer { get; set; }
    }
}
