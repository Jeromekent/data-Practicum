using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DB_Design.Models;
using DB_Design.MyModels;
using Microsoft.AspNetCore.Mvc;

namespace DB_Design.Controllers
{
    public class BusinessController : Controller
    {
        public IActionResult Index()
        {
            using (var db=new staff_attendanceContext())
            {
                var list = db.Business.ToList();
                return View("Index",list);
            } 
        }

        public IActionResult Query_Page()//显示模糊查询+组合查询页面
        {
                return View();
        }

        [HttpPost]
        public string Add(Business model)//新增出差记录
        {
            using (var db = new staff_attendanceContext())
            {
                db.Business.Add(model);
                db.SaveChanges();
            }
            return "ok";
        }

        [HttpPost]
        public string Update(Business model)//修改出差记录
        {
            using (var db = new staff_attendanceContext())
            {
                if (db.Business.Where(x => x.BusNum == model.BusNum).Count() > 0)
                {
                    var business = db.Business.First(x => x.BusNum == model.BusNum);
                    business.BusStartTime = model.BusStartTime;
                    business.BusEndTime = model.BusEndTime;
                    business.BusDuration = model.BusDuration;
                    db.SaveChanges();
                }
                return "ok";
            }
        }

        [HttpGet]
        public string Delete(int BusNum)//删除出差记录
        {
            using (var db = new staff_attendanceContext())
            {
                var business = db.Business.First(x => x.BusNum == BusNum);
                db.Business.Remove(business);
                db.SaveChanges();
            }
            return "ok";
        }

   
        [HttpGet]
        public JsonResult Query(int Id,string Name)//查询出差记录
        {
            ArrayList list = new ArrayList();//用于得到在页面中展示的数组
            
            using (var db = new staff_attendanceContext())
            {
                //如果给的条件说工号，精确查询
                if (Id != 0)
                {
                    //得到全部出差记录
                    var bus = db.Business.Where(x => x.WId == Id).ToList();
                    //得到员工信息
                    var workers = db.Worker.ToList();

                    //对出差记录和筛选后的员工信息做笛卡尔积,得到在页面上展示的数组
                    for (int i = 0; i < bus.Count; i++)
                    {
                        for (int j = 0; j < workers.Count; j++)
                            if (bus[i].WId == workers[j].WId)
                            {
                                Business_Display busdis = new Business_Display()
                                {
                                    BusNum = bus[i].BusNum,
                                    WId = bus[i].WId,
                                    WName = workers[j].WName,
                                    BusStartTime = bus[i].BusStartTime,
                                    BusEndTime = bus[i].BusEndTime,
                                    BusDuration = bus[i].BusDuration
                                };
                                list.Add(busdis);
                                break;
                            }
                    }
                    return Json(list);
                }

                //如果给的条件是姓名，模糊查询
                if (Name != null)
                {
                    //得到全部出差记录
                    var bus = db.Business.ToList();         
                    //把员工信息用姓名模糊查询进行筛选
                    var workers = db.Worker.Where(x => x.WName.Contains(Name)).ToList();
                   
                    //对出差记录和筛选后的员工信息做笛卡尔积,得到在页面上展示的数组
                    for (int i = 0; i < bus.Count; i++)
                    {
                        for(int j=0; j<workers.Count;j++)
                            if (bus[i].WId==workers[j].WId)
                            {
                                Business_Display busdis = new Business_Display()
                                {
                                    BusNum = bus[i].BusNum,
                                    WId = bus[i].WId,
                                    WName = workers[j].WName,
                                    BusStartTime = bus[i].BusStartTime,
                                    BusEndTime = bus[i].BusEndTime,
                                    BusDuration = bus[i].BusDuration
                                };
                                list.Add(busdis);
                                break;
                            }
                    }
                    return Json(list);
                }

                return Json(null); 
                
            }
            
        }
    }
}