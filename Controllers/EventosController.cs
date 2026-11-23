using GerenciamentoEventos.Models;
using Microsoft.AspNetCore.Mvc;
using GerenciamentoEventos.ViewModels;

namespace GerenciamentoEventos.Controllers
{
    public class EventosController : Controller
    {
        private static List<Evento> _eventos = new()
        {
            new Evento{ Id = 1, Nome = "Expo Pizza Leste", Descricao = "Um encontro das melhores pizzarias da Zona Leste de São Paulo", Local = "Parque Ibirapuera", DataEvento = new DateTime(2026, 10, 01), QuantidadeVagas = 200, ValorIngresso = 50.00m},
            new Evento{ Id = 2, Nome = "Brasil Game Show", Descricao = "Um encontro para gamers de todo o Brasil, trazendo influencers, empresas e atrações relacionadas ao mundo dos games", Local = "Distrito Anhembi", DataEvento = new DateTime(2027, 08, 21), QuantidadeVagas = 950, ValorIngresso = 150.00m},
        };

        // GET /Eventos - listar todos os eventos
        public IActionResult Index()
        {
            return View(_eventos);
        }

        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Evento evento)
        {
            if(!ModelState.IsValid)
            {
                return View(evento);
            }
            evento.Id = _eventos.Any() ? _eventos.Max(e => e.Id) + 1 : 1;
            _eventos.Add(evento);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Buscar()
        {
            return View(new BuscaEventoViewModel());
        }
        [HttpPost]
        public IActionResult Buscar(BuscaEventoViewModel vm)
        {
            
        }
        
    }
}