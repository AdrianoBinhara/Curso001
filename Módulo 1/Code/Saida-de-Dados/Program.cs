using System.Globalization;

namespace DataOut
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Saída de dados
            string name = "Binhara";
            char gender = 'M';
            int age = 22;
            double balance = 256.97556;

            Console.Write("Olá, {0}", name);
            Console.WriteLine($" - {age}/ {gender}");
            Console.WriteLine("Você possui " + balance.ToString("F2", CultureInfo.InvariantCulture) + " em sua conta bancária.");

            // ------------------------------------------- //
            //Entrada de dados
            // Console.Write("Quanto dinheiro você possui? ");
            // int money = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine($"Você possui {money} reais.");
            // Console.WriteLine();
            // Console.Write("Digite um valor para somar ao seu saldo: ");
            // int deposit = Convert.ToInt32(Console.ReadLine());
            // money += deposit;
            // Console.WriteLine($"{deposit} reais somados! Agora você possui {money} reais.");
        }
    }
}