using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_Design.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DB_Design.Controllers
{
    public class staffController : Controller
    {
        // GET: /<controller>/

        public IActionResult find_achievements()
        {
            using (var context = new staff_attendanceContext())
            {

            }
                return View();
        }
        public bool check_staff(int id = -1,string name=" ")
        {
            using (var context = new staff_attendanceContext())
            {
                var worker = context.Worker.ToList();
                if (worker.Find(o => o.WId == id && o.WName == name) != null)
                    return true;
            }
            return false;
        }

        public IActionResult attendance([FromQuery]int id)
        {
            using (var context = new staff_attendanceContext())
            {
                this.ViewBag.name = "所有人";
                var att = context.AttendanceStatistic.ToList();
                if (id != 0)
                    att.RemoveAll(o => o.Id != id);
                this.ViewData["att"] = att;
                if (id > 0) this.ViewBag.name = att[0].Name;
            }
            return View();
        }
        public IActionResult bussiness([FromQuery]int id)
        {
            using (var context = new staff_attendanceContext())
            {
                this.ViewBag.name = "所有人";
                var bus = context.BusinessStatistic.ToList();
                if (id != 0)
                    bus.RemoveAll(o => o.Id != id);
                this.ViewData["bus"] = bus;
                if (id > 0) this.ViewBag.name = bus[0].Name;
            }
            return View();
        }
        public IActionResult offwork([FromQuery]int id)
        {
            using (var context = new staff_attendanceContext())
            {
                this.ViewBag.name = "所有人";
                var off = context.OffworkStatistic.ToList();
                if (id != 0)
                    off.RemoveAll(o => o.Id != id);
                this.ViewData["off"] = off;
                if (id > 0) this.ViewBag.name = off[0].Name;
            }
            return View();
        }
        public IActionResult overtime([FromQuery]int id)
        {
            using (var context = new staff_attendanceContext())
            {
                this.ViewBag.name = "所有人";
                var over = context.OvertimeStatistic.ToList();
                if (id != 0)
                    over.RemoveAll(o => o.Id != id);
                this.ViewData["over"] = over;
                if (id > 0) this.ViewBag.name = over[0].Name;
            }
            return View();
        }

    }
}
