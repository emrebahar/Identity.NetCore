using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.NetCore.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name = "Kullanici Adı:")]
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilimez.")]
        public string UserName { get; set; }
        [Display(Name = "Şifre:")]
        [Required(ErrorMessage = "Şifre Boş Geçilimez.")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrar:")]
        [Compare("Password",ErrorMessage = "Parolalar Eşleşmiyor")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Ad:")]
        [Required(ErrorMessage = "Ad Boş Geçilimez.")]
        public string Name { get; set; }
        [Display(Name = "SoyAd:")]
        [Required(ErrorMessage = "SoyAd Boş Geçilimez.")]
        public string SurName { get; set; }
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email Boş Geçilimez.")]
        public string Email { get; set; }
    }
}
