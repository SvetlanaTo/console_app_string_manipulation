using System;

namespace _2_StringPoredjenja {

   class StringPoredjenja {

      static void Main(string[] args) {

         char[] SAMOGLASNICI = {
            'A', 'E', 'I', 'O', 'U'
         };
         int i;

         Console.WriteLine("*********************************************************");
         Console.WriteLine("Program za zamenu ciljanog slova zvezdicom u 2 korisnicka stringa.");
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

         // Cetvrto - Zameni samoglasnike zvezdicom
         #region CETVRTO
         string tekst1kopija = tekst1;
         string tekst2kopija = tekst2;

         for (i = 0; i < tekst1.Length; i++) {
            for (int j = 0; j < SAMOGLASNICI.Length; j++) {
               if (tekst1[i].Equals(SAMOGLASNICI[j])) {
                  tekst1 = tekst1.Replace(SAMOGLASNICI[j], '*');
               }
            }
         }
         for (i = 0; i < tekst2.Length; i++) {
            for (int j = 0; j < SAMOGLASNICI.Length; j++) {
               if (tekst2[i].Equals(SAMOGLASNICI[j])) {
                  tekst2 = tekst2.Replace(SAMOGLASNICI[j], '*');
               }
            }
         }

         Console.WriteLine("Tekst 1 pre zamene: " + tekst1kopija);
         Console.WriteLine("Tekst 1 posle zamene: " + tekst1);
         Console.WriteLine("Tekst 2 pre zamene: " + tekst2kopija);
         Console.WriteLine("Tekst 2 posle zamene: " + tekst2);

         #endregion

         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }
   }
}
