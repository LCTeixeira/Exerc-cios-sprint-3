using System;
namespace usandoInterface.Models
{
    public class instrumentoMusical
    {
        string[] notas = {"do","re","mi","fa","sol","la","si"};
        public string TocarMusica(){
            int nota = new Random().Next(notas.Length - 1);
            return notas[nota];
        }
    }
}