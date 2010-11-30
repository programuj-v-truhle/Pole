using System;

namespace Pole
{
    // Ukázkový program na jednoduchou práci s polem
    class Program
    {
        static void Main(string[] args)
        {
            // Založ statické pole celých čísel o 8 prvcích
            int[] MojePole = { 8, 7, 6, 5, 4, 3, 2, 1 };

            // Změň pátý a první prvek v poli
            MojePole[4] = 10;
            MojePole[0] = ZískejNáhodnéČíslo();

            // Vypiš všechny čísla z pole, proveď jejich sumu a zjisti kolik je v poli lichých čísel
            int SoučetPole = 0,PočetLichýchČísel = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("{0}. prvek v poli má hodnotu {1}", i+1, MojePole[i]);
                SoučetPole += MojePole[i];
                if (MojePole[i] % 2 != 0)
                  PočetLichýchČísel++;
            }

            // Vypiš součet prvků v poli
            Console.WriteLine("Součet prvků v poli je {0}", SoučetPole);
            Console.WriteLine("\nV poli je {0} lichých čísel", PočetLichýchČísel);

            // Vytvoř dynamické pole desetinných čísel
            double[] PůlkyLichých = new double[PočetLichýchČísel];
            
            // Poděl všechna lichá čísla z MojePole číslem 2 a ulož výsledek do pole PůlkyLichých
            for (int i = 0,j = 0; i < 8; i++)
            {
                if (MojePole[i] % 2 != 0)
                {
                    PůlkyLichých[j] = MojePole[i] / 2.0;
                    j++;
                }
            }

            Console.WriteLine("Půlky všech lichých čísel:");
            // A teď vypiš všechna čísla v poli PůlkyLichých a zaokrouhli je na 2 desetinná místa
            foreach (double číslo in PůlkyLichých)
                Console.WriteLine("{0}", číslo);

            Console.Read();
        }

        /// <summary>
        /// Vygeneruje pseudonáhodné číslo pomocí systémového generátoru
        /// </summary>
        /// <returns>Nezáporné pseudonáhodné číslo, maximálně o hodnotě 1000</returns>
        static int ZískejNáhodnéČíslo()
        {
            return new Random().Next(1000);
        }
    }
}
