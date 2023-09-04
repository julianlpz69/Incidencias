using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class MatriculaRepository : GenericRepository<Matricula>, IMatriculaRepository
    {
        public MatriculaRepository(IncidenciasContext context) : base(context)
        {
        }

    }
}