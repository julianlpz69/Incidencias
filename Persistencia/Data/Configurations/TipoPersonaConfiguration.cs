using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class TipoPersonaConfiguration : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder){
    
            builder.ToTable("tipoPersona");
    
            builder.Property(e => e.DescripcionPersona)
                .HasMaxLength(50);
    
        }
    }
}