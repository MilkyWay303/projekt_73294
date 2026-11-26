using System;
using System.Collections.Generic;
using System.Text;

namespace projekt_73294.Models
{
    class Znajomy
    {
        public int Id { get; private set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public string? Telefon { get; set; }

        public string? Email { get; set; }

        public Znajomy(string imie, string nazwisko, string? telefon, string? email)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Telefon = telefon;
            Email = email;
        }
    }
}
