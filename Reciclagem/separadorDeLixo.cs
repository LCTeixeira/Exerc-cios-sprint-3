using usandoInterfaces.Interfaces;
namespace Reciclagem
{
    public class separadorDeLixo : IOrganico, IPapel, IPlastico, IVidro, IIndefinido, IMetal
    {
        public bool LixoOrganico(){
            System.Console.WriteLine("Esse lixo é organico");
            return true;
        }

        public bool LixoMetal(){
            System.Console.WriteLine("Esse lixo é metalico");
            return true;
        }

        public bool LixoIndefinido(){
            System.Console.WriteLine("Esse lixo é indefinido");
            return true;
        }

        public bool LixoPapel(){
            System.Console.WriteLine("Esse lixo é de papel");
            return true;
        }

        public bool LixoPlastico(){
            System.Console.WriteLine("Esse lixo é plastico");
            return true;
        }

        public bool LixoVidro(){
            System.Console.WriteLine("Esse lixo é de vidro");
        }
    }
}