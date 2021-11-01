using CoreWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CoreWebApp.Controllers
{
    public class MainController : Controller
    {
        //private static IHttpContextAccessor _httpContextAccessor;

        //public static void Configure(IHttpContextAccessor httpContextAccessor)
        //{
        //    _httpContextAccessor = httpContextAccessor;
        //}
        //CoreDBContext _coreDBContext;
        //protected MainController()
        //{
        //    Configure((IHttpContextAccessor)HttpContext);
        //       var services = _httpContextAccessor.HttpContext.RequestServices;
        //    _coreDBContext = (CoreDBContext)services.GetService(typeof(CoreDBContext));
        //}
        //public CoreDBContext _coreDBContext { get; set; }

        //public MainController(IHttpContextAccessor httpContextAccessor) 
        //{
        //  var services =  this.HttpContext.RequestServices;
        //    _coreDBContext = (CoreDBContext)services.GetService(typeof(CoreDBContext));
        //}
    }
}
