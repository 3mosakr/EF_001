

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_001_EntityTypeAndMapping.Entities
{
    [Table("Orders", Schema = "Sales")]
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string? CustomerEmail { get; set; }
        public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();

    }
}
