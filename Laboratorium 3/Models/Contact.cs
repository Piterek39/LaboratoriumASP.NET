﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using Data.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Laboratorium_3.Models
{
    public class Contact
    {
       
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage ="Musisz wpisac imie")]
        [StringLength(maximumLength: 100, ErrorMessage ="Zbyt dlugie imie, maksymalnie 100 znakow")]
        [Display(Name = "Wpisz imię")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Zly format maila")]
        [EmailAddress]
        [Display(Name = "Wpisz adres email")]
        public string Email { get; set; }
        [Phone(ErrorMessage ="Zly format numeru telefonu")]
        [Display(Name = "Wpisz numer telefonu")]
        public string Phone { get; set; }
        [Display(Name = "Podaj date urodzenia")]
        public DateTime Birth { get; set; }
        [Display(Name = "Wybierz priorytet")]
        public Priority Priority { get; set; }
        [HiddenInput]
        public DateTime Created { get; set; }
        [HiddenInput]
        public int? OrganizationId { get; set; }

        [ValidateNever]
        public List<SelectListItem> Organizations { get; set; }
    }
}
