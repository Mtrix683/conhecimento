using Microsoft.AspNetCore.Mvc;
using AvaliacaoTecnica.Models;

namespace AvaliacaoTecnica.Controllers
{
    public class ProdutosController : Controller
    {
        private static List<Produto> lista = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Notebook", Descricao = "Dell", Preco = 3500, CategoriaId = 2 },
            new Produto { Id = 2, Nome = "Mouse", Descricao = "Logitech", Preco = 150, CategoriaId = 2 }
        };

        private static List<Categoria> categorias = new List<Categoria>
        {
            new Categoria { Id = 1, Nome = "Alimento" },
            new Categoria { Id = 2, Nome = "Eletrônico" },
            new Categoria { Id = 3, Nome = "Bazar" },
            new Categoria { Id = 4, Nome = "Roupa" }
        };

        public IActionResult Index()
        {
            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.Categorias = categorias;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            produto.Id = lista.Max(p => p.Id) + 1;
            lista.Add(produto);

            return RedirectToAction("Index");
        }
    }
}
