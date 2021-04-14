using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FilmesCRUDRazor.Models
{
    public class Film
    {
        public int FilmId { get; set; }

        public string Title { get; set; }
        [Display(Name = "Release date of")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateLaunch { get; set; }
        public string Gender { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal()18,2")]
        public decimal Price { get; set; }



    }
}