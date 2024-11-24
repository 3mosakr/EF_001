using System.ComponentModel.DataAnnotations.Schema;

namespace EF_001_EntityTypeAndMapping.Entities
{
    [Table("OrderDetails", Schema = "Sales")]
    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }

    }
}
