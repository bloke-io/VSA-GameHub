using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VSA_GameHub.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Е-адреса")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Код")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Запамти го овој прелистувач?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Е-адреса")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Е-адреса")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Лозинка")]
        public string Password { get; set; }

        [Display(Name = "Запамти ме?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Име")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Презиме")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Години")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Адреса на живеење")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Држава")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Полето е задолжително")]
        [Display(Name = "Град")]
        public string City { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Е-адреса")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} мора да биде долго барем {2} карактери.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Лозинка")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потврди лозинка")]
        [Compare("Password", ErrorMessage = "Лозинките не се совпаѓаат.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Е-адреса")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} мора да биде долго барем {2} карактери.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Лозинка")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потврди лозинка")]
        [Compare("Password", ErrorMessage = "Лозинките не се совпаѓаат.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Е-адреса")]
        public string Email { get; set; }
    }
}
