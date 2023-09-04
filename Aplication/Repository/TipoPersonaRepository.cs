using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersonaRepository
    {
        public TipoPersonaRepository(IncidenciasContext context) : base(context)
        {
        }

    }
}