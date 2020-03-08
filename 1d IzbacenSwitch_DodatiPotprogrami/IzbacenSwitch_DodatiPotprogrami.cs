using System;

namespace _1d_IzbacenSwitch_DodatiPotprogrami {
   class IzbacenSwitch_DodatiPotprogrami {
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

      static void Main(string[] args) {

         IspisUvoda();

         int povratnaVrednost = UnosCifreSaEkrana();
         string cifra = PretvoriCifruUString(povratnaVrednost);

         IspisRezultata(cifra);
      }

      private static void IspisRezultata(string cifra) {
         // Uvek pisem isti pocetak recenice, a kraj zavisi od izbora cifre
         Console.Write("\nIzbarali ste cifru " + cifra);

         // ispis za kraj
         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
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


//private static int meniPrikaz() {
//   int opcija = -1;
//   bool regular = false;
//   while (regular == false || opcija > 5 && opcija < 0) {
//      Console.WriteLine("\nOdaberite opciju:");
//      Console.WriteLine("1. Nastavi unos");
//      Console.WriteLine("2. Sortiranje po JMBG-u");
//      Console.WriteLine("3. Sortiranje po imenu");
//      Console.WriteLine("4. Sortiranje po prezimenu");
//      Console.WriteLine("5. Sortiranje po gradu");
//      Console.WriteLine("0. Exit\n");
//      regular = int.TryParse(Console.ReadLine(), out opcija);
//   }
//   return opcija;
//}

//private static bool izvrsavanjeIzabraneOpcije(int opcija) {
//   switch (opcija) {
//      case 1:
//      return false;
//      case 2:

//      return false;
//      case 3:

//      return false;
//      case 4:

//      return false;
//      case 5:

//      return false;
//      case 0:
//      return true;
//      default:
//      return false;
//   }
//}

