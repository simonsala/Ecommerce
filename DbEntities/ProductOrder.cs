using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DbEntities
{
    [Table("ProductOrders", Schema = "ecommerce")]
    public class ProductOrder
    {
        [Key]
        public int ProductOrderId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public TimeSpan Timestamp { get; set; }

        public int Quantity { get; set; }

        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }

        public Product Product { get; set; }

        [ForeignKey("OrderId")]
        public int? OrderId { get; set; }
             

        public Order Order { get; set; }
    }
}
