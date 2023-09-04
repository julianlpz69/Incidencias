namespace Dominio.Entities
{
    public class Salon : BaseEntity
    {
        public string NombreSalon {get; set;}
        public int CapacidadSalon {get; set;}
        public ICollection<Matricula> Matriculas { get; set; }
        public ICollection<PersonaSalon> PersonasSalones { get; set; }
    }
}