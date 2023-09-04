using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class CiudadRepository : GenericRepository<Ciudad>, ICiudadRepository
    {
        public CiudadRepository(IncidenciasContext context) : base(context)
        {
        }

    }
}