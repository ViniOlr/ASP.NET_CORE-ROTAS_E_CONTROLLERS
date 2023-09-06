using Fiap.Web.App.Model;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.App.Controllers
{
    public class MediaController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Media media)
        {
            float Media1 = media.Media1;
            float Media2 = media.Media2;
            float MediaTotal = media.CalculaMedia();
            bool Aprovacao = media.ValidacaoAprovacao(MediaTotal);

            //Console.WriteLine(Media1);
            //Console.WriteLine(Media2);
            //Console.WriteLine(MediaTotal);
            if (Aprovacao)
            {
                Console.WriteLine("Parabéns, você foi aprovado com: " + MediaTotal);
                ViewBag.conteudo = "Parabéns, você foi aprovado com: " + MediaTotal;
            }
            else
            {
                Console.WriteLine("Sinto muito, você foi reprovado com: " + MediaTotal);
                ViewBag.conteudo = "Sinto muito, você foi reprovado com: " + MediaTotal;
            }
            return View();
        }
    }
}
