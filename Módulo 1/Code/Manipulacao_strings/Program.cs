using System;

namespace _2___ManipulacaoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 4;
            string concatenada = "variável entra aqui: " + numero;
            string format = string.Format("variável entra aqui: {0}", numero);
            string interpolation = $"variável entra aqui: {numero}";

            /* string frase = "Essa é uma frase com muitas palavras";

            if (frase.Contains("palavras"))
            {
                Console.WriteLine("A string contém o texto indicado.");
            }
            else
            {
                Console.WriteLine("A string NÃO contém o texto indicado.");
            }
 
            string frase = "Essa é uma frase com muitas palavras";

            if (frase.Contains("pala"))
            {
                Console.WriteLine("A string contém o texto indicado.");
            }
            else
            {
                Console.WriteLine("A string NÃO contém o texto indicado.");
            }

            string frase = "Essa é uma frase com muitas palavras";

            if (frase.Contains("PALA"))
            {
                Console.WriteLine("A string contém o texto indicado.");
            }
            else
            {
                Console.WriteLine("A string NÃO contém o texto indicado.");
            }


            string frase = "Essa é uma frase com muitas palavras";

            if (frase.StartsWith("essa"))
            {
                Console.WriteLine("A string começa com o texto indicado.");
            }
            else
            {
                Console.WriteLine("A string NÃO começa com o texto indicado.");
            }


            string frase = "Essa é uma frase com muitas palavras";

            if (frase.EndsWith("palavras"))
            {
                Console.WriteLine("A string termina com o texto indicado.");
            }
            else
            {
                Console.WriteLine("A string NÃO termina com o texto indicado.");
            }


            string frase = "Essa é uma frase com muitas palavras";

            var indice = frase.IndexOf("muitas");
            var substring = frase.Substring(indice);

            Console.WriteLine(indice);
            Console.WriteLine(substring);


            string frase = "Essa é uma frase com muitas palavras";

            var indice = frase.IndexOf("inexistente");

            Console.WriteLine(indice);


            string texto = "Esta é uma frase com muitas palavras.\n"
            + "Esta é a segunda frase.\n"
            + "Esta é a terceira frase.\n"
            + "Esta é a quarta frase.\n"
            + "Esta é a quinta frase.";

            string[] linhas = texto.Split('\n');

            Console.WriteLine(linhas[0]);
            Console.WriteLine(linhas[4]);


            string texto = "Esta é uma frase com muitas palavras.";

            string[] linhas = texto.Split(' ');

            Console.WriteLine(linhas[0]);
            Console.WriteLine(linhas[4]);
            Console.WriteLine(linhas[6]);


            string[] palavras =
            {
                "Esta",
                "é",
                "uma",
                "frase",
                "com",
                "muitas",
                "palavras"
            };

            var resultado = string.Join(",", palavras);
            Console.WriteLine(resultado);

            string email = "dev@sdc.com  ";

            email = email.Trim();
            Console.WriteLine($"Email digitado: {email}.");

            string frase = "Esta é uma frase com muitas palavras";

            Console.WriteLine(frase.ToUpper());

            string frase = "Esta é uma frase com muitas palavras";

            if (frase.ToLower().Contains("esta"))
            {
                Console.WriteLine("A string contém o texto indicado.");
            }
            else
            {
                Console.WriteLine("A string NÃO contém o texto indicado.");
            } */
        }
    }
}
