using Dominio.Entities;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class SalonRepository : GenericRepository<Salon>, ISalonRepository
    {
        public SalonRepository(IncidenciasContext context) : base(context)
        {
        }

    }
}