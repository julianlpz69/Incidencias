namespace Dominio.Entities
{
    public class TipoPersona : BaseEntity
    {
        public string DescripcionPersona {get; set;}
        public ICollection<Persona> Personas { get; set; }
    }
}