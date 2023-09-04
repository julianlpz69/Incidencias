using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
    {
        public DepartamentoRepository(IncidenciasContext context) : base(context)
        {
        }

    }
}