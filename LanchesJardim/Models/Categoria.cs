using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LanchesJardim.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Display(Name = "Nome")]
        [Required]
        [StringLength(100)]
        public string CategoriaNome { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public virtual List<Lanche> Lanches { get; set; }
    }
}
