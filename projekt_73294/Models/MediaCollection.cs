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

    }
}
