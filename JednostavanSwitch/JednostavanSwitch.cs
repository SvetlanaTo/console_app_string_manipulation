using System;

namespace JednostavanSwitch {
   class JednostavanSwitch {
      static void Main(string[] args) {

         Console.WriteLine("****************************************************************");
         Console.WriteLine("Program koji za unetu cifru of 0 do 9 ispisuje to cifru slovima");
         Console.WriteLine("****************************************************************");

         int povratnaVrednost = 0;
         bool ispravno = false;

         // Unosim broj sve dok ne unesem cifru izmedju 0 i 9
         do {
            Console.Write("Moj izbor je cifra: ");
            ispravno = int.TryParse(Console.ReadLine(), out povratnaVrednost);
         } while (!ispravno || (povratnaVrednost < 0 || povratnaVrednost > 9));

         // \n je znak za novi red
         // Uvek pisem isti pocetak recenice, a kraj zavisi od izbora cifre
         Console.Write("\nIzbarali ste cifru ");
         switch (povratnaVrednost) {
            case 0:
               Console.Write("NULA");
               break;
            case 1:
               Console.Write("JEDAN");
               break;
            case 2:
               Console.Write("DVA");
               break;
            case 3:
               Console.Write("TRI");
               break;
            case 4:
               Console.Write("CETIRI");
               break;
            case 5:
               Console.Write("PET");
               break;
            case 6:
               Console.Write("SEST");
               break;
            case 7:
               Console.Write("SEDAM");
               break;
            case 8:
               Console.Write("OSAM");
               break;
            case 9:
               Console.Write("DEVET");
               break;
            default:
               break;
         }

         // ispis za kraj
         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }
   }
}
