using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using LoginReg.Models;

namespace LoginReg.Controllers
{
    public class HomeController : Controller
    {
        private Context dbContext;
        public HomeController(Context context)
        {
            dbContext = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("success")]
        public IActionResult Success()
        {
            int? userid = HttpContext.Session.GetInt32("sessionid");
            System.Console.WriteLine(userid);
            if(userid != null)
            {
                User LoggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == (int)userid);
                return View(LoggedUser); 
            }
            return RedirectToAction("Index");
        }
        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("Email","Email already in use");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                dbContext.Add(user);
                dbContext.SaveChanges();
                HttpContext.Session.SetInt32("sessionid",user.UserId);
                return RedirectToAction("Success");
            }
            return View("Index");
        }
        [HttpPost("login")]
        public IActionResult Login(User user)
        {
            User UserInDb = dbContext.Users.FirstOrDefault(u => u.Email == user.Email);
            if(UserInDb == null)
            {
                ModelState.AddModelError("Email", "Email is invalid");
                return View("Index");
            }
            PasswordHasher<User> hasher = new PasswordHasher<User>();
            PasswordVerificationResult result = hasher.VerifyHashedPassword(user, UserInDb.Password, user.Password);
            if(result == 0)
            {
                ModelState.AddModelError("Password","Password entered is incorrect");
                return View("Index");
            }
            HttpContext.Session.SetInt32("sessionid",UserInDb.UserId);
            return View("Success", UserInDb);
        }
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
