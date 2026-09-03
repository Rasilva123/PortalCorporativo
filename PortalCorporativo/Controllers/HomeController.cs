using Microsoft.AspNetCore.Mvc;
using PortalCorporativo.Models;

namespace PortalCorporativo.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var servicos = new List<ServicoModel>
        {
            new ServicoModel
            {
                Id = 1,
                Nome = "Desenvolvimento Web",
                Descricao = "Criação de sistemas e sites para empresas.",
                Preco = 1500,
                Disponivel = true
            },

            new ServicoModel
            {
                Id = 2,
                Nome = "Consultoria em Tecnologia",
                Descricao = "Consultoria especializada em tecnologia.",
                Preco = 800,
                Disponivel = true
            },

            new ServicoModel
            {
                Id = 3,
                Nome = "Manutenção de Sistemas",
                Descricao = "Manutenção e suporte para sistemas.",
                Preco = 500,
                Disponivel = false
            }
        };

        return View(servicos);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}