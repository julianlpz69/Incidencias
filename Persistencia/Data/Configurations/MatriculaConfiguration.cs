using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configurations
{
    public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
    {
        public void Configure(EntityTypeBuilder<Matricula> builder){
    
            builder.ToTable("matricula");
    

            builder.HasOne(p => p.Salon)
                .WithMany(p => p.Matriculas)
                .HasForeignKey(p => p.IdSalonFk);


            builder.HasOne(p => p.Persona)
                .WithMany(p => p.Matriculas)
                .HasForeignKey(p => p.IdPersonaFK);
        }
    }
}