namespace API.Dtos
{
    public class PaisXDeparDto
    {
        public int Id {get;set;}
        public string NombrePais {get;set;}
        public ICollection<DepartamentoDto> Departamentos { get; set; }
    }
}