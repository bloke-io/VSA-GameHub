using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace VSA_GameHub.Models
{
    public class CreditToUser
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Кредитна картичка")]
        [Range(1000000000000,9999999999999)]
        public long creditCard { get; set; }
        public string userId { get; set; }
        public string userName { get; set; }
        public int userBalance { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Број кредити")]
        public int addedCredit { get; set; }
    }
}