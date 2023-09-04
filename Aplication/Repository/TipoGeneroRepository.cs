using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class TipoGeneroRepository : GenericRepository<TipoGenero>, ITipoGeneroRepository
    {
        public TipoGeneroRepository(IncidenciasContext context) : base(context)
        {
        }

    }
}