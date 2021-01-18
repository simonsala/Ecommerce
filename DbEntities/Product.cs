using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DbEntities
{
    [Table("Products", Schema = "ecommerce")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(19, 4)")]
        public Decimal Price { get; set; }

        public int AvailableQuantity { get; set; }

        public float Weight { get; set; }

        public string Description { get; set; }

        public List<ProductOrder> ProductOrders { get; set; } = new List<ProductOrder>();
    }
}
