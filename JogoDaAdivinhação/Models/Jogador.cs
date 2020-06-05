using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JogoDaAdivinhação.Models
{
    public static class Jogador
    {
        public static int EscolhaJogador { get; set; }
        public static int NumeroTentativa { get; set; }
        static int Chute()
        {
            Console.Write("Chute um número entre 1 e 20: ");
            EscolhaJogador = Convert.ToInt32(Console.ReadLine());
            NumeroTentativa--;
            return EscolhaJogador;
        }
    }
}