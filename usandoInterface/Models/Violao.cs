using System;
using usandoInterface.Interfaces;

namespace usandoInterface.Models
{
    public class Violao : instrumentoMusical, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Tocando acordes de Violao");
            return true;
        }
    }
}