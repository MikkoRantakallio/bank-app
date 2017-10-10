using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Model
{
    public partial class BankAcc
    {
        public BankAcc()
        {
            BankAccountTransaction = new HashSet<BankAccountTransaction>();
        }

        [Key]
        [Column("IBAN", TypeName = "nchar(50)")]
        public string Iban { get; set; }
        [Required]
        [Column(TypeName = "nchar(50)")]
        public string Name { get; set; }
        public int BankId { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Balance { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("BankAcc")]
        public Bank Bank { get; set; }
        [ForeignKey("CustomerId")]
        [InverseProperty("BankAcc")]
        public Customer Customer { get; set; }
        [InverseProperty("IbanNavigation")]
        public ICollection<BankAccountTransaction> BankAccountTransaction { get; set; }
    }
}
