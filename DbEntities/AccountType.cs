using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ecommerce.DbEntities
{
    [Table("AccountType", Schema = "ecommerce")]
    public class AccountType
    {
        [Key]
        public int AccountTypeId { get; set; }

        public string  Type { get; set; }

    }


}


