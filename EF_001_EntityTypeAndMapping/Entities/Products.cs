using System.ComponentModel.DataAnnotations.Schema;

namespace EF_001_EntityTypeAndMapping.Entities
{
    // [Table("Products", Schema = "Inventory")]
    public class Product
    {
      
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string? Description { get; set; }


        // Exclude Entity
        public Snapshot? Snapshot { get; set; }

        private Product()
        {
            this.Snapshot = new();
        }
    }
}
