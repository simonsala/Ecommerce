using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DbEntities
{
    [Table("Orders", Schema = "ecommerce")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan Timestamp { get; set; }

        [ForeignKey("UserId")]
        public int? UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("AddressId")]
        public int? AddressId { get; set; }
        public Address Address { get; set; }

        public List<ProductOrder> ProductOrders  { get; set; } = new List<ProductOrder>();

    }
}
