using System;

namespace _2_StringPoredjenja {

   class StringPoredjenja {

      static void Main(string[] args) {

         char[] SAMOGLASNICI = {
            'A', 'E', 'I', 'O', 'U'
         };
         int i;

         Console.WriteLine("*********************************************************");
         Console.WriteLine("Program za zamenu slova u 2 uneta korisnicka stringa.");
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

         // Peto - zameni bilo koje izabrano slovo bilo kojim izabranim
         #region PETO

         string unos1 = "", unos2 = "";
         char slovo1, slovo2;
         do {
            Console.WriteLine("Koje slovo hocete da izmenite: \t");
            unos1 = Console.ReadLine();
            slovo1 = unos1[0];
         } while (unos1 == null || unos1.Length != 1);
         do {
            Console.WriteLine("Kojim slovom: \t");
            unos2 = Console.ReadLine();
            slovo2 = unos2[0];
         } while (unos2 == null || unos2.Length != 1);

         string tekst1kopija = tekst1;
         string tekst2kopija = tekst2;

         tekst1 = tekst1.ToUpper();
         tekst2 = tekst2.ToUpper();

         slovo1 = Char.ToUpper(slovo1);
         slovo2 = Char.ToUpper(slovo2);

         for (i = 0; i < tekst1.Length; i++) {
            if (tekst1[i].Equals(slovo1)) {
               tekst1 = tekst1.Replace(slovo1, slovo2);
            }
         }
         for (i = 0; i < tekst2.Length; i++) {
            if (tekst2[i].Equals(slovo1)) {
               tekst2 = tekst2.Replace(slovo1, slovo2);
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
