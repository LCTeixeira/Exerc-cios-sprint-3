using usandoInterface.Interfaces;

namespace usandoInterface.Models
{
    public class Guitarra : instrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarSolo()
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