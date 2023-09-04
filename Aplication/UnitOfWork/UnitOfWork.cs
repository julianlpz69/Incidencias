using Aplication.Repository;
using Dominio.Interfaces;
using Persistencia.Data;

namespace Aplication.UnitOfWork
{
     public class UnitOfWork : IUnitOfWork
    {
        private readonly IncidenciasContext context;
        private PersonaRepository _personas;
        private CiudadRepository _ciudades;
        private DepartamentoRepository _departamentos;
        private MatriculaRepository _matriculas;
        private PaisRepository _paises;
        private SalonRepository _salones;
        private TipoGeneroRepository _tiposGeneros;
        private TipoPersonaRepository _tiposPersonas;
        

        public UnitOfWork(IncidenciasContext _context)
        {
            context = _context;
        }


        public ICiudadRepository Ciudades
        {
            get{
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(context);
                }
                return _ciudades;
            }

        }


        public IDepartamentoRepository Departamentos
        {
            get{
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(context);
                }
                return _departamentos;
            }
        }

        public IMatriculaRepository Matriculas
        {
            get{
                if (_matriculas == null)
                {
                    _matriculas = new MatriculaRepository(context);
                }
                return _matriculas;
            }
        }


        public IPaisRepository Paises
        {
            get{
                if (_paises == null)
                {
                    _paises = new PaisRepository(context);
                }
                return _paises;
            }
        }


        public IPersonaRepository Personas
        {
            get{
                if (_personas == null)
                {
                    _personas = new PersonaRepository(context);
                }
                return _personas;
            }
        }

        public ISalonRepository Salones 
        {
            get{
                if (_salones == null)
                {
                    _salones = new SalonRepository(context);
                }
                return _salones;
            }
        }

        public ITipoGeneroRepository TiposGeneros 
        {
            get{
                if (_tiposGeneros == null)
                {
                    _tiposGeneros = new TipoGeneroRepository(context);
                }
                return _tiposGeneros;
            }
        }

        public ITipoPersonaRepository TiposPersonas 
        {
            get{
                if (_tiposPersonas == null)
                {
                    _tiposPersonas = new TipoPersonaRepository(context);
                }
                return _tiposPersonas;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }
}