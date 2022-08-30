using System;

namespace PrincipaisMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var paragrafo = "    C# é uma linguagem moderna e versátil. " + "Com C# consigo desenvolver para Web, Desktop, Jogos, " + "Mobile, entre outros.   ";

            // Length = propriedade que reflete o tamanho do string
            var tamanho = paragrafo.Length;

            // Empty
            var vazio = string.Empty;

            //ToLower, ToUpper
            var paragrafoMinusculo = paragrafo.ToLower();
            var paragrafoMaiusculo = paragrafo.ToUpper();

            
        }
    }
}
