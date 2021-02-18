using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DB_Design.Models;
using DB_Design.MyModels;
using DocumentFormat.OpenXml.Spreadsheet;
using ExcelDataReader;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DB_Design.Controllers
{
    public class managerController : Controller
    {
        // GET: /<controller>/
        
        
        public IActionResult import( string address=null)
        {
             using (var context = new staff_attendanceContext())
            {
                if (address != null)//如果有地址
                {
                    Worker n = new Worker();
                    System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                    using (FileStream x = new FileStream(address, FileMode.Open, FileAccess.Read))
                    {
                        IExcelDataReader excelreader = ExcelReaderFactory.CreateOpenXmlReader(x);
                        DataSet result = excelreader.AsDataSet();
                        DataTable sheet = result.Tables[0];
                        for(int i = 0; i < sheet.Rows.Count; i++)
                        {
                            n.WId = int.Parse(sheet.Rows[i][0].ToString());
                            n.WName = sheet.Rows[i][1].ToString();
                            n.WSex = sheet.Rows[i][2].ToString();
                            n.WAge = int.Parse(sheet.Rows[i][3].ToString());
                            n.WTelephone = sheet.Rows[i][4].ToString();
                            n.WDepartment = int.Parse(sheet.Rows[i][5].ToString());
                            n.WPost = sheet.Rows[i][6].ToString();
                            n.WDuty = sheet.Rows[i][7].ToString();
                            n.WWage = int.Parse(sheet.Rows[i][8].ToString());
                            n.WOnJob = sheet.Rows[i][9].ToString();

                            context.Worker.Add(n);
                            context.SaveChanges();
                        }
                    }
                }
                var staff = context.Worker.ToList();
                this.ViewData["staff"] = staff;
            }
            return View();
        }






        public IActionResult overtime_information()
        {
            using (var context = new staff_attendanceContext())
            {
                var over = context.Overtime.ToList();
                var staff = context.Worker.ToList();
                this.ViewData["staff"] = staff;
                this.ViewData["over"] = over;
            }
                return View();
        }
        public bool detele_over(int num = -1)
        {
            using (var context=new staff_attendanceContext())
            {
                var over = context.Overtime.ToList();
                if (num != -1)
                {
                    context.Overtime.Remove(over[num]);
                    context.SaveChanges();
                    return true;
                }
                    
            }
            return false;
        }
        public bool change_over(int num = -1,int id=-1, string starttime=null, string endtime=null)
        {
            using (var context = new staff_attendanceContext())
            {
                var over = context.Overtime.ToList();
                if (num != -1)
                {
                    var x = over[num];
                    context.Overtime.Remove(over[num]);
                    context.SaveChanges();
                    x.WId = id;
                    x.OverStartTime = DateTime.Parse(starttime);
                    x.OverEndTime = DateTime.Parse(endtime);
                    TimeSpan dur = (TimeSpan)(x.OverEndTime - x.OverStartTime);
                    x.OverDuration = dur.Hours;
                    context.Overtime.Add(x);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool add_over(int num = -1, int id = -1, string starttime = null, string endtime = null)
        {
            
            using (var context = new staff_attendanceContext())
            {
                Overtime x = new Overtime();
                x.WId = id;
                x.OverNum = num;
                x.OverStartTime = DateTime.Parse(starttime);
                x.OverEndTime = DateTime.Parse(endtime);
                TimeSpan dur = (TimeSpan)(x.OverEndTime - x.OverStartTime);
                x.OverDuration = dur.Hours;
                context.Overtime.Add(x);
                context.SaveChanges();
            }
            return false;
        }
        public string over_search(int id=-1,string name = null)
        {
            string ans = "";
            using (var context = new staff_attendanceContext())
            {
                if (id != -1)
                {
                    //得到全部出差记录
                    var over = context.Overtime.Where(x => x.WId == id).ToList();
                    //得到员工信息
                    var workers = context.Worker.ToList();
                    for(int i = 0; i < over.Count; i++)
                    {
                        ans = ans + "<tr><td>" + (i + 1) + "</td>";
                        ans = ans + "<td>" + over[i].OverNum + "</td>";
                        ans = ans + "<td>" + over[i].WId + "</td>";
                        ans = ans + "<td>" + workers[id-1].WName + "</td>";
                        ans = ans + "<td>" + over[i].OverStartTime + "</td>";
                        ans = ans + "<td>" + over[i].OverEndTime + "</td>";
                        ans = ans + "<td>" + over[i].OverDuration + "</td></tr>";
                    }
                    return ans;
                }

                //如果给的条件是姓名，模糊查询
                else if (name != null)
                {
                    //把员工信息用姓名模糊查询进行筛选
                    var workers = context.Worker.Where(x => x.WName.Contains(name)).ToList();
                    for (int i = 0; i < workers.Count; i++)
                    {
                        var over = context.Overtime.Where(x => x.WId == workers[i].WId).ToList();
                        for(int j = 0; j < over.Count; j++)
                        {
                            ans = ans + "<tr><td>" + (j + 1) + "</td>";
                            ans = ans + "<td>" + over[j].OverNum + "</td>";
                            ans = ans + "<td>" + over[j].WId + "</td>";
                            ans = ans + "<td>" + workers[i].WName + "</td>";
                            ans = ans + "<td>" + over[j].OverStartTime + "</td>";
                            ans = ans + "<td>" + over[j].OverEndTime + "</td>";
                            ans = ans + "<td>" + over[j].OverDuration + "</td><tr>";
                        }
                    }
                    return ans;
                }

            }
            return null;
        }


        public IActionResult offwork_information()
        {
            using (var context = new staff_attendanceContext())
            {
                var off = context.Offwork.ToList();
                var staff = context.Worker.ToList();
                this.ViewData["staff"] = staff;
                this.ViewData["off"] = off;
            }
            return View();
        }
        public bool detele_off(int num = -1)
        {
            using (var context = new staff_attendanceContext())
            {
                var off = context.Offwork.ToList();
                if (num != -1)
                {
                    context.Offwork.Remove(off[num]);
                    context.SaveChanges();
                    return true;
                }

            }
            return false;
        }
        public bool change_off(int num = -1, int id = -1, string starttime = null, string endtime = null)
        {
            using (var context = new staff_attendanceContext())
            {
                var off = context.Offwork.ToList();
                if (num != -1)
                {
                    var x = off[num];
                    context.Offwork.Remove(off[num]);
                    context.SaveChanges();
                    x.WId = id;
                    x.OffStartTime = DateTime.Parse(starttime);
                    x.OffEndTime = DateTime.Parse(endtime);
                    TimeSpan dur = (TimeSpan)(x.OffEndTime - x.OffStartTime);
                    x.OffDuration = dur.Hours;
                    context.Offwork.Add(x);
                    context.SaveChanges();
                    return true;
                }
            }
            return false;
        }
        public bool add_off(int num = -1, int id = -1, string starttime = null, string endtime = null)
        {

            using (var context = new staff_attendanceContext())
            {
                Offwork x = new Offwork();
                x.WId = id;
                x.OffNum = num;
                x.OffStartTime = DateTime.Parse(starttime);
                x.OffEndTime = DateTime.Parse(endtime);
                TimeSpan dur = (TimeSpan)(x.OffEndTime - x.OffStartTime);
                x.OffDuration = dur.Hours;
                context.Offwork.Add(x);
                context.SaveChanges();
            }
            return false;
        }
        public string off_search(int id = -1, string name = null)
        {
            string ans = "";
            using (var context = new staff_attendanceContext())
            {
                if (id != -1)
                {
                    //得到全部出差记录
                    var off = context.Offwork.Where(x => x.WId == id).ToList();
                    //得到员工信息
                    var workers = context.Worker.ToList();
                    for (int i = 0; i < off.Count; i++)
                    {
                        ans = ans + "<tr><td>" + (i + 1) + "</td>";
                        ans = ans + "<td>" + off[i].OffNum + "</td>";
                        ans = ans + "<td>" + off[i].WId + "</td>";
                        ans = ans + "<td>" + workers[id - 1].WName + "</td>";
                        ans = ans + "<td>" + off[i].OffStartTime + "</td>";
                        ans = ans + "<td>" + off[i].OffEndTime + "</td>";
                        ans = ans + "<td>" + off[i].OffDuration + "</td></tr>";
                    }
                    return ans;
                }

                //如果给的条件是姓名，模糊查询
                else if (name != null)
                {
                    //把员工信息用姓名模糊查询进行筛选
                    var workers = context.Worker.Where(x => x.WName.Contains(name)).ToList();
                    for (int i = 0; i < workers.Count; i++)
                    {
                        var off = context.Offwork.Where(x => x.WId == workers[i].WId).ToList();
                        for (int j = 0; j < off.Count; j++)
                        {
                            ans = ans + "<tr><td>" + (j + 1) + "</td>";
                            ans = ans + "<td>" + off[j].OffNum + "</td>";
                            ans = ans + "<td>" + off[j].WId + "</td>";
                            ans = ans + "<td>" + workers[i].WName + "</td>";
                            ans = ans + "<td>" + off[j].OffStartTime + "</td>";
                            ans = ans + "<td>" + off[j].OffEndTime + "</td>";
                            ans = ans + "<td>" + off[j].OffDuration + "</td><tr>";
                        }
                    }
                    return ans;
                }

            }
            return null;
        }


    }
}



