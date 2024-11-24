using EF_001_ConventionsOverConfigrations.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace EF_001_ConventionsOverConfigrations.Data.Config
{

    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("tblComments");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("CommentId");
            builder.Property(p => p.CommentBy).HasColumnName("UserId");



        }
    }
}
