using System;

namespace _2f_StringPoredjenjaCelina {

   class Program {
      static int brojacStringova = 0;
      static char[] SAMOGLASNICI = {
         'A', 'E', 'I', 'O', 'U'
      };

      static void Main(string[] args) {

         int i;

         Console.WriteLine("*********************************************************");
         Console.WriteLine("Program za razna poredjenja 2 korisnicka stringa.");
         Console.WriteLine("*********************************************************");

         String tekst1, tekst2;
         tekst1 = UnesiString();
         tekst2 = UnesiString();

         int opcija = -1;
         bool exit = false;
         while (exit == false) {
            while (opcija != 1 && opcija != 0) {
               opcija = MeniPrikaz();
               exit = IzvrsavanjeIzabraneOpcije(tekst1, tekst2, opcija);
            }
            opcija = -1;
         }
         Console.WriteLine();
         Console.WriteLine("\nPritisnite bilo koji taster za zavrsetak...");
         Console.ReadKey();
      }

      // PRVO - Poredjenje koji je string duzi
      private static void VeciJe(string tekst1, string tekst2) {
         String veciJe = "";
         if (tekst1.Length >= tekst2.Length) {
            veciJe = "prvi";
         }
         else {
            veciJe = "drugi";
         }
         Console.WriteLine(String.Format("Veci je {0} uneti string!", veciJe));
      }

      // Drugo - Poredjenje koji sadrzi vise samoglasnika (prolazeci kroz char niz)
      private static void ViseSamoglasnika(string tekst1, string tekst2) {
         int i;
         int brojac1 = 0, brojac2 = 0;
         for (i = 0; i < SAMOGLASNICI.Length; i++) {
            if (tekst1.Contains(SAMOGLASNICI[i].ToString())) {
               brojac1++;
            }
         }
         for (i = 0; i < SAMOGLASNICI.Length; i++) {
            if (tekst2.Contains(SAMOGLASNICI[i].ToString())) {
               ++brojac2; // ++brojac i brojac++ je u ovom kontekstu skroz isto
            }
         }
         String viseSamoglasnikaIma = "";
         if (brojac1 >= brojac2) {
            viseSamoglasnikaIma = "prvi";
         }
         else {
            viseSamoglasnikaIma = "drugi";

            // obrni mesta brojacima, radi kasnijeg ispisa
            var temp = brojac1;
            brojac1 = brojac2;
            brojac2 = temp;
            // klasicna zamena sa pomocnom promenljivom;
         }
         Console.WriteLine(String.Format("Vise samoglasnika ima {0} uneti string, i to {1}>={2}!", viseSamoglasnikaIma, brojac1, brojac2));
      }

      // Trece - Koji ima vise razlicitih slova
      private static void ViseRazlicitihSlova(string tekst1, string tekst2) {
         char slovo;
         int i;
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

         string textZaIspis = (ukSlova1 > ukSlova2) ?
            String.Format("Prvi tekst ima vise slova, i to {0}>={1}", ukSlova1, ukSlova2) :
            String.Format("Drugi tekst ima vise slova, i to {0}>={1}", ukSlova2, ukSlova1);

         Console.WriteLine(textZaIspis);
      }

      // Cetvrto - Zameni samoglasnike zvezdicom
      private static void ZamenaSlovaZvezdicom(string tekst1, string tekst2) {
         string tekst1kopija = tekst1;
         string tekst2kopija = tekst2;
         int i;

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
      }

      // Peto - zameni bilo koje izabrano slovo bilo kojim izabranim
      private static void ZamenaSlovaSlovom(string tekst1, string tekst2) {
         int i;
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
      }

      // Izbaci bilo koje zadato slovo
      private static void IzbaciSlovo(string tekst1, string tekst2) {
         int i;
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
      }

      private static string UnesiString() {
         string tekst;
         do {
            Console.WriteLine(String.Format("Unesite {0}. string po izboru: \t", ++brojacStringova));
            tekst = Console.ReadLine();
         } while (tekst == null);
         tekst = tekst.ToUpper();
         return tekst;
      }

      private static int MeniPrikaz() {
         int opcija = -1;
         bool regular = false;
         while (regular == false || opcija > 6 && opcija < 0) {
            Console.WriteLine("\n********************************************");
            Console.WriteLine("\nOdaberite opciju (nad oba stringa):");
            Console.WriteLine("1. Meri duzinu");
            Console.WriteLine("2. Broj samoglasnike");
            Console.WriteLine("3. Broj razlicita slova");
            Console.WriteLine("4. Zameni samoglasnike zvezdicom");
            Console.WriteLine("5. Zameni ciljano slovo drugim ciljanim");
            Console.WriteLine("6. Izbaci ciljano slovo");
            Console.WriteLine("0. Exit\n");
            Console.WriteLine("********************************************");
            regular = int.TryParse(Console.ReadLine(), out opcija);
         }
         return opcija;
      }

      private static bool IzvrsavanjeIzabraneOpcije(string tekst1, string tekst2, int opcija) {
         switch (opcija) {
            case 1:
               VeciJe(tekst1, tekst2);
               return false;
            case 2:
               ViseSamoglasnika(tekst1, tekst2);
               return false;
            case 3:
               ViseRazlicitihSlova(tekst1, tekst2);
               return false;
            case 4:
               ZamenaSlovaZvezdicom(tekst1, tekst2);
            return false;
            case 5:
               ZamenaSlovaSlovom(tekst1, tekst2);
            return false;
            case 6:
               IzbaciSlovo(tekst1, tekst2);
               return false;
            case 0:
               return true;
            default:
               return false;
         }
      }
   }

}
