using System.ComponentModel.DataAnnotations;

namespace Aula6.Models
{
    public class Product 
    {
        [Required(ErrorMessage = "ID é obrigatorio")]
        [Range(10, 20, ErrorMessage = "Número de 10 a 20")]
        public int Id {get; set;}

        [Required(ErrorMessage = "Nome é obrigatorio")]
        [MinLength(3, ErrorMessage ="Minimo com 3 letras")]
        public string Name {get; set;}
        [Required(ErrorMessage = "Preço é Obrigatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "Número de 1 a 20")]
        public int Price {get; set; }
    }
}