using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DbEntities
{
    [Table("ProductCategories", Schema = "ecommerce")]
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }

        public string Description { get; set; }
        
        [ForeignKey("ProductId")]
        public int? ProductId { get; set; }

        public Product Product { get; set; }
    }
}
