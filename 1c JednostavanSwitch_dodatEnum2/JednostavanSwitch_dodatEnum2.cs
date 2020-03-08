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

         // Prepoznajemo da nam switch mozda nije ni trebao, radimo samo cast
         // enum vrednosti u string, ali eksplicitno one vrednosti koju smo
         // uneli sa ekrana
         string cifra = Convert.ToString((CIFRE)povratnaVrednost);

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
