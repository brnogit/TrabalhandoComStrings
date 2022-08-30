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

            // Split
            var frases = paragrafo.Split('.');

            // Trim, TrimEnd, TrimStart
            var paragrafoTrim = paragrafo.Trim(); //remove espaço em branco do inicio e final
            var paragrafoTrimEnd = paragrafo.TrimEnd(); // remove espaço em branco do final
            var paragrafoTrimStart = paragrafo.TrimStart(); // remove espaço em branco do começo
        }
    }
}
