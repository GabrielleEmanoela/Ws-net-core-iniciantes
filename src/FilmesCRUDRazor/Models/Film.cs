using System;

namespace FilmesCRUDRazor.Models
{
    public class Film
    {

        public int FilmId { get; set; }
        public string Title { get; set; }
        public DateTime DateLaunch { get; set; }
        public string Gender { get; set; }
        public decimal Price { get; set; }

    }
}