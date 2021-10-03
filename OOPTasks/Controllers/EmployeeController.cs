using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OOPTasks.Models;
namespace OOPTasks.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("EmployeeView");
        }

        public IActionResult Action()
        {
            var Type = Request.Form["List"];
            if (Type == "Hourly")
            {
                HourlyEmployee HEmp = new HourlyEmployee();
                HEmp._F_Name = Request.Form["TxtFirst"];
                HEmp._L_Name = Request.Form["TxtLast"];
                HEmp._Email = Request.Form["TxtEmail"];
                HEmp._Phone = Convert.ToInt32(Request.Form["TxtPhone"]);
                HEmp._Hours = Convert.ToInt32(Request.Form["TxtHours"]);
                HEmp._Hour_Price = Convert.ToDouble(Request.Form["TxtHourPrice"]);

                bool Check = HEmp.Check();
                if (Check == true)
                {
                    double Salary = HEmp.Calc();
                    String Msg = HEmp.Print(Salary,Type);
                    ViewData["Msg"] = Msg;
                }
            }
            else if (Type == "Daily")
            {
                DailyEmployee DEmp = new DailyEmployee();
                DEmp._F_Name = Request.Form["TxtFirst"];
                DEmp._L_Name = Request.Form["TxtLast"];
                DEmp._Email = Request.Form["TxtEmail"];
                DEmp._Phone = Convert.ToInt32(Request.Form["TxtPhone"]);
                DEmp._Day = Convert.ToInt32(Request.Form["TxtDay"]);
                DEmp._Day_Price = Convert.ToDouble(Request.Form["TxtDayPrice"]);

                bool Check = DEmp.Check();
                if (Check == true)
                {
                    double Salary = DEmp.Calc();
                    String Msg = DEmp.Print(Salary,Type);
                    ViewData["Msg"] = Msg;
                }
            }
                return View("EmployeeView");
        }
    }
}
