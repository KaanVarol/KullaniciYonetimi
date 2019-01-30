using Isbak.KullaniciYonetimi.Entities.Users;
using Isbak.KullaniciYonetimi.MVC.Models.User;
using Isbak.KullaniciYonetimi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Isbak.KullaniciYonetimi.MVC.Controllers
{
    public class AdminController : Controller
    {

        private readonly UserService _userService;

        public AdminController()
        {
            _userService = new UserService();
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CreateUser(CreateUser model)
        {
            if (ModelState.IsValid)
            {

                User createuser = new Entities.Users.User()
                {

                    Username = model.Username,
                    Email = model.Email,
                    Password = model.Password
                };
                _userService.UserCreate(createuser);
            }

            return View(model);

        }
    }
}