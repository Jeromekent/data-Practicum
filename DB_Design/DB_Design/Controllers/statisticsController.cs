using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_Design.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DB_Design.Controllers
{
    public class statisticsController : Controller
    {
        // GET: /<controller>/
        public IActionResult attendance([FromQuery]int id)
        {
            using (var context = new staff_attendanceContext())
            {
                var att = context.AttendanceStatistic.ToList();
                var work = context.Worker.ToList();
                if (id != 0)
                {
                    work=work.FindAll(o => o.WDepartment == id);
                    List<AttendanceStatistic>[] a = new List<AttendanceStatistic>[work.Count];
                    for(int i = 0; i < work.Count; i++)//该部门每个员工的出勤统计信息分开存储
                    {
                        a[i] = att.FindAll(o => o.Id == work[i].WId);
                    }
                    att = a[0];
                    for (int i = 0; i < work.Count-1; i++)//list合并
                    {
                        att.AddRange(a[i + 1]);
                    }
                }
                this.ViewData["att"] = att;
                if (id > 0) this.ViewBag.name = att[0].Name;
                var department = context.Department.ToList();
                this.ViewData["dep"] = department;
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



