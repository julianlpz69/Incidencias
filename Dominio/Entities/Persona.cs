namespace Dominio.Entities
{
    public class Persona : BaseEntity
    {
        public string NombrePersona {get; set;}
        public string APellidoPersona {get; set;}
        public string DirrecionPersona {get; set;}
        public int IdGeneroPersonaFK {get; set;}
        public TipoGenero TipoGenero {get; set;}
        public int IdCiudadFK {get; set;}
        public Ciudad Ciudad {get; set;}
        public int IdTipoPersonaFK {get; set;}
        public TipoPersona TipoPersona {get; set;}
        public ICollection<Matricula> Matriculas { get; set; }
        public ICollection<PersonaSalon> PersonasSalones { get; set; }
    }
}