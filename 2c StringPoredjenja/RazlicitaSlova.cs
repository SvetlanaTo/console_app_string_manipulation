using System;

namespace _2_StringPoredjenja {

   class StringPoredjenja {

      static void Main(string[] args) {

         int i;

         Console.WriteLine("***********************************************************************");
         Console.WriteLine("Program za prebrojavanje razlicitih slova u 2 uneta korisnicka stringa.");
         Console.WriteLine("***********************************************************************");

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

         // Trece - Koji ima vise razlicitih slova
         #region TRECE
         char slovo;
         int ukSlova1 = 0, ukSlova2 = 0;
         for (slovo = 'A'; slovo <= 'Z'; slovo++) {
            for (i = 0; i < tekst1.Length; i++) {
               if (slovo == tekst1[i]) {
                  ukSlova1++;
                  break;
               }
            }
         }

         for (slovo = 'A'; slovo <= 'Z'; slovo++) {
            for (i = 0; i < tekst2.Length; i++) {
               if (slovo == tekst2[i]) {
                  ukSlova2++;
                  break;
               }
            }
         }

       // Koriscenje ternarnog operatora
       // condition ? first_expression : second_expression;
            // textZaIspis dodeljuje mu se vrednost 
                        //first_exp ako je condition true 
                        //second_exp ako je condition false

         string textZaIspis = (ukSlova1 > ukSlova2) ?
            String.Format("Prvi tekst ima vise slova, i to {0}>={1}", ukSlova1, ukSlova2) :
            String.Format("Drugi tekst ima vise slova, i to {0}>={1}", ukSlova2, ukSlova1);

         Console.WriteLine(textZaIspis);
         #endregion

         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }
   }
}
