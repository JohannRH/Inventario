using System.ComponentModel.DataAnnotations;

namespace InvControlador
{
    public class Tipo
    {
        public int Id { get; set; }

        [Display(Name = "Tipo")]
        [MaxLength(100, ErrorMessage = "El campo {0} debe tener maximo 100 caracteres")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; } = null!;
        public string? Categoria { get; set; }
    }
}
