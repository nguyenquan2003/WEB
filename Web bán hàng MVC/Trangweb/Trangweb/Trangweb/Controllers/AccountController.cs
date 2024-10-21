using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Trangweb.Models;
using Trangweb.ViewModel;
using Trangweb.Identity;
using System.Web.Helpers;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace Trangweb.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterVM rmv)
        {
            if (ModelState.IsValid)
            {
                var appDBContext = new AppDbContext();
                var userStore = new AppUserStore(appDBContext);
                var userManager = new AppUserManager(userStore);
                var passwdHash = Crypto.HashPassword(rmv.Password);
                var user = new AppUser()
                {
                    Email = rmv.Email,
                    UserName = rmv.Username,
                    PasswordHash = passwdHash,
                    City = rmv.City,
                    Birthday = rmv.Birthday,
                    Address = rmv.Address,
                    PhoneNumber = rmv.Mobile
                };
                IdentityResult identityResult= userManager.Create(user);
                if(identityResult.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Customer");
                    var authenManager =HttpContext.GetOwinContext().Authentication;
                    var userIdentity= userManager.CreateIdentity(user,DefaultAuthenticationTypes.ApplicationCookie);
                    authenManager.SignIn(new AuthenticationProperties(),
                        userIdentity);
                }
                return RedirectToAction("Index", "Home");
            }    
            else
            {
                ModelState.AddModelError("New Error", "Dữ liệu không hợp lệ");
                return View();
            }    

                
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginVM lvm)
        {
            var appDBContext = new AppDbContext();
            var userStore = new AppUserStore(appDBContext);
            var userManager = new AppUserManager(userStore);
            var user =userManager.Find(lvm.Username, lvm.Password);
            if (user!=null)
            {
                var authenManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authenManager.SignIn(new AuthenticationProperties(),
                     userIdentity);
                var roles = userManager.GetRoles(user.Id);
                if (roles.Contains("Admin"))
                {
                    return RedirectToAction("Index", "Product",  new { area = "Admin" });
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                ModelState.AddModelError("myError", "Không đúng user hặc mật khẩu.");
                return View();
            }    
        }
        public ActionResult Logout()
        {
            var authenManager = HttpContext.GetOwinContext().Authentication;
            authenManager.SignOut();
            return RedirectToAction("Index", "Home");
        }
        //public ActionResult MyProfile(int id, string search="") 
        //{
        //    //myDbContext db= new myDbContext();
        //    //AppUser name= db.App
        //    //List<Category> loai = db.Categories.ToList();
        //    //ViewBag.Loai = loai;
        //    //ViewBag.Search = search;


        //}
    }
}