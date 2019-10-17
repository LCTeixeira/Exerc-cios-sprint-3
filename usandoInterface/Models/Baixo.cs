using usandoInterface.Interfaces;

namespace usandoInterface.Models
{
    public class Baixo : instrumentoMusical, IPercursao, IHarmonia
    {
        public bool ManterRitmo()
        {
        System.Console.WriteLine("Mantendo i ritno do Baixo");
        return true;
        }

        public bool TocarAcordes()
        {
            System.Console.WriteLine("Mantendo acordes do Baixo");
            return true;
        }
    }
}