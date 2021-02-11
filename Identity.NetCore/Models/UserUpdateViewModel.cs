using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.NetCore.Models
{
    public class UserUpdateViewModel 
    {
        [Display(Name = "Email:")]
        [Required(ErrorMessage = "Email Alanı Gereklidir.")]
        [EmailAddress(ErrorMessage ="Lütfen geçerli bir email adresi giriniz.")]
        public string Email { get; set; }
        [Display(Name = "Telefon:")]
        public string PhoneNumber { get; set; }
        public string PictureUrl { get; set; }
        public IFormFile Picture { get; set; }
        [Required(ErrorMessage = "Ad Alanı Gereklidir.")]
        [Display(Name = "Ad:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "SoyAd İsim Alanı Gereklidir.")]
        [Display(Name = "SoyAd:")]
        public string SurName { get; set; }
    }
}
