using System;

namespace ConversioniDecimali_Binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto,valorebase;
            string binario = "";
            Console.Write("Inserisci la base in cui vuoi convertire:");
            valorebase = int.Parse(Console.ReadLine());
            Console.Write("Inserisci il numero che vuoi convertire:");
            num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                resto = num % valorebase;
                if(resto == 15)
                {
                    binario += "f";
                }
                else if( resto == 14)
                {
                    binario += "e";
                }
                else if(resto == 13)
                {
                    binario += "d";
                }
                else if(resto == 12)
                {
                    binario += "c";
                }
                else if(resto == 11)
                {
                    binario += "b";
                }
                else if( resto == 10)
                {
                    binario += "a";
                }
                else
                {
                    binario = Convert.ToString(resto) + binario;
                }
                num = num / valorebase;
            }
            Console.WriteLine($"Il numero convertito in base {valorebase} è:{binario}");
        }
    }
}
