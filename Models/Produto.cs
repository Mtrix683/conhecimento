using System.ComponentModel.DataAnnotations;

namespace AvaliacaoTecnica.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal Preco { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}