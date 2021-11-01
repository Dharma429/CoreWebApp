using CoreWebApp.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreWebApp.Controllers
{
    public class LoginController : Controller
    {
        //[HttpGet]
        //public ActionResult LogOn()
        //{
        //    Session["user"] = null;

        //    if (Session["cmgInv"] == null)
        //        Session["invalidMsg"] = null;

        //    Session["cmgInv"] = null;
        //    return View();
        //}

        //public ActionResult PasswordChange()
        //{
        //    return View();

        //}

        //[HttpPost]
        //public async Task<ActionResult> LogOn(string logID, string accessCode, string returnUrl)
        //{
        //    string result = string.Empty;
        //    if (ModelState.IsValid && !string.IsNullOrWhiteSpace(logID) && !string.IsNullOrWhiteSpace(accessCode))
        //    {
        //        List<Claim> claims = new List<Claim>();
        //        claims.Add(new Claim("userName", logID));
        //        Login login = new Login();
        //        login.UserName = logID;
        //        login.Password = accessCode;


        //        Login loginDetails = await FendercareHttpClient.SendRequest<LoginViewModel, LoginViewModel>("Login/Validate", login);


        //        if (loginDetails != null)
        //        {
        //            //ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationType);


        //            //Request.GetOwinContext().Authentication.SignIn(new Microsoft.Owin.Security.AuthenticationProperties()
        //            //{
        //            //    AllowRefresh = true,
        //            //    IsPersistent = true,
        //            //    ExpiresUtc = DateTime.UtcNow.AddMinutes(5)
        //            //}, identity);

        //            //AspNetCacheManager.AddCache("userName", loginDetails.UserName);
        //            HttpContext.Session.SetString("user", "Jarvik");

        //            ViewBag.UserName = loginDetails.UserName;
        //            Session["user"] = loginDetails.UserName;
        //            if (loginDetails.RoleType == 1)
        //            {
        //                return RedirectToAction("Index", "Employee");
        //            }
        //            if (loginDetails.RoleType == 2)
        //            { return RedirectToAction("Index", "Customer"); }
        //        }
        //        else
        //        {
        //            HttpContext.Session.SetString("invalidMsg", "Invalid login");
        //            HttpContext.Session.SetString("cmgInv", "true");                  
        //            ViewBag.errorMsg = "Invalid login";
        //            return RedirectToAction("LogOn", "Login");
        //        }

        //    }

        //    return View();
        //}

        //private ActionResult RedirectToLocal(string returnUrl)
        //{
        //    if (!string.IsNullOrWhiteSpace(returnUrl) && Url.IsLocalUrl(returnUrl) && !returnUrl.Equals("/"))
        //    {
        //        return Redirect(returnUrl);
        //    }
        //    else
        //    {
        //        return RedirectToAction("Index", "Employee");
        //    }

        //}

        //public JsonResult LogOut()
        //{
        //    JsonResult result = null;
        //    Request.GetOwinContext().Authentication.SignOut(CookieAuthenticationDefaults.AuthenticationType);
        //    Session["user"] = null;
        //    Session["invalidMsg"] = null;
        //    result = Json(new { success = true, message = "Successfully logged out." });

        //    return result;
        //}
    }
}
