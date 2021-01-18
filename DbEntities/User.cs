
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DbEntities
{
    [Table("Users", Schema = "ecommerce")]
    public class User
    {
        [Key]
        public int  UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PrimaryEmail { get; set; }

        public string SecondaryEmail { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }


        public List<Address> Addresses { get; set; } = new List<Address>();

        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
