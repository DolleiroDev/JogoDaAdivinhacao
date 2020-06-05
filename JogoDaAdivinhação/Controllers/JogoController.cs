using JogoDaAdivinhação.Models;
using System;
using System.Web.Mvc;

namespace JogoDaAdivinhação.Controllers
{

    public class JogoController : Controller
    {
        public ActionResult Index()
        {
            Dados.NumeroAleatorio = Dados.GerarNumero();
            Jogador.NumeroTentativa = 4;
            ViewBag.Tentativas = Jogador.NumeroTentativa;
            return View();
        }

        [HttpPost]
        public ActionResult PegarNumero()
        {
            Jogador.EscolhaJogador = Convert.ToInt32(Request["numero"]);
            ViewBag.Chute = Jogador.EscolhaJogador;
            ViewBag.Correto = Dados.NumeroAleatorio;
            if (Jogador.EscolhaJogador == Dados.NumeroAleatorio)
            {
                return View("Acertou");
            }
            else
            {
                Jogador.NumeroTentativa--;
                ViewBag.Tentativas = Jogador.NumeroTentativa;
            }

            if (Jogador.NumeroTentativa <= 0)
            {
                return View("Errou");
            }

            return View("Index");
            
        }
    }
}