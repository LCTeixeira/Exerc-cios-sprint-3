using usandoInterface.Interfaces;

namespace usandoInterface.Models
{
    public class Teclado : instrumentoMusical, IPercursao, IHarmonia
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine();
            return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine();
            return true;
        }
    }
}