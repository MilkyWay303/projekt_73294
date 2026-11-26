using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    class Wypozyczenie
    {
        public int Id { get; private set; }

        public bool Czy_Zwrocone
        {
            get
            {
                return Data_Zwrotu.HasValue;
            }
        }
        public MediaItem Przedmiot { get; private set; }

        public Znajomy Znajomy { get; private set; }

        public DateTime Data_Wypozyczenia { get; private set; }

        public DateTime Termin_Zwrotu { get; private set; }

        public DateTime? Data_Zwrotu { get; private set; }

        public Wypozyczenie(MediaItem przedmiot, Znajomy znajomy, DateTime data_wypozyczenia, DateTime termin_zwrotu)
        {
            Przedmiot = przedmiot;
            Znajomy = znajomy;
            Data_Wypozyczenia = data_wypozyczenia;

            if (Data_Wypozyczenia > termin_zwrotu)
            {
                throw new ArgumentException(nameof(termin_zwrotu), "Termin zwrotu nie może być wcześniej niż data wypożyczenia");
            }
            Termin_Zwrotu = termin_zwrotu;
        }

        public void Oznacz_Jako_Zwrocone()
        {

            if (!Data_Zwrotu.HasValue)
            {
                DateTime teraz = DateTime.Now;
                if (Data_Wypozyczenia > teraz)
                {
                    throw new ArgumentException("Data zwrotu nie może być wcześniej niż data wypożyczenia", nameof(Data_Zwrotu));
                }
                Data_Zwrotu = teraz;
            }
            else
            {
                throw new InvalidOperationException("Przedmiot został już zwrócony");
            }
        }
    }
}

