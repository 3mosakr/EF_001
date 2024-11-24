
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_001_EntityTypeAndMapping.Entities
{
    // Exclude Entity

    //[NotMapped]
    public class Snapshot
    {
        public DateTime LoadedAt => DateTime.UtcNow;
        public String Version =>
            Guid.NewGuid().ToString().Substring(0, 8); // 81604D1D
    }
}
