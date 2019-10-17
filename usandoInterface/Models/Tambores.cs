using usandoInterface.Interfaces;

namespace usandoInterface.Models
{
    public class Tambores : instrumentoMusical, IPercursao
    {
        public bool ManterRitmo()
        {
            System.Console.WriteLine();
            return true;
        }
    }
}