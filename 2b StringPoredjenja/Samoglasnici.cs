using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_StringPoredjenja
{

    class StringPoredjenja
    {

        static void Main(string[] args)
        {

            char[] SAMOGLASNICI = {
            'A', 'E', 'I', 'O', 'U'
         };
            int i;

            Console.WriteLine("**************************************************************");
            Console.WriteLine("Program za brojanje samoglasnika u 2 uneta korisnicka stringa.");
            Console.WriteLine("**************************************************************");

            String tekst1, tekst2;
            do
            {
                Console.WriteLine("Unesite prvi string po izboru: \t");
                tekst1 = Console.ReadLine();
            } while (tekst1 == null);
            do
            {
                Console.WriteLine("Unesite drugi string po izboru: \t");
                tekst2 = Console.ReadLine();
            } while (tekst2 == null);

            // povecavamo slova radi lakseg poredjenja
            tekst2 = tekst2.ToUpper();
            tekst1 = tekst1.ToUpper();

            // Drugo - Poredjenje koji sadrzi vise samoglasnika (prolazeci kroz char niz)
            #region DRUGO
            int brojac1 = 0, brojac2 = 0;
            for (i = 0; i < SAMOGLASNICI.Length; i++)
            {
                if (tekst1.Contains(SAMOGLASNICI[i]))
                {
                    brojac1++;
                }
            }
            for (i = 0; i < SAMOGLASNICI.Length; i++)
            {
                if (tekst2.Contains(SAMOGLASNICI[i]))
                {
                    ++brojac2; // ++brojac i brojac++ je u ovom kontekstu skroz isto
                }
            }
            String viseSamoglasnikaIma = "";
            if (brojac1 >= brojac2)
            {
                viseSamoglasnikaIma = "prvi";
            }
            else
            {
                viseSamoglasnikaIma = "drugi";

                // obrni mesta brojacima, radi kasnijeg ispisa
                //ako drugi ima vise samoglasnika, onda cemo brojacima zameniti mesta zbog ispisa
                var temp = brojac1;
                brojac1 = brojac2;
                brojac2 = temp;
                // klasicna zamena sa pomocnom promenljivom;
            }
            Console.WriteLine(String.Format("Vise samoglasnika ima {0} uneti string, i to {1}>={2}!"
                , viseSamoglasnikaIma, brojac1, brojac2));
            #endregion

            Console.WriteLine();
            Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
            Console.ReadKey();
        }
    }
}
