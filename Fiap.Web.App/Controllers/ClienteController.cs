using Fiap.Web.App.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection.Metadata;

namespace Fiap.Web.App.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar(Cliente cliente)
        {
            string nome = cliente.Nome;
            string sobrenome = cliente.Sobrenome;

            Console.WriteLine("Pritando pelo Cadastrar");
            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);

            ViewBag.titulo = "Cadastro Cliente";
            return View();
        }
    }
}
