namespace Dominio.Entities
{
    public class TipoGenero : BaseEntity
    {
        public string NombreGenero {get; set;}
        public ICollection<Persona> Personas { get; set; }
    }
}