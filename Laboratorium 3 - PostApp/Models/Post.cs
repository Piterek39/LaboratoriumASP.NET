using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___PostApp.Models
{
    public class Post
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "Musisz wpisac tresc")]
        [StringLength(maximumLength: 1000, ErrorMessage = "Zbyt dlugi post, maksymalnie 1000 znakow")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Podaj autora")]
        public string Autor { get; set; }
        [HiddenInput]
        public DateTime PostDate { get; set; }
        [Required(ErrorMessage = "Podaj tag")]
        public string Tag { get; set; }
       public string Comment { get; set; }  
    }
}
