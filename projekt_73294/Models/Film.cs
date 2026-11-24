using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    class Film : MediaItem
    {
        public string Rezyser { get; private set; }

        public int Czas_Trwania { get; private set; }

        public string? Studio { get; private set; }

        public Film(string tytul, int data_wydania, string gatunek, string? opis, Format rodzaj, string rezyser, int czas_trwania, string? studio) : base(tytul, data_wydania, gatunek, opis, rodzaj)
        {
            Rezyser = rezyser;
            Czas_Trwania = czas_trwania;
            Studio = studio;
        }

        public override string Wyswietl_Szczegoly()
        {
            return $"Tytuł: {Tytul}\n Reżyser: {Rezyser}\n Czas trwania: {Czas_Trwania}\n Rok Wydania: {Data_Wydania}\n Studio: {Studio}";
        }
    }
}
