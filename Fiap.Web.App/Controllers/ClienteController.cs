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
            string email = cliente.Email;
            DateTime dataNascimento = cliente.DataNascimento;

            int dia = dataNascimento.Day;
            int mes = dataNascimento.Month;
            int ano = dataNascimento.Year;

            Console.WriteLine(nome);
            Console.WriteLine(sobrenome);
            Console.WriteLine(email);
            Console.WriteLine(dia + "/" + mes + "/" + ano);

            ViewBag.titulo = "Cadastro Cliente";
            ViewBag.nome = nome;
            return View();
        }
    }
}
