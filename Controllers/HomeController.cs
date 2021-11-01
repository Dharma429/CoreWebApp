using CoreWebApp.Interfaces;
using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public CoreDBContext _coreDBContext;
        public HomeController(CoreDBContext log1)
        {
            _coreDBContext = log1;

        }
        // GET: Customer
        public IActionResult Index()
        {
         
            return View();
        }


        public List<Teacher> SearchData()
        {
            List<Teacher> list = _coreDBContext.Teacher.ToList();
            return list;
        }


        public JsonResult SearchList()
        {
            List<Teacher> list = _coreDBContext.Teacher.ToList();
           
            return Json(list);
        }

        [HttpPost]
        public JsonResult SaveCompanyDetails([FromBody] Teacher companyDetails)
        {

            _coreDBContext.Teacher.Add(companyDetails);
            _coreDBContext.SaveChanges();
            return Json(new { });
        }
        //public IActionResult Create()
        //{
        //    return View();
        //}
        //public IActionResult Index()
        //{
        //    var list = _coreDBContext.Teacher;

        //    //var services = this.HttpContext.RequestServices;
        //    //var log = (ILog)services.GetService(typeof(ILog));
        //    // log.Info("Executing index page.");
        //    return View(list);
        //}

        //public IActionResult Update(int id)
        //{
        //    return View(_coreDBContext.Teacher.Where(a => a.Id == id).FirstOrDefault());
        //}

        //[HttpPost]
        //[ActionName("Update")]
        //public IActionResult Update_Post(Teacher teacher)
        //{
        //    _coreDBContext.Teacher.Update(teacher);
        //    _coreDBContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    var teacher = _coreDBContext.Teacher.Where(a => a.Id == id).FirstOrDefault();
        //    _coreDBContext.Teacher.Remove(teacher);
        //    _coreDBContext.SaveChanges();
        //    return RedirectToAction("Index");
        //}
    }
}
