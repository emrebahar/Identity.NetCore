using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.NetCore.Models
{
    public class UserSignInViewModel
    {   [Display(Name = "Kullanıci Adı:")]
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez.")]
        public string UserName { get; set; }
        [Display(Name = "Şifre:")]
        [Required(ErrorMessage = "Şifre Boş Geçilemez.")]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
