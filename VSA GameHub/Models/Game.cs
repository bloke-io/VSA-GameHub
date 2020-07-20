using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VSA_GameHub.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name="Име на игра")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name="Краток опис на играта")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Датум на издавање")]
        public DateTime ReleaseDate { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display (Name = "Постер")]
        public string PosterUrl { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name ="Издавач")]
        public string Company { get; set; }
        [Required(ErrorMessage ="Полето е задолжително")]
        [Display (Name ="Рејтинг")]
        public float Rating { get; set; }
    }
}