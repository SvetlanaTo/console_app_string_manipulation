using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_StringPoredjenja {

   class StringPoredjenja {

      static void Main(string[] args) {

         char[] SAMOGLASNICI = {
            'A', 'E', 'I', 'O', 'U'
         };
         int i;

         Console.WriteLine("*********************************************************");
         Console.WriteLine("Program za izbacivanje slova iz 2 korisnicka stringa.");
         Console.WriteLine("*********************************************************");

         String tekst1, tekst2;
         do {
            Console.WriteLine("Unesite prvi string po izboru: \t");
            tekst1 = Console.ReadLine();
         } while (tekst1 == null);
         do {
            Console.WriteLine("Unesite drugi string po izboru: \t");
            tekst2 = Console.ReadLine();
         } while (tekst2 == null);

         // povecavamo slova radi lakseg poredjenja
         tekst2 = tekst2.ToUpper();
         tekst1 = tekst1.ToUpper();

         // Izbaci bilo koje zadato slovo
         #region SESTO

         string noviTekst1 = "";
         string noviTekst2 = "";
         string unos = "";
         char slovo;

         do {
            Console.WriteLine("Koje slovo hocete da izbacite: \t");
            unos = Console.ReadLine();
            slovo = unos[0];
         } while (unos == null || unos.Length != 1);

         string tekst1kopija = tekst1;
         string tekst2kopija = tekst2;
         slovo = Char.ToUpper(slovo);

         for (i = 0; i < tekst1.Length; i++) {
            if (!tekst1[i].Equals(slovo)) {
               noviTekst1 = noviTekst1 + tekst1[i];
            }
         }
         for (i = 0; i < tekst2.Length; i++) {
            if (!tekst2[i].Equals(slovo)) {
               noviTekst2 = noviTekst2 + tekst2[i];
            }
         }

         Console.WriteLine("Tekst 1 pre zamene: " + tekst1kopija);
         Console.WriteLine("Tekst 1 posle zamene: " + noviTekst1);
         Console.WriteLine("Tekst 2 pre zamene: " + tekst2kopija);
         Console.WriteLine("Tekst 2 posle zamene: " + noviTekst2);


         #endregion

         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }
   }
}
