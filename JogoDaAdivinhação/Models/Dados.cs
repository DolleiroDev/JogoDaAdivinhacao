using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JogoDaAdivinhação.Models
{
    public static class Dados
    {
        public static int NumeroAleatorio { get; set; }
        public static int GerarNumero()
        {
            var rnd = new Random();
            NumeroAleatorio = rnd.Next(1, 10);
            return NumeroAleatorio;
        }
    }
}