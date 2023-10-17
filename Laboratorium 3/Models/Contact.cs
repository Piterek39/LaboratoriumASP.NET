using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Musisz wpisac imie")]
        [StringLength(maximumLength: 100, ErrorMessage ="Zbyt dlugie imie, maksymalnie 100 znakow")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Zly format maila")]
        [EmailAddress]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Zly format numeru telefonu")]
        public string Phone { get; set; }

        public DateTime Birth { get; set; }
    }
}
