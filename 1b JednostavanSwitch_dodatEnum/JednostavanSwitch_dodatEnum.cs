using System;

namespace JednostavanSwitch_dodatEnum {
   class JednostavanSwitch_dodatEnum {

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

         // uvodimo promenljivu cifra, koja se menja u switchu
         // enum vrednost pretvaramo u string ili pozivanjem ugradjene metode ToString()
         // ili eksplicitnim konvertovanjem u string
         string cifra = "";
         switch (povratnaVrednost) {
            case 0:
               cifra = CIFRE.NULA.ToString();
            break;
            case 1:
               cifra = CIFRE.JEDAN.ToString();
            break;
            case 2:
               cifra = Convert.ToString(CIFRE.DVA);
            break;
            case 3:
               cifra = Convert.ToString(CIFRE.TRI);
            break;
            case 4:
               cifra = Convert.ToString(CIFRE.CETIRI);
            break;
            case 5:
               cifra = CIFRE.PET.ToString();
            break;
            case 6:
               cifra = CIFRE.SEST.ToString();
            break;
            case 7:
               cifra = Convert.ToString(CIFRE.SEDAM);
            break;
            case 8:
               cifra = Convert.ToString(CIFRE.OSAM);
            break;
            case 9:
               cifra = CIFRE.DEVET.ToString();
            break;
            default:
            break;
         }

         // \n je znak za novi red
         // Uvek pisem isti pocetak recenice, a kraj zavisi od izbora cifre
         Console.Write("\nIzbarali ste cifru " + cifra);

         // ispis za kraj
         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }

   }
}
