using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace VSA_GameHub.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
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
      
     
        public int Balance { get; set; }
        
        public int NumberOfGames { get; set; }
        
        public virtual List<Game> All_Games { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<VSA_GameHub.Models.Game> Games { get; set; }

        public System.Data.Entity.DbSet<VSA_GameHub.Models.GameToUser> GameToUsers { get; set; }

        public System.Data.Entity.DbSet<VSA_GameHub.Models.CreditToUser> CreditToUsers { get; set; }
    }
}