using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class PaisConfiguration : IEntityTypeConfiguration<Pais>
    {
        public void Configure(EntityTypeBuilder<Pais> builder){
    
            builder.ToTable("pais");
    
            builder.Property(e => e.NombrePais)
                .HasMaxLength(30);
    
        }
    }
}