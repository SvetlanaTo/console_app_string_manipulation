using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_StringPoredjenja {

   class StringPoredjenjeDuzine {

      static void Main(string[] args) {
         Console.WriteLine("*********************************************************");
         Console.WriteLine("Program za poredjenje duzine dva uneta korisnicka stringa.");
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

         // PRVO - Poredjenje koji je string duzi
         #region PRVO
         String veciJe = "";
         if (tekst1.Length >= tekst2.Length) {
            veciJe = "prvi";
         }
         else {
            veciJe = "drugi";
         }
         Console.WriteLine(String.Format("Veci je {0} uneti string!", veciJe));
         #endregion

         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }
   }
}
