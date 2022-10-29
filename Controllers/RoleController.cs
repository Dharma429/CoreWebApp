using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApp.Controllers
{
    public class RoleController : Controller
    {
        public CoreDBContext _coreDBContext;
        public RoleController(CoreDBContext log1)
        {
            _coreDBContext = log1;

        }
        // GET: Customer
        public IActionResult Index()
        {

            return View();
        }


        public List<Role> SearchData()
        {
            List<Role> list = _coreDBContext.Role.ToList();
            return list;
        }


        public JsonResult SearchList([FromBody] string role)
        {
            var record = _coreDBContext.Role.ToList().Where(r => r.RoleName == role).FirstOrDefault();

            return Json(record != null ? true : false) ;
        }

        [HttpPost]
        public JsonResult SaveRoleDetails([FromBody] Role role)
        {
            role.CreatedDate = DateTime.Now;
            role.ModifiedDate = DateTime.Now;
            if (role.RoleId > 0)
                _coreDBContext.Update(role);
            else
                _coreDBContext.Role.Add(role);

            _coreDBContext.SaveChanges();
            return Json(new { });
        }

        [HttpPost]
        public JsonResult Delete([FromBody] string id)
        {
            Role role = _coreDBContext.Role.Find(Convert.ToInt32(id));
            _coreDBContext.Role.Remove(role);
            _coreDBContext.SaveChanges();
            return Json(new { });
        }
    }
}
