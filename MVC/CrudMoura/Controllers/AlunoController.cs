using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreGeneratedDocument;
using CrudMoura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly CrudMouraContext _context;


        public static List<Aluno> ListadeAlunos = new List<Aluno>
        {
            new Aluno{Id = 1, Nome = "Ariel", Idade = 5, Ra = "1432320", Email = "tropical@gmail.com"},
            new Aluno{Id = 2, Nome = "Rafael", Idade = 5, Ra = "5432434", Email = "Imalaia@gmail.com"},
            new Aluno{Id = 3, Nome = "Joao", Idade = 2, Ra = "221432432", Email = "Malasia@gmail.com"},
            new Aluno{Id = 4, Nome = "Torolho", Idade = 6, Ra = "264324234", Email = "Tropical Silvestre Do Imalaia Da Amazonia No Paraguai Central Da India Perto Da Fronteira da China No Mar Negro Do Japão na Australia Dentro Da Austria@gmail.com"}
        };
        public AlunoController(ILogger<AlunoController> logger, CrudMouraContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }

        public IActionResult ListarAlunos()
        {
            ViewBag.aluninho = ListadeAlunos;
            return View();
        }
        public IActionResult Create()
        {
            return View();//retorna a pagina minha ação .cshtml
        }

        public IActionResult SalvarAluno(Aluno alunocadastra)
        {
            ListadeAlunos.Add(alunocadastra);

            Console.WriteLine(alunocadastra.Nome);
            Console.WriteLine(alunocadastra.Idade);
            Console.WriteLine(alunocadastra.Ra);
            Console.WriteLine(alunocadastra.Email);

            return RedirectToAction(nameof(ListarAlunos));
        }
    }
}