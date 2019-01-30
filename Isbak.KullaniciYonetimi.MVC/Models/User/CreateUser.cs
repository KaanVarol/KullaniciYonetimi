using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Isbak.KullaniciYonetimi.MVC.Models.User
{
    public class CreateUser
    {
        [Required]
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}