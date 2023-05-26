using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class CDipartimento
    {
        [Key]
        public int Id { get; set; }
        public string? Nome { get; set; }

        public ICollection<Persona> Persone { get; set; } = new List<Persona>();


    }
}
