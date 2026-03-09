using Microsoft.AspNetCore.Mvc;
using AvaliacaoTecnica.Models;
using AvaliacaoTecnica.Data;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoTecnica.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutosController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var produtos = _context.Produtos.ToList();
            return View(produtos);
        }

        public IActionResult Create()
        {
            ViewBag.Categorias = _context.Categorias.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}