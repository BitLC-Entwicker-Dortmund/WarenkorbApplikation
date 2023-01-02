using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarenkorbApplikation.Models;
using WarenkorbApplikation.Views;

namespace WarenkorbApplikation {
    class Program {
        static void Main ( string [ ] args ) {
            // Beispie
            // l-Artikel
            Artikel art_1 = new Artikel ( ) 
            { Artikel_ID=4711, Name="HDR 1", Preis=9.99, Mengeneinheit="Stück" };
            // Beispiel-Artikel
            Artikel art_2 = new Artikel ( ) { Artikel_ID = 4712 , Name = "HDR 2" , Preis = 9.99 , Mengeneinheit = "Stück" };
            // Beispiel-Artikel
            Artikel art_3 = new Artikel ( ) { Artikel_ID = 4713 , Name = "HDR 3" , Preis = 9.99 , Mengeneinheit = "Stück" };

            int auswahl = Eingabe_01.e_01 ( );

            Angebot angebot_123 = new Angebot ( auswahl );

            string artikel = EingabeArtikel.AuswahlArtikel ( );
            int anzahl = EingabeArtikel.AnzahlArtikel ( );

            angebot_123.AddArtikel ( art_1, anzahl );
            //angebot_123.AddArtikel ( art_2, 24 );
            //angebot_123.AddArtikel ( art_3, 24 );

            Console.WriteLine (angebot_123.BerechneEndbetrag ( ));
            Console.WriteLine ( "ok");
            Console.Read ( );
        }
    }
}
