using System;

namespace StringsBuscas
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Busca
            var outroParagrafo = "C# é uma linguagem moderna e versátil. " + "Com C# consigo desenvolver para Web, Desktop, Jogos, " + "Mobile, entre outros.";

            // IndexOf = retorna o indice da primeira ocorrencia
            var indexOf = outroParagrafo.IndexOf("C#");

            // LastIndexOf = retorna o indice da ultima ocorrencia
            var lastIndexOf = outroParagrafo.LastIndexOf("C#");

            // StartsWith = retorna o valor verdadeiro ou falso, confirmando se o resultado é o esperado.
            var startsWith = outroParagrafo.StartsWith("C#");

            // Substring
            var indexOfMobile = outroParagrafo.IndexOf("Mobile");
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6); //"Mobile".Length para  saber o tamanho, no caso 6.

            // Contains
            var containsJogo = outroParagrafo.Contains("jogos", StringComparison.OrdinalIgnoreCase);
            var containsJogosExact = outroParagrafo.Contains("Jogos");
            var containsRuim = outroParagrafo.Contains("ruim");
            #endregion

            Console.ReadKey();
        }
    }
}
