using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement.Internal;

namespace CrudMoura.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    //Ação Inicial Padrão
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult MinhaAcao()
    {
        return View();//retorna a pagina minha ação .cshtml
    }
    public IActionResult ListaNome()
    {
        string[] nomes = { "Ariel", "Rafael", "Salgado", "Gomes" };
        ViewBag.nomes = nomes;
        ViewBag.Teste = "Ola Eu Vim Atraves Da ViewBag";
        return View();//retorna a pagina minha ação .cshtml
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
