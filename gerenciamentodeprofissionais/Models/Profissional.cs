using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace gerenciamentodeprofissionais.Models
{
    public class Profissional
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
        public string NumeroDocumento { get; set; }
    }
}
