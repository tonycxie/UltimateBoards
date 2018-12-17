using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using UltimateBoards.Models;
using System.Linq;
using Microsoft.AspNetCore.Identity;

namespace UltimateBoards.Controllers
{
    public class HomeController : Controller
    {
        private UltimateBoardsContext dbContext;

        public HomeController(UltimateBoardsContext context)
        {
            dbContext = context;
        }

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                User newUSer = new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Password = user.Password
                };
                dbContext.Add(newUSer);
                dbContext.SaveChanges();
                var dbUser = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
                HttpContext.Session.SetInt32("UserId", dbUser.UserId);
                return RedirectToAction("Success", "App", new {id = dbUser.UserId});
            }
            return View("Index");
        }

        [HttpPost("signin")]
        public IActionResult Signin(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var dbUser = dbContext.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                if (dbUser == null)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, dbUser.Password, user.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", dbUser.UserId);
                return RedirectToAction("Success", "App", new {id = dbUser.UserId});
            }
            return View("Login");
        }
    }
}
