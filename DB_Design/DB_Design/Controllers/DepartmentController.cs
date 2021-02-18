using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_Design.Models;
using Microsoft.AspNetCore.Mvc;

namespace DB_Design.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new staff_attendanceContext())
            {
                var list = db.Department.ToList();
                return View("Index", list);
            }
        }

        [HttpPost]
        public string Add(Department model)//新增部门记录
        {
            using (var db = new staff_attendanceContext())
            {
                db.Department.Add(model);
                db.SaveChanges();
            }
            return "ok";
        }

        [HttpPost]
        public string Update(Department model)//修改部门记录
        {
            using (var db = new staff_attendanceContext())
            {
                var business = db.Department.First(x => x.DId == model.DId);
                business.DName = model.DName;
                db.SaveChanges();
                return "ok";
            }
        }

        [HttpGet]
        public string Delete(int DId)//删除出差记录
        {
            using (var db = new staff_attendanceContext())
            {
                var business = db.Department.First(x => x.DId == DId);
                db.Department.Remove(business);
                db.SaveChanges();
            }
            return "ok";
        }

        [HttpGet]
        public JsonResult CheckDelete(int DId)//删除出差记录
        {
            using (var db = new staff_attendanceContext())
            {
                var work = db.Worker.FirstOrDefault(x => x.WDepartment == DId);
                return Json(work);
            }
        }
    }
}