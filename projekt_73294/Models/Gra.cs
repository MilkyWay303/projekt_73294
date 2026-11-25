using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    class Gra : MediaItem
    {
        public string Producent { get; private set; }

        public string Platforma { get; private set; }

        public Gra(string tytul, int data_wydania, string gatunek, string? opis, Format rodzaj, string producent, string platforma) : base(tytul, data_wydania, gatunek, opis, rodzaj)
        {
            Producent = producent;
            Platforma = platforma;
        }

        public override string Wyswietl_Szczegoly()
        {
            return $"Tytuł: {Tytul}\n Producent: {Producent}\n Rok Wydania: {Data_Wydania}\n Platforma: {Platforma}";
        }
    }
}
