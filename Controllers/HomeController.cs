using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GerenciamentoEventos.Models;

namespace GerenciamentoEventos.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}
