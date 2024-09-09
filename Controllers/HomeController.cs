using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;
using LHPert.Models;
using LHPet.Model;

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
        Cliente c1 = new Cliente(01, "ALexandre Gomes", "021.235.231-89", "alexggrf@gmail.com", "Huck");
        Cliente c2 = new Cliente(02, "Marcos Luis", "064.225.238-54", "marcosdddd@gmail.com", "thor");
        Cliente c3 = new Cliente(03, "Luis carlos", "036.658.871-87", "alexggrf@gmail.com", "Nala");
        Cliente c4 = new Cliente(04, "Maria Luisa", "058.254.231-58", "Maria252552@gmail.com", "Nina");
        Cliente c5 = new Cliente(05, "Ana Marcia", "641.369.531-77", "Leilasdsd@gmail.com", "mel");

        List<Cliente> listaClientes  = new List<Cliente>();
        listaClientes.Add(c1);
        listaClientes.Add(c2);
        listaClientes.Add(c3);
        listaClientes.Add(c4);
        listaClientes.Add(c5);

        ViewBag.listaClientes = listaClientes;

        Fornecedor f1 = new Fornecedor(01, "Sia Pets", "14.254.165/0001-85", "siapets@gmail.com");
        Fornecedor f2 = new Fornecedor(02, "Pets lar", "15.256.698/0001-75", "petslar1212@gmail.com");
        Fornecedor f3 = new Fornecedor(03, "dogs e cats", "16.478.547/0001-58", "dogsecats@gmail.com");
        Fornecedor f4 = new Fornecedor(04, "Home Pets", "18.254.689/0001-14", "homepets@gmail.com");
        Fornecedor f5 = new Fornecedor(05, "Pets Show", "63.254.145/0001-02", "petsshow@gmail.com");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(f1);
        listaFornecedor.Add(f2);
        listaFornecedor.Add(f3);
        listaFornecedor.Add(f4);
        listaFornecedor.Add(f5);

        ViewBag.listaFornecedor = listaFornecedor;

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
