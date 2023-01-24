using System.ComponentModel.DataAnnotations;

namespace ApiTdrKms.Modelos.Dtos
{
    public class DistanciaDto
    {
        
        public int Id { get; set; }
       
        public string Economico { get; set; }
      
        public string Flota { get; set; }
        public string Kms { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }

    }
}
