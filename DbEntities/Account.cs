using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.DbEntities
{
    [Table("Account", Schema = "ecommerce")]
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [ForeignKey("AccountTypeId")]
        public int AccountTypeId { get; set; }

        public User User { get; set; }

        public AccountType AccountType { get; set; }

        public List<Secret> Secrets { get; set; }
    }



}
