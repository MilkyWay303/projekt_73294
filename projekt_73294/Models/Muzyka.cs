using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    class Muzyka : MediaItem
    {
        public string Wykonawca { get; private set; }

        public int Czas_Trwania { get; private set; }

        public string? Wytwornia { get; private set; }

        public Muzyka(string tytul, int data_wydania, string gatunek, string? opis, Format rodzaj, string wykonawca, int czas_trwania, string? wytwornia) : base(tytul, data_wydania, gatunek, opis, rodzaj)
        {
            Wykonawca = wykonawca;
            Czas_Trwania = czas_trwania;
            Wytwornia = wytwornia;
        }

        public override string Wyswietl_Szczegoly()
        {
            return $"Tytuł: {Tytul}\n Wykonawca: {Wykonawca}\n Czas trwania: {Czas_Trwania}\n Rok Wydania: {Data_Wydania}\n Wytwórnia: {Wytwornia}";
        }
    }
}
