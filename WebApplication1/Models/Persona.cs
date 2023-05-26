using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cognome { get; set; }


        public int DipartimentoId { get; set; }
        [ForeignKey("DipartimentoId")]
        public CDipartimento Dipartimento { get; set; }
    }
}
