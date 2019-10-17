using System;
using usandoInterface.Interfaces;

namespace usandoInterface.Models
{
    public class Bateria : instrumentoMusical, IPercursao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine();
            return true;
        }
    }
}