using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    class MediaCollection
    {
        private List<MediaItem> _lista_przedmiotow = new List<MediaItem>();

        public IReadOnlyList<MediaItem> Lista_Przedmiotow
        {
            get
            {
                return _lista_przedmiotow.AsReadOnly();
            }
        }

        public bool Dodaj_Przedmiot(MediaItem przedmiot)
        {
            bool Czy_Duplikat = _lista_przedmiotow.Any(element => element.GetType() == przedmiot.GetType() && element.Tytul == przedmiot.Tytul && element.Data_Wydania == przedmiot.Data_Wydania && element.Rodzaj == przedmiot.Rodzaj);
            
            if (Czy_Duplikat)
            {
                return false;
            }
            else
            {
                _lista_przedmiotow.Add(przedmiot);
                return true;
            }
        }
    }
}
