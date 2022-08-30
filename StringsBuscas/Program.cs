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
            #endregion

            Console.ReadKey();
        }
    }
}
