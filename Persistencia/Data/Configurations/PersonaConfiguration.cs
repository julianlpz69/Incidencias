using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class Personafiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder){
    
            builder.ToTable("persona");
    
            builder.Property(e => e.NombrePersona)
                .HasMaxLength(50);

            builder.Property(e => e.APellidoPersona)
                .HasMaxLength(50);


            builder.HasOne(p => p.Ciudad)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdCiudadFK); 


            builder.HasOne(p => p.TipoPersona)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdTipoPersonaFK);


            builder.HasOne(p => p.TipoGenero)
            .WithMany(p => p.Personas)
            .HasForeignKey(p => p.IdGeneroPersonaFK);
    
        }
    }
}