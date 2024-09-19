using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace rest_api_dotnet_template.Models
{
    [Table("Disciplinas")]
    public class Disciplina : BaseEntity
    {
        [Required(ErrorMessage = "O nomme da disciplina deve ser informado")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O valor da nota deve ser informado")]
        [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10")]
        public decimal Nota { get; set; }




    }
}
