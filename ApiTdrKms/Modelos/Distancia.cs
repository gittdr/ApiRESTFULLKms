using System.ComponentModel.DataAnnotations;

namespace ApiTdrKms.Modelos
{
    public class Distancia
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Economico { get; set; }
        [Required]
        public string Flota { get; set; }
        public string Kms { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public string Token { get; set; }
    }
}
