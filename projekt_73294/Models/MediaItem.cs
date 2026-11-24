using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    public enum Format
    {
        Fizyczne,
        Cyfrowe,
    }

    abstract class MediaItem
    {
        public int Id { get; private set; }
        public string Tytul { get; private set; }

        public int Data_Wydania { get; private set; }
        public string Gatunek { get; private set; }
        public string? Opis { get; private set; }

        public Format Rodzaj { get; private set; }

        public MediaItem(string tytul, int data_wydania, string gatunek, string? opis, Format rodzaj)
        {
            Tytul = tytul;
            Data_Wydania = data_wydania;
            Gatunek = gatunek;
            Opis = opis;
            Rodzaj = rodzaj;
        }

        public abstract string Wyswietl_Szczegoly();
    }
}
