namespace Dominio.Interfaces
{
    public interface IUnitOfWork
    {
         ICiudadRepository Ciudades { get; }
         IDepartamentoRepository Departamentos { get; }
         IMatriculaRepository Matriculas { get; }
         IPaisRepository Paises { get; }
         IPersonaRepository Personas { get; }
         ISalonRepository Salones { get; }
         ITipoGeneroRepository TiposGeneros { get; }
         ITipoPersonaRepository TiposPersonas { get; }
        Task<int> SaveAsync();
    }
}