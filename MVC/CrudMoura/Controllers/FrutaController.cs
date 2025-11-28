using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;
using AspNetCoreGeneratedDocument;

namespace CrudMoura.Controllers
{
    public class FrutaController : Controller
    {
        private readonly ILogger<FrutaController> _logger;

        public static List<Fruta> ListaDeFrutas = new List<Fruta>
        {
            new Fruta{Id = 1, Nome = "Morango", Preco = 5.99f, Quantidade = 10, Categoria = "tropical"},
            new Fruta{Id = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 5, Categoria = "Imalaia"},
            new Fruta{Id = 3, Nome = "Limão", Preco = 2.90f, Quantidade = 22, Categoria = "Malasia"},
            new Fruta{Id = 4, Nome = "Laranja", Preco = 6.90f, Quantidade = 26, Categoria = "Do Silvestre Do Imalaia Da Amazonia do paraguai na coreia do norte adoçicada"}
        };

        public FrutaController(ILogger<FrutaController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarFrutas()
        {
            ViewBag.frutinha = ListaDeFrutas;
            return View();//retorna a pagina minha ação .cshtml
        }

        public IActionResult Create()
        {

            return View();    
        }

        [HttpPost]
        public IActionResult SalvarFruta(Fruta frutacadastrada)
        {
            ListaDeFrutas.Add(frutacadastrada);

            Console.WriteLine(frutacadastrada.Nome);
            Console.WriteLine(frutacadastrada.Preco);
            Console.WriteLine(frutacadastrada.Quantidade);
            Console.WriteLine(frutacadastrada.Categoria);
            
            return RedirectToAction(nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}