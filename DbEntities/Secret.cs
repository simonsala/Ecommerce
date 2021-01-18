using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DbEntities
{
    [Table("Secrets", Schema = "ecommerce")]
    public class Secret
    {
        [Key]
        public int SecretId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }

        [ForeignKey("AccountId")]
        public int AccountId { get; set; }

        public Account Account;
    }
}
