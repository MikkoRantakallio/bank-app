using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankApp.Model
{
    public partial class Customer
    {
        public Customer()
        {
            BankAccount = new HashSet<BankAccount>();
        }

        [Column("id")]
        public int Id { get; set; }
        [Column(TypeName = "nchar(50)")]
        public string FirstName { get; set; }
        [Column(TypeName = "nchar(50)")]
        public string LastName { get; set; }
        public int? BankId { get; set; }

        [ForeignKey("BankId")]
        [InverseProperty("Customer")]
        public Bank Bank { get; set; }
        [InverseProperty("Customer")]
        public ICollection<BankAccount> BankAccount { get; set; }
    }
}
