using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class AuthController : Controller
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Login()
        {
            var model = new LoginModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if(model!= null)
            {
                if (model.email.Contains("@"))
                {
                    var user = _userService.GetByEmailAndPassword(model.email, model.password);
                    if (user != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        ViewBag.Message = "Giriş";
                    }

                }
                else
                {
                    ViewBag.Message = "Email";
                }
            }
            return View(model);
           
        }

        public IActionResult Register()
        {
            var model = new RegisterModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Register(RegisterModel model)
        {
            if (model.email.Contains("@"))
            {
                if (model.password == model.passwordAgain)
                {
                    var user = new User();
                    user.Email = model.email;
                    user.Password = model.password;
                    user.FullName = model.fullname;
                    user = _userService.Add(user);
                    if (user != null)
                    {
                        return RedirectToAction("Login", "Auth");
                    }
                    else
                    {
                        ViewBag.Message = "Register";
                    }
                }
                else
                {
                    ViewBag.Message = "PasswordAgain";
                }
            }
            else
            {
                ViewBag.Message = "Email";
            }

            return View(model);
        }

    }
}
