using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult Index()
    {
        Banco dba = new Banco();
        ViewBag.listaClientes = dba.GetLista();
        Banco1 dba1 = new Banco1();
        ViewBag.listaFornecedores = dba1.GetLista1();
        
        return View();
    }
    public IActionResult Clientes()
    {
        Banco dba = new Banco();
        ViewBag.listaClientes = dba.GetLista();  
        
        return View();
    }
    public IActionResult Fornecedor()
    {
        Banco1 dba1 = new Banco1();
        ViewBag.listaFornecedores = dba1.GetLista1();
        
        return View();
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
