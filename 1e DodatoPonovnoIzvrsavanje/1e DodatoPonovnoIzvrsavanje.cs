using System;

namespace _1e_DodatoPonovnoIzvrsavanje {
   class Program {
      enum CIFRE {
         NULA = 0,
         JEDAN = 1,
         DVA = 2,
         TRI = 3,
         CETIRI = 4,
         PET = 5,
         SEST = 6,
         SEDAM = 7,
         OSAM = 8,
         DEVET = 9
      }

      private const string DA = "DA";
      private const string NE = "NE";

      static void Main(string[] args) {
         IspisUvoda();
         VrtiDoIzlaska();
      }

      private static void VrtiDoIzlaska() {
         bool izbor = true;

         do {
            int povratnaVrednost = UnosCifreSaEkrana();
            string cifra = PretvoriCifruUString(povratnaVrednost);
            IspisRezultata(cifra);
            izbor = DaLiNastavljamIzvrsavanje();
         } while (izbor /* ==true se podrazumeva*/);

         // ispis za kraj
         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }

      private static bool DaLiNastavljamIzvrsavanje() {

         bool losUnos = true;
         string izbor = "";

         do {
            Console.WriteLine("\nDa li zelite ponovno izvrsavanje programa (DA ili NE)?");
            izbor = Console.ReadLine();
            if (izbor != null) {
               // provera da li smo uneli bilo koji text
               // povecavanje tog teksta u velika slova
               izbor.ToUpper();
            }
            if (izbor == "DA" || izbor == "NE") {
               losUnos = false;
            }
            else {
               Console.WriteLine("Nelegalan unos. Dozvoljeno je samo DA ili NE! Pokusajte ponovo.");
            }
         } while (losUnos);

         if (izbor == "DA")
            return true;
         else
            return false;
      }

      private static void IspisRezultata(string cifra) {
         // Uvek pisem isti pocetak recenice, a kraj zavisi od izbora cifre
         Console.Write("\nIzbarali ste cifru " + cifra);
      }

      private static void IspisUvoda() {
         Console.WriteLine("****************************************************************");
         Console.WriteLine("Program koji za unetu cifru of 0 do 9 ispisuje to cifru slovima");
         Console.WriteLine("****************************************************************");
      }

      private static string PretvoriCifruUString(int povratnaVrednost) {
         return Convert.ToString((CIFRE)povratnaVrednost);
      }

      static int UnosCifreSaEkrana() {
         int povratnaVrednost = 0;
         bool ispravno = false;
         do {
            Console.Write("Moj izbor je cifra: ");
            ispravno = int.TryParse(Console.ReadLine(), out povratnaVrednost);
         } while (!ispravno || (povratnaVrednost < 0 || povratnaVrednost > 9));

         return povratnaVrednost;
      }

   }
}