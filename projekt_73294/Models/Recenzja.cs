using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace projekt_73294.Models
{
    class Recenzja
    {
        private int _ocena;

        public int Id { get; private set; }

        public string? Tresc { get; set; }

        public DateTime Data_Wystawienia { get; private set; }
        public int Ocena
        {
            get
            {
                return _ocena;
            }
            set
            {   
                if (value > 0 && value <= 10)
                {
                    _ocena = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value),"Ocena powina być 1-10");
                }
                
            } 
        }

        public Recenzja(int ocena, string? tresc, DateTime data_wystawienia)
        {
            Ocena = ocena;
            Tresc = tresc;
            Data_Wystawienia = data_wystawienia;
        }
    }
}
