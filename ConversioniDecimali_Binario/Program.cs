using System;

namespace ConversioniDecimali_Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1024, resto;
            string binario = "";
            while (num > 0)
            {
                resto = num % 2;
                num = num / 2;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"il numero in binario è {binario}");
        }
    }
}
